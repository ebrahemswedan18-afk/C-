using System;
using System.Data;
using System.Windows.Forms;

namespace AlNorWholesale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ربط أعمدة الجدول مع أسماء حقول جدول INVOICES و CUSTOMERS
            colRecentInvoiceID.DataPropertyName = "INVOICE_ID";
            colRecentCustomer.DataPropertyName = "CUSTOMER_NAME";
            colRecentDate.DataPropertyName = "INVOICE_DATE";
            colRecentTotal.DataPropertyName = "TOTAL_AMOUNT";

            dgvRecentInvoices.AutoGenerateColumns = false;

            // ربط زر الصفحة الرئيسية إذا لم يكن مربوطاً في المصمم
            btnHome.Click += (s, ev) => LoadRecentInvoices();

            // تحميل آخر الفواتير والإحصائيات
            LoadRecentInvoices();
        }

        // دالة تحميل آخر الفواتير والإحصائيات من قاعدة بيانات أوراكل وعرضها في الجدول
        public void LoadRecentInvoices()
        {
            try
            {
                string query = "SELECT i.INVOICE_ID, c.CUSTOMER_NAME, TO_CHAR(i.INVOICE_DATE, 'YYYY-MM-DD') AS INVOICE_DATE, i.TOTAL_AMOUNT " +
                               "FROM INVOICES i " +
                               "JOIN CUSTOMERS c ON i.CUSTOMER_ID = c.CUSTOMER_ID " +
                               "ORDER BY i.INVOICE_ID DESC";

                DataTable dt = DB.GetData(query);
                dgvRecentInvoices.DataSource = dt;

                // تحديث بطاقات الملخص السريعة
                object pCount = DB.ExecuteScalar("SELECT COUNT(*) FROM PRODUCTS");
                object cCount = DB.ExecuteScalar("SELECT COUNT(*) FROM CUSTOMERS");
                object iCount = DB.ExecuteScalar("SELECT COUNT(*) FROM INVOICES");
                object totalSales = DB.ExecuteScalar("SELECT NVL(SUM(TOTAL_AMOUNT), 0) FROM INVOICES");

                lblCard1Title.Text = $"📦 الأصناف في المخزن: {pCount ?? 0}";
                lblCard2Title.Text = $"👥 العملاء المسجلين: {cCount ?? 0}";
                lblCard3Title.Text = $"🧾 إجمالي الفواتير: {iCount ?? 0}";

                decimal salesValue = (totalSales != null && decimal.TryParse(totalSales.ToString(), out decimal sv)) ? sv : 0;
                lblCard3Sub.Text = $"إجمالي المبيعات: {salesValue:N2} ريال";
            }
            catch { }
        }

        // فحص الاتصال بقاعدة بيانات أوراكل
        private void btnCheckConnection_Click(object sender, EventArgs e)
        {
            if (DB.TestConnection())
            {
                MessageBox.Show("تم الاتصال بقاعدة بيانات أوراكل بنجاح والخدمة تعمل بكفاءة!", "نجاح الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRecentInvoices();
            }
        }

        // الانتقال إلى شاشة إدارة المنتجات
        private void btnProducts_Click(object sender, EventArgs e)
        {
            Form2 fProducts = new Form2();
            fProducts.Show();
            this.Hide();
        }

        // الانتقال إلى شاشة إدارة العملاء
        private void btnCustomers_Click(object sender, EventArgs e)
        {
            Form3 fCustomers = new Form3();
            fCustomers.Show();
            this.Hide();
        }

        // الانتقال إلى شاشة إدارة المبيعات والفواتير
        private void btnSales_Click(object sender, EventArgs e)
        {
            Form4 fSales = new Form4();
            fSales.Show();
            this.Hide();
        }

        // إغلاق التطبيق بالكامل عند إغلاق الشاشة الرئيسية لمنع بقاء نوافذ مخفية في الخلفية
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}
