using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using 加压站SCADA._1_界面层;

namespace 加压站SCADA
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string ConneStr = "Data Source=" + Application.StartupPath + @"\DataBase\Pressurization;pooling=true;FildIfMissing=false;";
            new SQLiteService().SetConnectStr(ConneStr);
            Application.Run(new Form1());
            
        }
        public static int TickCount = 0;
        public static SysAdmin CurrentAdmin;
    }
}
