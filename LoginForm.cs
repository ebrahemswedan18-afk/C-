#pragma warning disable 618
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace AlNorWholesale
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // محاولة تحميل شعار البرنامج إن وُجد
            try
            {
                string basePath = AppDomain.CurrentDomain.BaseDirectory;
                string imgPath1 = Path.Combine(basePath, "Resources", "z.png");
                string imgPath2 = Path.Combine(basePath, "..", "..", "img", "z.png");

                if (File.Exists(imgPath1))
                {
                    picBrandLogo.Image = Image.FromFile(imgPath1);
                }
                else if (File.Exists(imgPath2))
                {
                    picBrandLogo.Image = Image.FromFile(imgPath2);
                }
            }
            catch { }

            // فحص حالة الاتصال في الخلفية بدون رسائل منبثقة
            CheckDatabaseStatus();
        }

        private void CheckDatabaseStatus()
        {
            try
            {
                // اختبار اتصال بقاعدة البيانات
                bool canConnect = DB.CanConnect();
                if (canConnect)
                {
                    lblSysStatus.Text = "● متصل بقاعدة بيانات أوراكل";
                    lblSysStatus.ForeColor = Color.FromArgb(16, 185, 129);
                }
                else
                {
                    lblSysStatus.Text = "● وضع العمل المحلي (قاعدة البيانات غير متصلة)";
                    lblSysStatus.ForeColor = Color.FromArgb(245, 158, 11);
                }
            }
            catch
            {
                lblSysStatus.Text = "● وضع العمل المحلي";
                lblSysStatus.ForeColor = Color.FromArgb(245, 158, 11);
            }
        }

        
       

        // إظهار أو إخفاء كلمة المرور
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        // تسجيل الدخول بالضغط على Enter
        private void Input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        // زر تسجيل الدخول
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // يعطي خطاء اذا كانت الحقول فارغة
            lblErrorMessage.Visible = false;
            // حقل اسم المستخدم 
            string username = txtUsername.Text.Trim();
            // حقل ايميل المستخدم 
            string email = txtEmail.Text.Trim();
            // حقل كلمة سر المستخدم 
            string password = txtPassword.Text;



            // التحقق من إدخال اسم المستخدم
            if (string.IsNullOrWhiteSpace(username))
            {
                ShowError("يرجى إدخال اسم المستخدم!");
                txtUsername.Focus();
                return;
            }

            // التحقق من إدخال البريد الإلكتروني وصيغته
            if (string.IsNullOrWhiteSpace(email))
            {
                ShowError("يرجى إدخال البريد الإلكتروني للمستخدم!");
                txtEmail.Focus();
                return;
            }

            if (!email.Contains("@") || !email.Contains("."))
            {
                ShowError("صيغة البريد الإلكتروني غير صحيحة (مثال: admin@alnor.com)!");
                txtEmail.Focus();
                return;
            }

            // التحقق من إدخال كلمة السر
            if (string.IsNullOrWhiteSpace(password))
            {
                ShowError("يرجى إدخال كلمة المرور!");
                txtPassword.Focus();
                return;
            }

            // التحقق من صحة البيانات
            if (ValidateUser(username, email, password))
            {
                MessageBox.Show($"أهلاً وسهلاً بك ({username}) في نظام النور لتجارة الجملة!", 
                    "تسجيل الدخول ناجح", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                // لتفريغ الحقول بعد اتمام العملية 
                this.Close();
            }
            else
            {
                // رسالة الخطاء عند تسجيل الدخول ببيانات خاطئة

                ShowError("بيانات الدخول غير صحيحة! يرجى التحقق من الاسم أوالإيميل أو كلمة السر.");
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }
        // دالة فحص بيانات المستخدم (في  بالبيانات الإدارية)
        private bool ValidateUser(string username, string email, string password)
        {
            // 1. القبول الفوري لبيانات المدير القياسية
            if ((username.Equals("admin", StringComparison.OrdinalIgnoreCase)

                || username == "ابراهيم" || username == "امجد" || username == "محمد") &&

                email.Equals("team@alnor.com", StringComparison.OrdinalIgnoreCase) &&

                (password == "al123" || password == "al" || password == "123"))
            {
                return true;
            }

            // 2. إذا كان هناك اتصال بقاعدة بيانات أوراكل، نفحص وجود جدول للمستخدمين
            if (DB.CanConnect())
            {
                try
                {
                    // فحص وجود جدول للمستخدمين
                    object tableCount = DB.ExecuteScalar("SELECT COUNT(*) FROM USER_TABLES WHERE TABLE_NAME = 'USERS'");
                    if (tableCount != null && Convert.ToInt32(tableCount) > 0)
                    {
                        string query = "SELECT COUNT(*) FROM USERS WHERE LOWER(USERNAME) = :u AND LOWER(EMAIL) = :e AND PASSWORD = :p";
                        OracleParameter[] pars = new OracleParameter[]
                        {
                            new OracleParameter(":u", OracleType.NVarChar) { Value = username.ToLower() },
                            new OracleParameter(":e", OracleType.NVarChar) { Value = email.ToLower() },
                            new OracleParameter(":p", OracleType.NVarChar) { Value = password }
                        };

                        object count = DB.ExecuteScalar(query, pars);
                        if (count != null && Convert.ToInt32(count) > 0)
                        {
                            return true;
                        }
                    }
                }
                catch { }
            }

            return false;
        }

        private void ShowError(string message)
        {
            lblErrorMessage.Text = "⚠  " + message;
            lblErrorMessage.Visible = true;
        }

        // زر الخروج
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
