#pragma warning disable 618
using System;
using System.Data;
using System.Data.OracleClient;
using System.Windows.Forms;

namespace AlNorWholesale
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // ربط أعمدة الجدول بحقول جدول PRODUCTS في أوراكل
            colProductID.DataPropertyName = "PRODUCT_ID";
            colProductName.DataPropertyName = "PRODUCT_NAME";
            cloCartonPrice.DataPropertyName = "CARTON_PRICE";
            cloQuantity.DataPropertyName = "QUANTITY";

            // تحميل بيانات المنتجات
            LoadProducts();
        }

        // دالة جلب وعرض المنتجات في الجدول
        private void LoadProducts()
        {
            string query = "SELECT PRODUCT_ID, PRODUCT_NAME, CARTON_PRICE, QUANTITY FROM PRODUCTS ORDER BY PRODUCT_ID";
            DataTable dt = DB.GetData(query);
            dgvProducts.DataSource = dt;
        }

        // دالة تفريغ الحقول
        private void ClearFields()
        {
            txtProductID.Clear();
            txtProducName.Clear();
            txtCartonPrice.Clear();
            txtQuantity.Clear();
            txtProductID.Focus();
        }

        // زر إضافة منتج جديد
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            // التحقق من إدخال اسم المنتج
            string productName = txtProducName.Text.Trim();
            if (string.IsNullOrWhiteSpace(productName))
            {
                MessageBox.Show("يرجى إدخال اسم المنتج!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProducName.Focus();
                return;
            }

            // التحقق من صحة سعر الكرتون
            if (!decimal.TryParse(txtCartonPrice.Text.Trim(), out decimal price) || price <= 0)
            {
                MessageBox.Show("يرجى إدخال سعر كرتون صحيح أكبر من الصفر!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCartonPrice.Focus();
                return;
            }

            // التحقق من صحة الكمية بالكرتون
            if (!int.TryParse(txtQuantity.Text.Trim(), out int qty) || qty < 0)
            {
                MessageBox.Show("يرجى إدخال كمية صحيحة أكبر من أو تساوي الصفر!", "تنبيه",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Focus();
                return;
            }

            // التحقق من رقم المنتج إن تم إدخاله يدوياً أو استخدام المتتالية
            string query;
            OracleParameter[] parameters;

            if (!string.IsNullOrWhiteSpace(txtProductID.Text))
            {
                if (!int.TryParse(txtProductID.Text.Trim(), out int customId) || customId <= 0)
                {
                    MessageBox.Show("يرجى إدخال رقم منتج صحيح أو ترك الحقل فارغاً للتوليد التلقائي!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtProductID.Focus();
                    return;
                }

                query = "INSERT INTO PRODUCTS (PRODUCT_ID, PRODUCT_NAME, CARTON_PRICE, QUANTITY) VALUES (:pid, :pname, :price, :qty)";
                parameters = new OracleParameter[]
                {
                    new OracleParameter(":pid", OracleType.Number) { Value = customId },
                    new OracleParameter(":pname", OracleType.NVarChar) { Value = productName },
                    new OracleParameter(":price", OracleType.Number) { Value = price },
                    new OracleParameter(":qty", OracleType.Number) { Value = qty }
                };
            }
            else
            {
                query = "INSERT INTO PRODUCTS (PRODUCT_ID, PRODUCT_NAME, CARTON_PRICE, QUANTITY) VALUES (SEQ_PRODUCTS.NEXTVAL, :pname, :price, :qty)";
                parameters = new OracleParameter[]
                {
                    new OracleParameter(":pname", OracleType.NVarChar) { Value = productName },
                    new OracleParameter(":price", OracleType.Number) { Value = price },
                    new OracleParameter(":qty", OracleType.Number) { Value = qty }
                };
            }

            if (DB.Execute(query, parameters))
            {
                MessageBox.Show("تمت إضافة المنتج بنجاح!", "إضافة منتج", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProducts();
                ClearFields();
            }
        }

        // زر تعديل منتج
        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductID.Text) || !int.TryParse(txtProductID.Text.Trim(), out int productId))
            {
                MessageBox.Show("يرجى تحديد المنتج أولاً للتعديل!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string productName = txtProducName.Text.Trim();
            if (string.IsNullOrWhiteSpace(productName))
            {
                MessageBox.Show("يرجى إدخال اسم المنتج!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProducName.Focus();
                return;
            }

            if (!decimal.TryParse(txtCartonPrice.Text.Trim(), out decimal price) || price <= 0)
            {
                MessageBox.Show("يرجى إدخال سعر كرتون صحيح أكبر من الصفر!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCartonPrice.Focus();
                return;
            }

            if (!int.TryParse(txtQuantity.Text.Trim(), out int qty) || qty < 0)
            {
                MessageBox.Show("يرجى إدخال كمية صحيحة أكبر من أو تساوي الصفر!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Focus();
                return;
            }

            string query = "UPDATE PRODUCTS SET PRODUCT_NAME = :pname, CARTON_PRICE = :price, QUANTITY = :qty WHERE PRODUCT_ID = :pid";

            OracleParameter[] parameters = new OracleParameter[]
            {
                new OracleParameter(":pname", OracleType.NVarChar) { Value = productName },
                new OracleParameter(":price", OracleType.Number) { Value = price },
                new OracleParameter(":qty", OracleType.Number) { Value = qty },
                new OracleParameter(":pid", OracleType.Number) { Value = productId }
            };

            if (DB.Execute(query, parameters))
            {
                MessageBox.Show("تم تعديل بيانات المنتج بنجاح!", "تعديل منتج", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProducts();
                ClearFields();
            }
        }

        // زر حذف منتج
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductID.Text) || !int.TryParse(txtProductID.Text.Trim(), out int productId))
            {
                MessageBox.Show("يرجى تحديد المنتج أولاً لحذفه!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("هل أنت متأكد من حذف هذا المنتج نهائياً من النظام؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM PRODUCTS WHERE PRODUCT_ID = :pid";
                OracleParameter pId = new OracleParameter(":pid", OracleType.Number) { Value = productId };

                if (DB.Execute(query, pId))
                {
                    MessageBox.Show("تم حذف المنتج بنجاح!", "حذف منتج", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProducts();
                    ClearFields();
                }
            }
        }

        // زر تفريغ الحقول
        private void btnClearProduct_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        // عند النقر على أي صف في الجدول يتم تعبئة الحقول تلقائياً
        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProducts.Rows[e.RowIndex];
                txtProductID.Text = row.Cells["colProductID"].Value?.ToString();
                txtProducName.Text = row.Cells["colProductName"].Value?.ToString();
                txtCartonPrice.Text = row.Cells["cloCartonPrice"].Value?.ToString();
                txtQuantity.Text = row.Cells["cloQuantity"].Value?.ToString();
            }
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

            // إظهار النموذج الرئيسي إذا كان مفتوحاً أو فتح نموذج جديد
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
