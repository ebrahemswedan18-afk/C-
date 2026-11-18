#pragma warning disable 618
using System;
using System.Data;
using System.Data.OracleClient;
using System.Windows.Forms;

namespace AlNorWholesale
{
    public partial class Form4 : Form
    {
        // جدول الذاكرة المؤقت لحفظ بنود الفاتورة الحالية
        private DataTable dtInvoiceItems;
        private bool isInitializing = true;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            isInitializing = true;

            // إعداد جدول بنود الفاتورة المؤقت
            SetupInvoiceTable();

            // تعبئة قوائم العملاء والمنتجات من قاعدة بيانات أوراكل
            LoadCustomersComboBox();
            LoadProductsComboBox();

            // توليد رقم فاتورة جديد تلقائياً
            GenerateNewInvoiceID();

            isInitializing = false;
            UpdateSelectedProductPrice();
        }

        // إعداد الجدول المؤقت لأصناف الفاتورة وربطه مع DataGridView
        private void SetupInvoiceTable()
        {
            dtInvoiceItems = new DataTable();
            dtInvoiceItems.Columns.Add("PRODUCT_ID", typeof(int));
            dtInvoiceItems.Columns.Add("PRODUCT_NAME", typeof(string));
            dtInvoiceItems.Columns.Add("QUANTITY", typeof(int));
            dtInvoiceItems.Columns.Add("CARTON_PRICE", typeof(decimal));
            dtInvoiceItems.Columns.Add("LINE_TOTAL", typeof(decimal));

            // ربط أعمدة DataGridView مع أعمدة الجدول المؤقت
            colInvoiceProduct.DataPropertyName = "PRODUCT_NAME";
            colInvoiceQuantity.DataPropertyName = "QUANTITY";
            colInvoicePrice.DataPropertyName = "CARTON_PRICE";
            colInvoiceTotal.DataPropertyName = "LINE_TOTAL";

            dgvInvoiceItems.AutoGenerateColumns = false;
            dgvInvoiceItems.DataSource = dtInvoiceItems;
        }

        // جلب أسماء العملاء وتعبئتهم في ComboBox
        private void LoadCustomersComboBox()
        {
            DataTable dt = DB.GetData("SELECT CUSTOMER_ID, CUSTOMER_NAME FROM CUSTOMERS ORDER BY CUSTOMER_NAME");
            cmbCustomers.DataSource = dt;
            cmbCustomers.DisplayMember = "CUSTOMER_NAME";
            cmbCustomers.ValueMember = "CUSTOMER_ID";
            if (dt.Rows.Count > 0)
            {
                cmbCustomers.SelectedIndex = 0;
            }
        }

        // جلب أسماء المنتجات وتعبئتهم في ComboBox
        private void LoadProductsComboBox()
        {
            DataTable dt = DB.GetData("SELECT PRODUCT_ID, PRODUCT_NAME, CARTON_PRICE, QUANTITY FROM PRODUCTS ORDER BY PRODUCT_NAME");
            cmbProducts.DataSource = dt;
            cmbProducts.DisplayMember = "PRODUCT_NAME";
            cmbProducts.ValueMember = "PRODUCT_ID";

            if (dt.Rows.Count > 0)
            {
                cmbProducts.SelectedIndex = 0;
                UpdateSelectedProductPrice();
            }
        }

        // عند تغيير اختيار المنتج يتم عرض سعر الكرتون تلقائياً
        private void cmbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isInitializing) return;
            UpdateSelectedProductPrice();
        }

        private void UpdateSelectedProductPrice()
        {
            try
            {
                if (cmbProducts.SelectedValue != null && int.TryParse(cmbProducts.SelectedValue.ToString(), out int productId))
                {
                    OracleParameter pId = new OracleParameter(":pid", OracleType.Number) { Value = productId };
                    object priceObj = DB.ExecuteScalar("SELECT CARTON_PRICE FROM PRODUCTS WHERE PRODUCT_ID = :pid", pId);
                    if (priceObj != null && decimal.TryParse(priceObj.ToString(), out decimal price))
                    {
                        txtSalePrice.Text = price.ToString("0.00");
                    }
                    txtSaleQuantity.Text = "1";
                }
            }
            catch { }
        }

        // توليد رقم فاتورة جديد تلقائياً
        private void GenerateNewInvoiceID()
        {
            try
            {
                object maxId = DB.ExecuteScalar("SELECT NVL(MAX(INVOICE_ID), 1000) + 1 FROM INVOICES");
                if (maxId != null && int.TryParse(maxId.ToString(), out int nextId))
                {
                    ttxtInvoiceIDextBox2.Text = nextId.ToString();
                }
                else
                {
                    ttxtInvoiceIDextBox2.Text = "1001";
                }
            }
            catch
            {
                ttxtInvoiceIDextBox2.Text = "1001";
            }
        }

        // حساب الإجمالي الكلي للفاتورة
        private void CalculateGrandTotal()
        {
            decimal total = 0;
            foreach (DataRow row in dtInvoiceItems.Rows)
            {
                if (row.RowState != DataRowState.Deleted)
                {
                    total += Convert.ToDecimal(row["LINE_TOTAL"]);
                }
            }
            lblGrandTotal.Text = total.ToString("0.00");
        }

        // زر إضافة منتج للفاتورة
        private void btnAddToInvoice_Click(object sender, EventArgs e)
        {
            if (cmbProducts.SelectedValue == null || !int.TryParse(cmbProducts.SelectedValue.ToString(), out int productId))
            {
                MessageBox.Show("يرجى اختيار المنتج أولاً!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtSaleQuantity.Text.Trim(), out int qty) || qty <= 0)
            {
                MessageBox.Show("يرجى إدخال كمية صحيحة بالكرتون (أكبر من الصفر)!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSaleQuantity.Focus();
                return;
            }

            if (!decimal.TryParse(txtSalePrice.Text.Trim(), out decimal price) || price <= 0)
            {
                MessageBox.Show("يرجى إدخال سعر بيع صحيح أكبر من الصفر!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSalePrice.Focus();
                return;
            }

            // التحقق من رصيد المخزن في قاعدة البيانات
            OracleParameter pId = new OracleParameter(":pid", OracleType.Number) { Value = productId };
            object stockObj = DB.ExecuteScalar("SELECT QUANTITY FROM PRODUCTS WHERE PRODUCT_ID = :pid", pId);
            int currentStock = (stockObj != null && int.TryParse(stockObj.ToString(), out int s)) ? s : 0;

            // حساب إجمالي الكمية المطلوبة لنفس الصنف داخل الفاتورة الحالية
            int alreadyInGrid = 0;
            DataRow existingRow = null;
            foreach (DataRow row in dtInvoiceItems.Rows)
            {
                if (row.RowState != DataRowState.Deleted && Convert.ToInt32(row["PRODUCT_ID"]) == productId)
                {
                    alreadyInGrid += Convert.ToInt32(row["QUANTITY"]);
                    existingRow = row;
                }
            }

            if (alreadyInGrid + qty > currentStock)
            {
                MessageBox.Show($"الكمية المطلوبة ({alreadyInGrid + qty} كرتون) غير متوفرة في المخزن!\nالكمية المتوفرة حالياً هي: {currentStock} كرتون.",
                    "تنبيه المخزون", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string productName = cmbProducts.Text;

            // إذا كان الصنف مضافاً مسبقاً في الفاتورة يتم تحديث كميته
            if (existingRow != null)
            {
                int newQty = Convert.ToInt32(existingRow["QUANTITY"]) + qty;
                existingRow["QUANTITY"] = newQty;
                existingRow["CARTON_PRICE"] = price;
                existingRow["LINE_TOTAL"] = newQty * price;
            }
            else
            {
                decimal lineTotal = qty * price;
                dtInvoiceItems.Rows.Add(productId, productName, qty, price, lineTotal);
            }

            // تحديث الإجمالي الكلي للفاتورة
            CalculateGrandTotal();

            // إعادة تعيين كمية الإدخال
            txtSaleQuantity.Text = "1";
        }

        // زر حذف صنف من الفاتورة
        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (dgvInvoiceItems.CurrentRow != null && dgvInvoiceItems.CurrentRow.Index >= 0)
            {
                int index = dgvInvoiceItems.CurrentRow.Index;
                if (index < dtInvoiceItems.Rows.Count)
                {
                    dtInvoiceItems.Rows.RemoveAt(index);
                    CalculateGrandTotal();
                }
            }
            else
            {
                MessageBox.Show("يرجى اختيار الصنف المراد حذفه من الفاتورة!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // زر حفظ الفاتورة في قاعدة البيانات
        private void btnSaveInvoice_Click(object sender, EventArgs e)
        {
            if (cmbCustomers.SelectedValue == null || !int.TryParse(cmbCustomers.SelectedValue.ToString(), out int customerId))
            {
                MessageBox.Show("يرجى اختيار العميل أولاً لحفظ الفاتورة!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCustomers.Focus();
                return;
            }

            if (dtInvoiceItems.Rows.Count == 0)
            {
                MessageBox.Show("لا يمكن حفظ فاتورة فارغة! يرجى إضافة أصناف إلى الفاتورة أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(ttxtInvoiceIDextBox2.Text.Trim(), out int invoiceId) || invoiceId <= 0)
            {
                MessageBox.Show("رقم الفاتورة غير صحيح!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal totalAmount = decimal.TryParse(lblGrandTotal.Text.Trim(), out decimal t) ? t : 0;
            DateTime invoiceDate = dtpInvoiceDate.Value.Date;

            // تنفيذ الحفظ ضمن Transaction لضمان حفظ الرأس والبنود وخصم المخزن معاً
            bool success = DB.ExecuteTransaction((con, tx) =>
            {
                // 1. إدراج رأس الفاتورة في جدول INVOICES
                string insertInvoiceQuery = "INSERT INTO INVOICES (INVOICE_ID, CUSTOMER_ID, INVOICE_DATE, TOTAL_AMOUNT) " +
                                            "VALUES (:invId, :custId, :invDate, :total)";

                using (OracleCommand cmdInv = new OracleCommand(insertInvoiceQuery, con, tx))
                {
                    cmdInv.Parameters.Add(new OracleParameter(":invId", OracleType.Number) { Value = invoiceId });
                    cmdInv.Parameters.Add(new OracleParameter(":custId", OracleType.Number) { Value = customerId });
                    cmdInv.Parameters.Add(new OracleParameter(":invDate", OracleType.DateTime) { Value = invoiceDate });
                    cmdInv.Parameters.Add(new OracleParameter(":total", OracleType.Number) { Value = totalAmount });
                    cmdInv.ExecuteNonQuery();
                }

                // 2. إدراج كل صنف في جدول INVOICE_ITEMS وتحديث رصيد المخزن في PRODUCTS
                foreach (DataRow row in dtInvoiceItems.Rows)
                {
                    if (row.RowState == DataRowState.Deleted) continue;

                    int pId = Convert.ToInt32(row["PRODUCT_ID"]);
                    int qty = Convert.ToInt32(row["QUANTITY"]);
                    decimal price = Convert.ToDecimal(row["CARTON_PRICE"]);
                    decimal lineTotal = Convert.ToDecimal(row["LINE_TOTAL"]);

                    // إدراج البند في جدول INVOICE_ITEMS
                    string insertItemQuery = "INSERT INTO INVOICE_ITEMS (ITEM_ID, INVOICE_ID, PRODUCT_ID, QUANTITY, CARTON_PRICE, LINE_TOTAL) " +
                                             "VALUES (SEQ_INVOICE_ITEMS.NEXTVAL, :invId, :pId, :qty, :price, :lineTotal)";

                    using (OracleCommand cmdItem = new OracleCommand(insertItemQuery, con, tx))
                    {
                        cmdItem.Parameters.Add(new OracleParameter(":invId", OracleType.Number) { Value = invoiceId });
                        cmdItem.Parameters.Add(new OracleParameter(":pId", OracleType.Number) { Value = pId });
                        cmdItem.Parameters.Add(new OracleParameter(":qty", OracleType.Number) { Value = qty });
                        cmdItem.Parameters.Add(new OracleParameter(":price", OracleType.Number) { Value = price });
                        cmdItem.Parameters.Add(new OracleParameter(":lineTotal", OracleType.Number) { Value = lineTotal });
                        cmdItem.ExecuteNonQuery();
                    }

                    // خصم الكمية المباعة من جدول PRODUCTS في المخزن
                    string updateStockQuery = "UPDATE PRODUCTS SET QUANTITY = QUANTITY - :qty WHERE PRODUCT_ID = :pId";
                    using (OracleCommand cmdStock = new OracleCommand(updateStockQuery, con, tx))
                    {
                        cmdStock.Parameters.Add(new OracleParameter(":qty", OracleType.Number) { Value = qty });
                        cmdStock.Parameters.Add(new OracleParameter(":pId", OracleType.Number) { Value = pId });
                        cmdStock.ExecuteNonQuery();
                    }
                }

                return true;
            });

            if (success)
            {
                MessageBox.Show($"تم حفظ الفاتورة رقم ({invoiceId}) بنجاح!\nوتم تسجيل البنود وتحديث أرصدة المخازن بدقة.",
                    "نجاح العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // بدء فاتورة جديدة وتحديث الشاشة
                btnNewInvoice_Click(sender, e);
            }
        }

        // زر فاتورة جديدة
        private void btnNewInvoice_Click(object sender, EventArgs e)
        {
            dtInvoiceItems.Rows.Clear();
            lblGrandTotal.Text = "0.00";
            GenerateNewInvoiceID();
            LoadProductsComboBox(); // تحديث أرصدة المنتجات من قاعدة البيانات
            txtSaleQuantity.Text = "1";
        }

        // العودة إلى الشاشة الرئيسية
        private void btnBackHome_Click(object sender, EventArgs e)
        {
            ReturnToHome();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            ReturnToHome();
        }

        private bool isReturning = false;
        private void ReturnToHome()
        {
            if (isReturning) return;
            isReturning = true;

            foreach (Form f in Application.OpenForms)
            {
                if (f is Form1)
                {
                    f.Show();
                    (f as Form1).LoadRecentInvoices();
                    this.Dispose();
                    return;
                }
            }

            Form1 fHome = new Form1();
            fHome.Show();
            this.Dispose();
        }
    }
}
