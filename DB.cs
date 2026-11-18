#pragma warning disable 618
using System;
using System.Data;
using System.Data.OracleClient;
using System.Windows.Forms;

namespace AlNorWholesale
{
    /// <summary>
    /// كلاس إدارة الاتصال بقاعدة بيانات أوراكل وتنفيذ الاستعلامات والعمليات
    /// </summary>
    public static class DB
    {
        // نص الاتصال بقاعدة بيانات أوراكل المحلية
        private static string connectionString = "Data Source=localhost:1521/orcl;" +
                                                 "User Id=alnors;" +
                                                 "Password=al;" +
                                                 "Unicode=true;";

        public static string ConnectionString
        {
            get => connectionString;
            set => connectionString = value;
        }

        // دالة لإنشاء كائن اتصال جديد
        public static OracleConnection GetConnection()
        {
            return new OracleConnection(connectionString);
        }

        // دالة فحص الاتصال بقاعدة البيانات
        public static bool TestConnection()
        {
            try
            {
                using (OracleConnection con = GetConnection())
                {
                    con.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("فشل الاتصال بقاعدة البيانات:\n" + FormatOracleError(ex), 
                    "خطأ في الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // دالة فحص الاتصال بدون إظهار رسالة خطأ (تستخدم للفحص الصامت)
        public static bool CanConnect()
        {
            try
            {
                using (OracleConnection con = GetConnection())
                {
                    con.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        // دالة لجلب البيانات من جدول وعرضها في DataTable (SELECT)
        public static DataTable GetData(string query, params OracleParameter[] parameters)
        {
            DataTable dt = new DataTable();
            try
            {
                using (OracleConnection con = GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        if (parameters != null && parameters.Length > 0)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }
                        using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ أثناء جلب البيانات:\n" + FormatOracleError(ex), 
                    "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        // دالة لتنفيذ أوامر الإضافة والتعديل والحذف (INSERT, UPDATE, DELETE)
        public static bool Execute(string query, params OracleParameter[] parameters)
        {
            try
            {
                using (OracleConnection con = GetConnection())
                {
                    con.Open();
                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        if (parameters != null && parameters.Length > 0)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ أثناء تنفيذ العملية:\n" + FormatOracleError(ex), 
                    "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // دالة لجلب قيمة مفردة (مثل أعلى رقم فاتورة أو عدد الصفوف)
        public static object ExecuteScalar(string query, params OracleParameter[] parameters)
        {
            try
            {
                using (OracleConnection con = GetConnection())
                {
                    con.Open();
                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        if (parameters != null && parameters.Length > 0)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }
                        return cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ أثناء جلب القيمة:\n" + FormatOracleError(ex), 
                    "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        // دالة لتنفيذ مجموعة عمليات متتالية ضمن معاملة واحدة (Transaction)
        public static bool ExecuteTransaction(Func<OracleConnection, OracleTransaction, bool> action)
        {
            using (OracleConnection con = GetConnection())
            {
                con.Open();
                using (OracleTransaction tx = con.BeginTransaction())
                {
                    try
                    {
                        bool success = action(con, tx);
                        if (success)
                        {
                            tx.Commit();
                            return true;
                        }
                        else
                        {
                            tx.Rollback();
                            return false;
                        }
                    }
                    catch (Exception ex)
                    {
                        tx.Rollback();
                        MessageBox.Show("حدث خطأ أثناء تنفيذ المعاملة، تم التراجع عن جميع التغييرات:\n" + FormatOracleError(ex),
                            "خطأ في حفظ البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }

        // دالة لترجمة وتنسيق رسائل أخطاء أوراكل باللغة العربية
        public static string FormatOracleError(Exception ex)
        {
            if (ex == null) return "خطأ غير معروف";
            string msg = ex.Message;

            if (msg.Contains("ORA-00001"))
                return "هذا السجل أو الاسم موجود مسبقاً في قاعدة البيانات ولا يمكن تكراره (قيد عدم التكرار).";
            if (msg.Contains("ORA-02292"))
                return "لا يمكن إتمام العملية لأن هذا السجل مرتبط ببيانات وفواتير أخرى في النظام (قيد التكامل المرجعي).";
            if (msg.Contains("ORA-02291"))
                return "البيان المرتبط غير موجود في قاعدة البيانات.";
            if (msg.Contains("ORA-02290"))
                return "القيم المدخلة تخالف شروط التحقق في قاعدة البيانات (مثل: السعر أو الكمية يجب أن تكون أكبر من الصفر).";
            if (msg.Contains("ORA-12541") || msg.Contains("ORA-12154") || msg.Contains("ORA-12514"))
                return "تعذر الاتصال بخدمة أوراكل. تأكد من تشغيل Oracle Listener وعنوان الخدمة localhost:1521/orcl.";
            if (msg.Contains("ORA-01017"))
                return "اسم المستخدم أو كلمة المرور لقاعدة بيانات أوراكل غير صحيحة.";
            if (msg.Contains("ORA-01008"))
                return "لم يتم تمرير جميع المتغيرات المطلوبة في الاستعلام.";

            return msg;
        }
    }
}
