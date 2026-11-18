#pragma warning disable 618
using System;
using System.Data;
using System.Data.OracleClient;
using System.Windows.Forms;

namespace AlNorWholesale
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // ربط أعمدة الجدول بحقول جدول CUSTOMERS في أوراكل
            colCustomerID.DataPropertyName = "CUSTOMER_ID";
            colCustomerName.DataPropertyName = "CUSTOMER_NAME";
            colPhone.DataPropertyName = "PHONE";
            colAddress.DataPropertyName = "ADDRESS";

            // تحميل قائمة العملاء
            LoadCustomers();
        }

        // دالة جلب وعرض العملاء في الجدول
        private void LoadCustomers()
        {
            string query = "SELECT CUSTOMER_ID, CUSTOMER_NAME, PHONE, ADDRESS FROM CUSTOMERS ORDER BY CUSTOMER_ID";
            DataTable dt = DB.GetData(query);
            dgvCustomers.DataSource = dt;
        }

        // دالة تفريغ الحقول
        private void ClearFields()
        {
            txtCustomerID.Clear();
            txtCustomerName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtCustomerID.Focus();
        }

        // زر إضافة عميل جديد
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            string customerName = txtCustomerName.Text.Trim();
            if (string.IsNullOrWhiteSpace(customerName))
            {
                MessageBox.Show("يرجى إدخال اسم العميل أولاً!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustomerName.Focus();
                return;
            }

            string phone = txtPhone.Text.Trim();
            string address = txtAddress.Text.Trim();

            string query;
            OracleParameter[] parameters;

            if (!string.IsNullOrWhiteSpace(txtCustomerID.Text))
            {
                if (!int.TryParse(txtCustomerID.Text.Trim(), out int customId) || customId <= 0)
                {
                    MessageBox.Show("يرجى إدخال رقم عميل صحيح أو ترك الحقل فارغاً للتوليد التلقائي!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCustomerID.Focus();
                    return;
                }

                query = "INSERT INTO CUSTOMERS (CUSTOMER_ID, CUSTOMER_NAME, PHONE, ADDRESS) VALUES (:cid, :cname, :phone, :addr)";
                parameters = new OracleParameter[]
                {
                    new OracleParameter(":cid", OracleType.Number) { Value = customId },
                    new OracleParameter(":cname", OracleType.NVarChar) { Value = customerName },
                    new OracleParameter(":phone", OracleType.NVarChar) { Value = (object)phone ?? DBNull.Value },
                    new OracleParameter(":addr", OracleType.NVarChar) { Value = (object)address ?? DBNull.Value }
                };
            }
            else
            {
                query = "INSERT INTO CUSTOMERS (CUSTOMER_ID, CUSTOMER_NAME, PHONE, ADDRESS) VALUES (SEQ_CUSTOMERS.NEXTVAL, :cname, :phone, :addr)";
                parameters = new OracleParameter[]
                {
                    new OracleParameter(":cname", OracleType.NVarChar) { Value = customerName },
                    new OracleParameter(":phone", OracleType.NVarChar) { Value = (object)phone ?? DBNull.Value },
                    new OracleParameter(":addr", OracleType.NVarChar) { Value = (object)address ?? DBNull.Value }
                };
            }

            if (DB.Execute(query, parameters))
            {
                MessageBox.Show("تمت إضافة العميل بنجاح!", "إضافة عميل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCustomers();
                ClearFields();
            }
        }

        // زر تعديل بيانات عميل
        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomerID.Text) || !int.TryParse(txtCustomerID.Text.Trim(), out int customerId))
            {
                MessageBox.Show("يرجى تحديد العميل أولاً لتعديل بياناته!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string customerName = txtCustomerName.Text.Trim();
            if (string.IsNullOrWhiteSpace(customerName))
            {
                MessageBox.Show("يرجى إدخال اسم العميل!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustomerName.Focus();
                return;
            }

            string phone = txtPhone.Text.Trim();
            string address = txtAddress.Text.Trim();

            string query = "UPDATE CUSTOMERS SET CUSTOMER_NAME = :cname, PHONE = :phone, ADDRESS = :addr WHERE CUSTOMER_ID = :cid";

            OracleParameter[] parameters = new OracleParameter[]
            {
                new OracleParameter(":cname", OracleType.NVarChar) { Value = customerName },
                new OracleParameter(":phone", OracleType.NVarChar) { Value = (object)phone ?? DBNull.Value },
                new OracleParameter(":addr", OracleType.NVarChar) { Value = (object)address ?? DBNull.Value },
                new OracleParameter(":cid", OracleType.Number) { Value = customerId }
            };

            if (DB.Execute(query, parameters))
            {
                MessageBox.Show("تم تعديل بيانات العميل بنجاح!", "تعديل عميل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCustomers();
                ClearFields();
            }
        }

        // زر حذف عميل
        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomerID.Text) || !int.TryParse(txtCustomerID.Text.Trim(), out int customerId))
            {
                MessageBox.Show("يرجى تحديد العميل أولاً لحذفه!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("هل أنت متأكد من حذف هذا العميل نهائياً من النظام؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM CUSTOMERS WHERE CUSTOMER_ID = :cid";
                OracleParameter pId = new OracleParameter(":cid", OracleType.Number) { Value = customerId };

                if (DB.Execute(query, pId))
                {
                    MessageBox.Show("تم حذف العميل بنجاح!", "حذف عميل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCustomers();
                    ClearFields();
                }
            }
        }

        // زر تفريغ الحقول
        private void btnClearCustomer_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        // تعبئة الحقول عند النقر على صف في الجدول
        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCustomers.Rows[e.RowIndex];
                txtCustomerID.Text = row.Cells["colCustomerID"].Value?.ToString();
                txtCustomerName.Text = row.Cells["colCustomerName"].Value?.ToString();
                txtPhone.Text = row.Cells["colPhone"].Value?.ToString();
                txtAddress.Text = row.Cells["colAddress"].Value?.ToString();
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
