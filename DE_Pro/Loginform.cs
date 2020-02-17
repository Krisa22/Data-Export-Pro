using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;
using AmRoMessageDialog;
using DE_Pro.Properties;
using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;

namespace DE_Pro
{
    public partial class Loginform : MaterialForm
    {
            public static string databasestr = "Orion";
            public static SqlConnection connection;
            public static MySqlConnectionStringBuilder authentication;
            public static SqlDataAdapter da;
            public static DataSet ds;
            public static string serverstr;
            public static string userstr;
            public static string passwordstr;
            AmRoMessageBox messageBox = new AmRoMessageBox

            {
                Background = "#424242",
                TextColor = "#ffffff",
                IconColor = "#3399ff",
                RippleEffectColor = "#008000",
                ClickEffectColor = "#008000",
                ShowMessageWithEffect = true,
            };
     
        public Loginform()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey800, Primary.Grey800, Primary.Green400, Accent.Green400, TextShade.WHITE);
            this.password.UseSystemPasswordChar = true;
            this.server.Text = Settings.Default.server;
            this.user.Text = Settings.Default.user;
            this.password.Text = Settings.Default.password;
            if(server.Text != "")
            {
                savedatacheck.Checked = true;
            }
            
        }
        private void Loginform_FormClosing(object sender, FormClosingEventArgs e) // Выход из программы
        {
            try
            {
                Environment.Exit(0);
                Application.Exit();
            }
            catch (Exception ex)
            {
                messageBox.Show(ex.Message, "\tОшибка\t");
            }
        }
        void Connect()
        {
            try
            {
                if (!savedatacheck.Checked)
                {
                    Settings.Default.server = null;
                    Settings.Default.user = null;
                    Settings.Default.password = null;
                    Settings.Default.Save();
                }
                Invoke((MethodInvoker)delegate {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                enter.Enabled = false;
                });
                Loginform.authentication = new MySqlConnectionStringBuilder();
                Loginform.authentication.Server = this.server.Text;
                Loginform.authentication.UserID = this.user.Text;
                Loginform.authentication.Password = this.password.Text;
                Loginform.authentication.Database = Loginform.databasestr;
                Loginform.connection = new SqlConnection(Loginform.authentication.ConnectionString);
                Loginform.connection.Open();
                Settings.Default.server = this.server.Text;
                Settings.Default.user = this.user.Text;
                Settings.Default.password = this.password.Text;
                Settings.Default.Save();
                Loginform.serverstr = this.server.Text;
                Loginform.userstr = this.user.Text;
                Loginform.passwordstr = this.password.Text;
                Loginform.connection.Close();
                Invoke((MethodInvoker)delegate {
                pictureBox2.Visible = false;
                pictureBox1.Visible = true;
                enter.Enabled = true;
                new mainform().Show();
                this.Hide();
                });
            }
            catch (Exception ex)
            {
                Invoke((MethodInvoker)delegate {
                pictureBox2.Visible = false;
                pictureBox1.Visible = true;
                enter.Enabled = true;
                messageBox.Show("    Не удалось подключиться к серверу. Проверте данные ввода!", "\t\t          Ошибка!\t");
                GC.Collect(1, GCCollectionMode.Forced);
                Loginform.connection.Close();
                });
            }
        }
        private void enter_Click(object sender, EventArgs e)
        {
            try
            {
                Thread connect = new Thread(Connect);
                connect.Start();
            }
            catch (Exception ex)
            {
                Loginform.connection.Close();
                Invoke((MethodInvoker)delegate
                {
                    messageBox.Show("    Не удалось подключиться к серверу. Проверте данные ввода!", "\t\t          Ошибка!\t");
                });
                }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (!savedatacheck.Checked)
            {
                Settings.Default.server = null;
                Settings.Default.user = null;
                Settings.Default.password = null;
                Settings.Default.Save();
            }
                try
            {
                Application.Exit();
                Environment.Exit(0);
            }
            catch (Exception ex)
                {
                    Invoke((MethodInvoker)delegate
                    {
                    messageBox.Show("    Не удалось подключиться к серверу. Проверте данные ввода!", "\t\t          Ошибка!\t");
                    });
                }
        }

        private void savedatacheck_CheckedChanged(object sender, EventArgs e)
        {
            if (savedatacheck.Checked)
            {
                Settings.Default.server = this.server.Text;
                Settings.Default.user = this.user.Text;
                Settings.Default.password = this.password.Text;
                Settings.Default.Save();
            }
            else
            {
                Settings.Default.server = null;
                Settings.Default.user = null;
                Settings.Default.password = null;
                Settings.Default.Save();
            }
        }
    }
}
