using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DE_Pro
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Logo logo = new Logo();
            DateTime end = DateTime.Now + TimeSpan.FromSeconds(1.5);
            logo.Show();
            while (end > DateTime.Now)
            {
                Application.DoEvents();
            }
            logo.Close();
            logo.Dispose();
            Application.Run(new Loginform());
        }
    }
}
