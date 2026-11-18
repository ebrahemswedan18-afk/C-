using System;
using System.Windows.Forms;

namespace AlNorWholesale
{
    internal static class Program
    {
        /// <summary>
        /// نقطة البداية الرئيسية لتشغيل تطبيق النور لتجارة الجملة
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // فتح واجهة تسجيل الدخول أولاً قبل الانتقال للشاشة الرئيسية
            using (LoginForm loginForm = new LoginForm())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new Form1());
                }
            }
        }
    }
}
