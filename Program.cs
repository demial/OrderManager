using LanKeQiang.UI;
using LanKeQiang.UI.FormBase;
using LanKeQiang.UI.UiBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace LanKeQiang
{
    static class Program
    {
        public static Form mainform;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //LoginForm f = new LoginForm();
            //f.ShowDialog();
            //if (LoginForm.isOK)
            //{
                mainform = new MainForm();
                Application.Run(mainform);
            //}
        }
    }
}
