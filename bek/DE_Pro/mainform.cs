using AmRoMessageDialog;
using ExcelDataReader;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;


namespace DE_Pro
{
    public partial class mainformm : MaterialForm
    {

        public int py = 1;
        private string invar = "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF";
        private string fevral = "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF";
        private string mart = "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF";
        private string aprel = "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF";
        private string mai = "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF";
        private string iun = "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF";
        private string iul = "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF";
        private string avgust = "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF";
        private string sent = "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF";
        private string oct = "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF";
        private string noibr = "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF";
        private string dekabr = "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF";
        private int brute;
        private string fio;
        public static bool fchoice;
        public string stroka;
        public string graf;
        public static int cout;
        public DataSet DS;
        private string us;
        string monthindex;
        public static string ghostvalue;
        AmRoMessageBox messageBox = new AmRoMessageBox

        {
            Background = "#424242",
            TextColor = "#ffffff",
            IconColor = "#3399ff",
            RippleEffectColor = "#008000",
            ClickEffectColor = "#008000",
            ShowMessageWithEffect = true,
        };
        public mainformm()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey800, Primary.Grey800, Primary.Green400, Accent.Green400, TextShade.WHITE);
            
        }
        private void mainform_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            try
            {
                Loginform.connection.Close();
                Application.Exit();
                Environment.Exit(0);
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void showtab_Click(object sender, EventArgs e)
        {
            bool check;
            if (this.monthbox.Text != "")
            {
                while ((int)monthbox.SelectedIndex != 0)
                {
                    monthbox.Items.RemoveAt(0);
                }
            }
            try
            {
                if (this.dataGridView1.DataSource == null)
                {
                    if (yearcheck.Checked)
                    {
                        this.dataGridView1.DataSource = (object)this.DS.Tables[0];
                        this.showtabvoid();
                        this.showtab.Enabled = false;
                        this.monthbox.Enabled = false;
                        this.groupBox1.Enabled = false;
                        this.add.Enabled = false;
                        this.unload.Enabled = true;
                        panel3.Enabled = false;
                        panel3.Visible = false;
                    }
                    else if (this.monthcheck.Checked)
                    {
                        if (this.monthbox.Text == "")
                        {
                            check = false;
                            messageBox.Show("\t          Выберите месяц!\t");
                        }
                        else
                        {
                            this.dataGridView1.DataSource = (object)this.DS.Tables[this.monthbox.SelectedIndex];
                            this.showtabvoid();
                            this.showtab.Enabled = false;
                            this.add.Enabled = true;
                            this.unload.Enabled = true;
                            this.yearcheck.Enabled = false;
                        }
                    }
                    this.dataGridView1.Columns[0].HeaderText = "ФИО сотрудника";
                    this.dataGridView1.Columns[1].HeaderText = "Календарь сотрудника";
                    this.dataGridView1.AutoResizeColumns();
                    this.dataGridView1.Columns[0].Width = 120;
                    this.groupBox1.Enabled = true;
                }
                if (this.monthcheck.Checked || this.yearcheck.Checked)
                    return;
                int num1 = (int)MessageBox.Show("Данные не выбраны!", "Вывод данных", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                if (check = false)
                {
                    int num = (int)MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }
        public void showtabvoid()
        {
            panel3.Enabled = true;
            panel3.Visible = true;
            int rowIndex = this.dataGridView1.SelectedCells[0].RowIndex;
            this.dataGridView1.Rows.RemoveAt(rowIndex);
            this.dataGridView1.Rows.RemoveAt(rowIndex);
            this.dataGridView1.Rows.RemoveAt(rowIndex);
            this.dataGridView1.Rows.RemoveAt(rowIndex);
            this.dataGridView1.Rows.RemoveAt(rowIndex);
            this.dataGridView1.Rows.RemoveAt(rowIndex);
            this.dataGridView1.Rows.RemoveAt(rowIndex);
            this.dataGridView1.Rows.RemoveAt(rowIndex);
            this.dataGridView1.Rows.RemoveAt(rowIndex);
            this.dataGridView1.Rows.RemoveAt(rowIndex);
            this.dataGridView1.Rows.RemoveAt(rowIndex);
            this.dataGridView1.Rows.RemoveAt(rowIndex);
            this.dataGridView1.Rows.RemoveAt(rowIndex);
            this.dataGridView1.Rows.RemoveAt(rowIndex);
            this.dataGridView1.Refresh();
            this.dataGridView1.AllowUserToAddRows = false;
            for (int index = 0; index < this.dataGridView1.Rows.Count; ++index)
                ++mainformm.cout;
            mainformm.cout -= 16;
            mainformm.cout /= 2;
            this.label1.Text = "Сотрудники:" + Convert.ToString(mainformm.cout);
            for (int index = 1; index < mainformm.cout; ++index)
                this.dataGridView1.Rows.RemoveAt(int.Parse(Convert.ToString(index)));
            for (int index = 0; index <= 16; ++index)
                this.dataGridView1.Rows.RemoveAt(int.Parse(Convert.ToString(mainformm.cout)));
            this.dataGridView1.Refresh();
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Refresh();
            this.dataGridView1.Columns.RemoveAt(0);
            this.dataGridView1.Columns.RemoveAt(0);
            this.dataGridView1.Refresh();
            this.dataGridView1.Columns.RemoveAt(34);
            this.dataGridView1.Columns.RemoveAt(34);
            this.dataGridView1.Columns.RemoveAt(34);
            this.dataGridView1.Columns.RemoveAt(34);
            this.dataGridView1.Columns.RemoveAt(34);
            this.dataGridView1.Columns.RemoveAt(34);
            this.dataGridView1.Columns.RemoveAt(34);
            this.dataGridView1.Columns.RemoveAt(34);
            this.dataGridView1.Columns.RemoveAt(34);
            this.dataGridView1.Columns.RemoveAt(34);
            this.dataGridView1.Columns.RemoveAt(34);
            this.dataGridView1.Columns.RemoveAt(34);
            this.dataGridView1.Columns.RemoveAt(33);
            this.dataGridView1.Columns.RemoveAt(1);
            this.dataGridView1.Refresh();
            for (int index1 = 0; index1 < mainformm.cout; ++index1)
            {
                this.graf = "";
                for (int index2 = 1; index2 < 32; ++index2)
                    this.graf = this.graf + " " + this.dataGridView1[index2, this.brute].Value.ToString();
                this.fio = this.dataGridView1.Rows[this.brute].Cells[0].Value.ToString();
                this.dataGridView1[0, this.brute].Value = (object)this.fio;
                importExcelData();
                this.dataGridView1[1, this.brute].Value = (object)this.stroka;
                this.dataGridView1.Refresh();
                ++this.brute;
            }
            for (int index = 0; index < 30; ++index)
                this.dataGridView1.Columns.RemoveAt(2);
            if (this.yearcheck.Checked)
            {
                mainformm.fchoice = true;
                for (int index = 1; index < 12; ++index)
                {
                    ghostvalue = monthbox.SelectedItem.ToString();
                    ghost ghost = new ghost();
                    ghost.Owner = (Form)this;
                    ghost.Show();
                    ++this.py;
                }
            }
            if (!this.monthcheck.Checked)
                return;
            this.listBox1.Items.Add(this.monthbox.SelectedItem);
            panel3.Enabled = false;
            panel3.Visible = false;
        }
        public void importExcelData()
        {
            
            this.stroka = this.graf;
            this.stroka.Trim();
            this.stroka = this.stroka.Replace(" ", "").Replace("4,5", "0").Replace("7,5", "1").Replace("12", "2").Replace("8", "3").Replace("в", "4").Replace("от", "5");
            char[] charArray = this.stroka.ToCharArray();
            if (this.monthbox.Text == "Январь")
            {
                this.stroka = Convert.ToString(charArray[1].ToString() + (object)charArray[0] + (object)charArray[3] + (object)charArray[2] + (object)charArray[5] + (object)charArray[4]) + (object)charArray[7] + (object)charArray[6] + (object)charArray[9] + (object)charArray[8] + (object)charArray[11] + (object)charArray[10] + (object)charArray[13] + (object)charArray[12] + (object)charArray[15] + (object)charArray[14] + (object)charArray[17] + (object)charArray[16] + (object)charArray[19] + (object)charArray[18] + (object)charArray[21] + (object)charArray[20] + (object)charArray[23] + (object)charArray[22] + (object)charArray[25] + (object)charArray[24] + (object)charArray[27] + (object)charArray[26] + (object)charArray[29] + (object)charArray[28] + "F" + (object)charArray[30];
                this.stroka = "0x" + this.stroka;
                this.invar = this.stroka;
            }
            if (!this.monthcheck.Checked && this.dataGridView1.DataSource.ToString() == "Январь" | this.py == 0 & mainformm.fchoice && !mainformm.fchoice)
            {
                this.stroka = Convert.ToString(charArray[1].ToString() + (object)charArray[0] + (object)charArray[3] + (object)charArray[2] + (object)charArray[5] + (object)charArray[4]) + (object)charArray[7] + (object)charArray[6] + (object)charArray[9] + (object)charArray[8] + (object)charArray[11] + (object)charArray[10] + (object)charArray[13] + (object)charArray[12] + (object)charArray[15] + (object)charArray[14] + (object)charArray[17] + (object)charArray[16] + (object)charArray[19] + (object)charArray[18] + (object)charArray[21] + (object)charArray[20] + (object)charArray[23] + (object)charArray[22] + (object)charArray[25] + (object)charArray[24] + (object)charArray[27] + (object)charArray[26] + (object)charArray[29] + (object)charArray[28] + "F" + (object)charArray[30];
                this.stroka = "0x" + this.stroka;
                this.invar = this.stroka;
            }
            if (this.monthbox.Text == "Февраль" | this.dataGridView1.DataSource.ToString() == "Февраль" | this.py == 1 & mainformm.fchoice)
            {
                this.stroka = Convert.ToString(charArray[1].ToString() + (object)charArray[0] + (object)charArray[3] + (object)charArray[2] + (object)charArray[5] + (object)charArray[4]) + (object)charArray[7] + (object)charArray[6] + (object)charArray[9] + (object)charArray[8] + (object)charArray[11] + (object)charArray[10] + (object)charArray[13] + (object)charArray[12] + (object)charArray[15] + (object)charArray[14] + (object)charArray[17] + (object)charArray[16] + (object)charArray[19] + (object)charArray[18] + (object)charArray[21] + (object)charArray[20] + (object)charArray[23] + (object)charArray[22] + (object)charArray[25] + (object)charArray[24] + (object)charArray[27] + (object)charArray[26] + "FFFF";
                this.fevral = this.stroka;
                if (this.monthcheck.Checked && this.invar == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                    this.stroka = "0xFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" + this.stroka;
            }
            if (this.monthbox.Text == "Март" | this.py == 2 & mainformm.fchoice)
            {
                this.stroka = Convert.ToString(charArray[1].ToString() + (object)charArray[0] + (object)charArray[3] + (object)charArray[2] + (object)charArray[5] + (object)charArray[4] + (object)charArray[7] + (object)charArray[6] + (object)charArray[9] + (object)charArray[8] + (object)charArray[11] + (object)charArray[10] + (object)charArray[13] + (object)charArray[12] + (object)charArray[15] + (object)charArray[14] + (object)charArray[17] + (object)charArray[16] + (object)charArray[19] + (object)charArray[18] + (object)charArray[21] + (object)charArray[20] + (object)charArray[23] + (object)charArray[22] + (object)charArray[25] + (object)charArray[24] + (object)charArray[27] + (object)charArray[26] + (object)charArray[29] + (object)charArray[28] + "F" + (object)charArray[30]);
                this.mart = this.stroka;
                if (this.monthcheck.Checked)
                {
                    if (this.invar == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.fevral == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = "0x" + this.invar + this.fevral + this.stroka;
                    if (this.invar != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.fevral == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = this.fevral + this.stroka;
                }
            }
            if (this.monthbox.Text == "Апрель" | this.py == 3 & mainformm.fchoice)
            {
                this.stroka = Convert.ToString(charArray[1].ToString() + (object)charArray[0] + (object)charArray[3] + (object)charArray[2] + (object)charArray[5] + (object)charArray[4]) + (object)charArray[7] + (object)charArray[6] + (object)charArray[9] + (object)charArray[8] + (object)charArray[11] + (object)charArray[10] + (object)charArray[13] + (object)charArray[12] + (object)charArray[15] + (object)charArray[14] + (object)charArray[17] + (object)charArray[16] + (object)charArray[19] + (object)charArray[18] + (object)charArray[21] + (object)charArray[20] + (object)charArray[23] + (object)charArray[22] + (object)charArray[25] + (object)charArray[24] + (object)charArray[27] + (object)charArray[26] + (object)charArray[29] + (object)charArray[28] + "FF";
                this.aprel = this.stroka;
                if (this.monthcheck.Checked)
                {
                    if (this.mart == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = this.mart + this.stroka;
                    if (this.invar == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.fevral == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mart == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = "0x" + this.invar + this.fevral + this.mart + this.stroka;
                    if (this.invar != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.fevral == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mart == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = this.fevral + this.mart + this.stroka;
                    if (this.invar != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.fevral != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mart == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = this.mart + this.stroka;
                }
            }
            if (this.monthbox.Text == "Май" | this.py == 4 & mainformm.fchoice)
            {
                this.stroka = Convert.ToString(charArray[1].ToString() + (object)charArray[0] + (object)charArray[3] + (object)charArray[2] + (object)charArray[5] + (object)charArray[4]) + (object)charArray[7] + (object)charArray[6] + (object)charArray[9] + (object)charArray[8] + (object)charArray[11] + (object)charArray[10] + (object)charArray[13] + (object)charArray[12] + (object)charArray[15] + (object)charArray[14] + (object)charArray[17] + (object)charArray[16] + (object)charArray[19] + (object)charArray[18] + (object)charArray[21] + (object)charArray[20] + (object)charArray[23] + (object)charArray[22] + (object)charArray[25] + (object)charArray[24] + (object)charArray[27] + (object)charArray[26] + (object)charArray[29] + (object)charArray[28] + "F" + (object)charArray[30];
                this.mai = this.stroka;
                if (this.monthcheck.Checked)
                {
                    if (this.aprel == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = this.aprel + this.stroka;
                    if (this.invar == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.fevral == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mart == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.aprel == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = "0x" + this.invar + this.fevral + this.mart + this.stroka;
                    if (this.invar != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.fevral == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mart == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.aprel == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = this.fevral + this.mart + this.stroka;
                    if (this.fevral != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mart == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.aprel == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = this.mart + this.stroka;
                    int num = this.mart != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.aprel == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" ? 1 : 0;
                }
            }
            if (this.monthbox.Text == "Июнь" | this.py == 5 & mainformm.fchoice)
            {
                this.stroka = Convert.ToString(charArray[1].ToString() + (object)charArray[0] + (object)charArray[3] + (object)charArray[2] + (object)charArray[5] + (object)charArray[4]) + (object)charArray[7] + (object)charArray[6] + (object)charArray[9] + (object)charArray[8] + (object)charArray[11] + (object)charArray[10] + (object)charArray[13] + (object)charArray[12] + (object)charArray[15] + (object)charArray[14] + (object)charArray[17] + (object)charArray[16] + (object)charArray[19] + (object)charArray[18] + (object)charArray[21] + (object)charArray[20] + (object)charArray[23] + (object)charArray[22] + (object)charArray[25] + (object)charArray[24] + (object)charArray[27] + (object)charArray[26] + (object)charArray[29] + (object)charArray[28] + "FF";
                this.iun = this.stroka;
                if (this.monthcheck.Checked)
                {
                    if (this.mai == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = this.mai + this.stroka;
                    if (this.invar == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.fevral == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mart == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.aprel == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mai == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = "0x" + this.invar + this.fevral + this.mart + this.aprel + this.stroka;
                    if (this.invar != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.fevral == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mart == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.aprel == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mai == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = this.fevral + this.mart + this.aprel + this.stroka;
                    if (this.fevral != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mart == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.aprel == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mai == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = this.mart + this.aprel + this.stroka;
                    if (this.mart != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.aprel == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mai == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = this.aprel + this.stroka;
                    if (this.aprel != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mai == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        stroka = this.stroka;
                }
            }
            if (this.monthbox.Text == "Июль" | this.py == 6 & mainformm.fchoice)
            {
                this.stroka = Convert.ToString(charArray[1].ToString() + (object)charArray[0] + (object)charArray[3] + (object)charArray[2] + (object)charArray[5] + (object)charArray[4]) + (object)charArray[7] + (object)charArray[6] + (object)charArray[9] + (object)charArray[8] + (object)charArray[11] + (object)charArray[10] + (object)charArray[13] + (object)charArray[12] + (object)charArray[15] + (object)charArray[14] + (object)charArray[17] + (object)charArray[16] + (object)charArray[19] + (object)charArray[18] + (object)charArray[21] + (object)charArray[20] + (object)charArray[23] + (object)charArray[22] + (object)charArray[25] + (object)charArray[24] + (object)charArray[27] + (object)charArray[26] + (object)charArray[29] + (object)charArray[28] + "F" + (object)charArray[30];
                this.iul = this.stroka;
                if (this.monthcheck.Checked)
                {
                    if (this.iun == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = this.iun + this.stroka;
                    if (this.invar == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.fevral == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mart == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.aprel == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mai == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iun == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = "0x" + this.invar + this.fevral + this.mart + this.aprel + this.mai + this.stroka;
                    if (this.invar != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.fevral == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mart == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.aprel == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mai == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iun == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = this.fevral + this.mart + this.aprel + this.mai + this.stroka;
                    if (this.fevral != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mart == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.aprel == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mai == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iun == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = this.mart + this.aprel + this.mai + this.stroka;
                    if (this.mart != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.aprel == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mai == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iun == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = this.aprel + this.mai + this.stroka;
                    if (this.aprel != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mai == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iun == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = this.mai + this.stroka;
                    if (this.mai != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iun == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = this.stroka;
                }
            }
            if (this.monthbox.Text == "Август" | this.py == 7 & mainformm.fchoice)
            {
                this.stroka = Convert.ToString(charArray[1].ToString() + (object)charArray[0] + (object)charArray[3] + (object)charArray[2] + (object)charArray[5] + (object)charArray[4]) + (object)charArray[7] + (object)charArray[6] + (object)charArray[9] + (object)charArray[8] + (object)charArray[11] + (object)charArray[10] + (object)charArray[13] + (object)charArray[12] + (object)charArray[15] + (object)charArray[14] + (object)charArray[17] + (object)charArray[16] + (object)charArray[19] + (object)charArray[18] + (object)charArray[21] + (object)charArray[20] + (object)charArray[23] + (object)charArray[22] + (object)charArray[25] + (object)charArray[24] + (object)charArray[27] + (object)charArray[26] + (object)charArray[29] + (object)charArray[28] + "F" + (object)charArray[30];
                this.avgust = this.stroka;
                if (this.monthcheck.Checked)
                {
                    if (this.iul == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = this.iul + this.stroka;
                    if (this.invar == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.fevral == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mart == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.aprel == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mai == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iun == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iul == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = "0x" + this.invar + this.fevral + this.mart + this.aprel + this.mai + this.iun + this.stroka;
                    if (this.invar != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.fevral == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mart == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.aprel == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mai == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iun == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iul == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = this.fevral + this.mart + this.aprel + this.mai + this.iun + this.stroka;
                    if (this.fevral != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mart == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.aprel == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mai == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iun == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iul == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = this.mart + this.aprel + this.mai + this.iun + this.stroka;
                    if (this.mart != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.aprel == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mai == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iun == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iul == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = this.aprel + this.mai + this.iun + this.stroka;
                    if (this.aprel != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mai == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iun == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iul == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = this.mai + this.iun + this.stroka;
                    if (this.mai != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iun == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iul == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = this.iun + this.stroka;
                    if (this.iun != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iul == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = this.stroka;
                }
            }
            if (this.monthbox.Text == "Сентябрь" | this.py == 8 & mainformm.fchoice)
            {
                this.stroka = Convert.ToString(charArray[1].ToString() + (object)charArray[0] + (object)charArray[3] + (object)charArray[2] + (object)charArray[5] + (object)charArray[4]) + (object)charArray[7] + (object)charArray[6] + (object)charArray[9] + (object)charArray[8] + (object)charArray[11] + (object)charArray[10] + (object)charArray[13] + (object)charArray[12] + (object)charArray[15] + (object)charArray[14] + (object)charArray[17] + (object)charArray[16] + (object)charArray[19] + (object)charArray[18] + (object)charArray[21] + (object)charArray[20] + (object)charArray[23] + (object)charArray[22] + (object)charArray[25] + (object)charArray[24] + (object)charArray[27] + (object)charArray[26] + (object)charArray[29] + (object)charArray[28] + "FF";
                this.sent = this.stroka;
                if (this.monthcheck.Checked)
                {
                    if (this.avgust == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = this.avgust + this.stroka;
                    if (this.invar == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.fevral == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mart == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.aprel == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mai == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iun == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iul == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.avgust == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = "0x" + this.invar + this.fevral + this.mart + this.aprel + this.mai + this.iun + this.iul + this.stroka;
                    if (this.invar != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.fevral == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mart == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.aprel == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mai == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iun == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iul == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.avgust == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = this.fevral + this.mart + this.aprel + this.mai + this.iun + this.iul + this.stroka;
                    if (this.fevral != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mart == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.aprel == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mai == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iun == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iul == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.avgust == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = this.mart + this.aprel + this.mai + this.iun + this.iul + this.stroka;
                    if (this.mart != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.aprel == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mai == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iun == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iul == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.avgust == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = this.aprel + this.mai + this.iun + this.iul + this.stroka;
                    if (this.aprel != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mai == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iun == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iul == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.avgust == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = this.mai + this.iun + this.iul + this.stroka;
                    if (this.mai != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iun == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iul == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.avgust == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = this.iun + this.iul + this.stroka;
                    if (this.iun != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iul == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.avgust == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = this.iul + this.stroka;
                    if (this.iul != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.avgust == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = this.stroka;
                }
            }
            if (this.monthbox.Text == "Октябрь" | this.py == 9 & mainformm.fchoice)
            {
                this.stroka = Convert.ToString(charArray[1].ToString() + (object)charArray[0] + (object)charArray[3] + (object)charArray[2] + (object)charArray[5] + (object)charArray[4]) + (object)charArray[7] + (object)charArray[6] + (object)charArray[9] + (object)charArray[8] + (object)charArray[11] + (object)charArray[10] + (object)charArray[13] + (object)charArray[12] + (object)charArray[15] + (object)charArray[14] + (object)charArray[17] + (object)charArray[16] + (object)charArray[19] + (object)charArray[18] + (object)charArray[21] + (object)charArray[20] + (object)charArray[23] + (object)charArray[22] + (object)charArray[25] + (object)charArray[24] + (object)charArray[27] + (object)charArray[26] + (object)charArray[29] + (object)charArray[28] + "F" + (object)charArray[30];
                this.oct = this.stroka;
                if (this.monthcheck.Checked)
                {
                    if (this.sent == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = this.sent + this.stroka;
                    if (this.invar == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.fevral == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mart == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.aprel == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mai == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iun == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iul == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.avgust == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.sent == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = "0x" + this.invar + this.fevral + this.mart + this.aprel + this.mai + this.iun + this.iul + this.avgust + this.stroka;
                    if (this.invar != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.fevral == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mart == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.aprel == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mai == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iun == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iul == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.avgust == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.sent == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = this.fevral + this.mart + this.aprel + this.mai + this.iun + this.iul + this.avgust + this.stroka;
                    if (this.fevral != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mart == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.aprel == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mai == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iun == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iul == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.avgust == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.sent == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = this.mart + this.aprel + this.mai + this.iun + this.iul + this.avgust + this.stroka;
                    if (this.mart != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.aprel == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mai == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iun == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iul == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.avgust == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.sent == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = this.aprel + this.mai + this.iun + this.iul + this.avgust + this.stroka;
                    if (this.aprel != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mai == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iun == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iul == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.avgust == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.sent == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = this.mai + this.iun + this.iul + this.avgust + this.stroka;
                    if (this.mai != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iun == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iul == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.avgust == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.sent == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = this.iun + this.iul + this.avgust + this.stroka;
                    if (this.iun != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iul == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.avgust == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.sent == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = this.iul + this.avgust + this.stroka;
                    if (this.iul != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.avgust == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.sent == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = this.avgust + this.stroka;
                    if (this.avgust != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.sent == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = this.stroka;
                }
            }
            if (this.monthbox.Text == "Ноябрь" | this.py == 10 & mainformm.fchoice)
            {
                this.stroka = Convert.ToString(charArray[1].ToString() + (object)charArray[0] + (object)charArray[3] + (object)charArray[2] + (object)charArray[5] + (object)charArray[4]) + (object)charArray[7] + (object)charArray[6] + (object)charArray[9] + (object)charArray[8] + (object)charArray[11] + (object)charArray[10] + (object)charArray[13] + (object)charArray[12] + (object)charArray[15] + (object)charArray[14] + (object)charArray[17] + (object)charArray[16] + (object)charArray[19] + (object)charArray[18] + (object)charArray[21] + (object)charArray[20] + (object)charArray[23] + (object)charArray[22] + (object)charArray[25] + (object)charArray[24] + (object)charArray[27] + (object)charArray[26] + (object)charArray[29] + (object)charArray[28] + "FF";
                this.noibr = this.stroka;
                if (this.monthcheck.Checked)
                {
                    if (this.oct == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = this.oct + this.stroka;
                    if (this.invar == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.fevral == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mart == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.aprel == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mai == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iun == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iul == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.avgust == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.sent == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.oct == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = "0x" + this.invar + this.fevral + this.mart + this.aprel + this.mai + this.iun + this.iul + this.avgust + this.sent + this.stroka;
                    if (this.invar != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.fevral == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mart == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.aprel == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mai == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iun == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iul == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.avgust == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.sent == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.oct == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = this.fevral + this.mart + this.aprel + this.mai + this.iun + this.iul + this.avgust + this.sent + this.stroka;
                    if (this.fevral != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mart == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.aprel == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mai == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iun == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iul == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.avgust == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.sent == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.oct == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = this.mart + this.aprel + this.mai + this.iun + this.iul + this.avgust + this.sent + this.stroka;
                    if (this.mart != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.aprel == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mai == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iun == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iul == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.avgust == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.sent == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.oct == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = this.aprel + this.mai + this.iun + this.iul + this.avgust + this.sent + this.stroka;
                    if (this.aprel != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mai == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iun == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iul == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.avgust == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.sent == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.oct == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = this.mai + this.iun + this.iul + this.avgust + this.sent + this.stroka;
                    if (this.mai != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iun == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iul == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.avgust == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.sent == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.oct == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = this.iun + this.iul + this.avgust + this.sent + this.stroka;
                    if (this.iun != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iul == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.avgust == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.sent == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.oct == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = this.iul + this.avgust + this.sent + this.stroka;
                    if (this.iul != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.avgust == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.sent == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.oct == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = this.avgust + this.sent + this.stroka;
                    if (this.avgust != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.sent == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.oct == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = this.sent + this.stroka;
                    if (this.sent != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.oct == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                        this.stroka = this.stroka;
                }
            }
            if (!(this.monthbox.Text == "Декабрь" | this.dataGridView1.DataSource.ToString() == "Декабрь" | this.py == 11 & mainformm.fchoice))
                return;
            this.stroka = Convert.ToString(charArray[1].ToString() + (object)charArray[0] + (object)charArray[3] + (object)charArray[2] + (object)charArray[5] + (object)charArray[4]) + (object)charArray[7] + (object)charArray[6] + (object)charArray[9] + (object)charArray[8] + (object)charArray[11] + (object)charArray[10] + (object)charArray[13] + (object)charArray[12] + (object)charArray[15] + (object)charArray[14] + (object)charArray[17] + (object)charArray[16] + (object)charArray[19] + (object)charArray[18] + (object)charArray[21] + (object)charArray[20] + (object)charArray[23] + (object)charArray[22] + (object)charArray[25] + (object)charArray[24] + (object)charArray[27] + (object)charArray[26] + (object)charArray[29] + (object)charArray[28] + "F" + (object)charArray[30] + "FFFFFFFFFFFFFFFF";
            this.dekabr = this.stroka;
            if (!this.monthcheck.Checked)
                return;
            if (this.noibr == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                this.stroka = this.noibr + this.stroka;
            if (this.invar == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.fevral == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mart == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.aprel == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mai == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iun == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iul == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.avgust == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.sent == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.oct == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.noibr == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                this.stroka = "0x" + this.invar + this.fevral + this.mart + this.aprel + this.mai + this.iun + this.iul + this.avgust + this.sent + this.oct + this.stroka;
            if (this.invar != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.fevral == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mart == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.aprel == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mai == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iun == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iul == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.avgust == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.sent == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.oct == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.noibr == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                this.stroka = this.fevral + this.mart + this.aprel + this.mai + this.iun + this.iul + this.avgust + this.sent + this.oct + this.stroka;
            if (this.fevral != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mart == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.aprel == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mai == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iun == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iul == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.avgust == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.sent == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.oct == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.noibr == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                this.stroka = this.mart + this.aprel + this.mai + this.iun + this.iul + this.avgust + this.sent + this.oct + this.stroka;
            if (this.mart != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.aprel == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mai == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iun == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iul == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.avgust == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.sent == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.oct == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.noibr == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                this.stroka = this.aprel + this.mai + this.iun + this.iul + this.avgust + this.sent + this.oct + this.stroka;
            if (this.aprel != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mai == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iun == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iul == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.avgust == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.sent == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.oct == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.noibr == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                this.stroka = this.mai + this.iun + this.iul + this.avgust + this.sent + this.oct + this.stroka;
            if (this.mai != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iun == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iul == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.avgust == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.sent == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.oct == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.noibr == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                this.stroka = this.iun + this.iul + this.avgust + this.sent + this.oct + this.stroka;
            if (this.iun != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iul == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.avgust == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.sent == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.oct == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.noibr == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                this.stroka = this.iul + this.avgust + this.sent + this.oct + this.stroka;
            if (this.iul != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.avgust == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.sent == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.oct == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.noibr == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                this.stroka = this.avgust + this.sent + this.oct + this.stroka;
            if (this.avgust != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.sent == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.oct == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.noibr == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                this.stroka = this.sent + this.oct + this.stroka;
            if (this.sent != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.oct == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.noibr == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                this.stroka = this.oct + this.stroka;
            if (!(this.oct != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.noibr == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF"))
                return;
            this.stroka = this.stroka;
            
        }


        private void yearcheck_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.monthcheck.Checked)
                this.monthcheck.Checked = false;
            this.monthbox.Enabled = false;
        }

        private void monthcheck_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.yearcheck.Checked)
                this.yearcheck.Checked = false;
            this.monthbox.Enabled = true;
            if (!(!this.monthcheck.Checked & this.monthbox.Enabled))
                return;
            this.monthbox.Enabled = false;
        }


        private void add_Click(object sender, EventArgs e)
        {
            try
            {

                string text = this.monthbox.Text;
                if (monthbox.Text == "" || dataGridView1.CurrentRow == null)
                {
                    messageBox.Show("\tМесяц не выбран! Выберете месяц и нажмите 'ВЫВЕСТИ'!\t");

                }
                else
                {
                    if (this.listBox1.FindString(text) == -1)
                    {
                        //ghost ghost = new ghost();
                        //ghost.Owner = (Form)this;
                        //ghost.Show();
                        ghosts ghosts = new ghosts();
                        ghosts.ghost();
                        this.listBox1.Items.Add(this.monthbox.SelectedItem);
                    }
                    else
                    {

                        messageBox.Show("\tМесяц " + text + " уже был выбран ранее!\t");
                    }
                }
                while ((int)monthbox.SelectedIndex != 0)
                {
                    monthbox.Items.RemoveAt(0);
                }

            }
            catch (Exception ex)
            {
                messageBox.Show(ex.Message, "    Не удалось добавить данные!");
            }
        }

        private void unload_Click(object sender, EventArgs e)
        {
            try
            {
                Loginform.connection.Open();
                SqlDataReader sqlDataReader1 = new SqlCommand("SELECT MAX(id) FROM GTime ", Loginform.connection).ExecuteReader();
                DataTable dataTable1 = new DataTable();
                dataTable1.Load((IDataReader)sqlDataReader1);
                dataTable1.Rows[0][0].ToString();
                int index1 = 0;
                Loginform.connection.Close();
                if (newdata.Checked == true)
                {
                    SqlCommand sqlCommand = new SqlCommand("DELETE FROM " + "GTime", Loginform.connection);
                    Loginform.connection.Open();
                    sqlCommand.ExecuteNonQuery();
                    Loginform.connection.Close();
                }
                for (int index2 = 0; index2 < mainformm.cout; ++index2)
                {
                    Loginform.connection.Close();
                    if (this.monthcheck.Checked)
                    {
                        if (this.invar != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.fevral == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mart == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.aprel == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mai == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iun == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iul == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.avgust == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.sent == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.oct == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.noibr == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.dekabr == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                            this.dataGridView1[1, index2].Value = (object)(this.dataGridView1[1, index2].Value.ToString() + this.fevral + this.mart + this.aprel + this.mai + this.iun + this.iul + this.avgust + this.sent + this.oct + this.noibr + this.dekabr + "FFFFFFFFFFFFFFFF");
                        if (this.fevral != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mart == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.aprel == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mai == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iun == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iul == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.avgust == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.sent == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.oct == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.noibr == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.dekabr == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                            this.dataGridView1[1, index2].Value = (object)(this.dataGridView1[1, index2].Value.ToString() + this.mart + this.aprel + this.mai + this.iun + this.iul + this.avgust + this.sent + this.oct + this.noibr + this.dekabr + "FFFFFFFFFFFFFFFF");
                        if (this.mart != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.aprel == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mai == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iun == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iul == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.avgust == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.sent == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.oct == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.noibr == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.dekabr == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                            this.dataGridView1[1, index2].Value = (object)(this.dataGridView1[1, index2].Value.ToString() + this.aprel + this.mai + this.iun + this.iul + this.avgust + this.sent + this.oct + this.noibr + this.dekabr + "FFFFFFFFFFFFFFFF");
                        if (this.aprel != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.mai == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iun == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iul == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.avgust == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.sent == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.oct == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.noibr == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.dekabr == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                            this.dataGridView1[1, index2].Value = (object)(this.dataGridView1[1, index2].Value.ToString() + this.mai + this.iun + this.iul + this.avgust + this.sent + this.oct + this.noibr + this.dekabr + "FFFFFFFFFFFFFFFF");
                        if (this.mai != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iun == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iul == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.avgust == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.sent == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.oct == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.noibr == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.dekabr == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                            this.dataGridView1[1, index2].Value = (object)(this.dataGridView1[1, index2].Value.ToString() + this.iun + this.iul + this.avgust + this.sent + this.oct + this.noibr + this.dekabr + "FFFFFFFFFFFFFFFF");
                        if (this.iun != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.iul == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.avgust == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.sent == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.oct == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.noibr == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.dekabr == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                            this.dataGridView1[1, index2].Value = (object)(this.dataGridView1[1, index2].Value.ToString() + this.iul + this.avgust + this.sent + this.oct + this.noibr + this.dekabr + "FFFFFFFFFFFFFFFF");
                        if (this.iul != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.avgust == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.sent == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.oct == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.noibr == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.dekabr == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                            this.dataGridView1[1, index2].Value = (object)(this.dataGridView1[1, index2].Value.ToString() + this.avgust + this.sent + this.oct + this.noibr + this.dekabr + "FFFFFFFFFFFFFFFF");
                        if (this.avgust != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.sent == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.oct == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.noibr == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.dekabr == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                            this.dataGridView1[1, index2].Value = (object)(this.dataGridView1[1, index2].Value.ToString() + this.sent + this.oct + this.noibr + this.dekabr + "FFFFFFFFFFFFFFFF");
                        if (this.sent != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.oct == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.noibr == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.dekabr == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                            this.dataGridView1[1, index2].Value = (object)(this.dataGridView1[1, index2].Value.ToString() + this.oct + this.noibr + this.dekabr + "FFFFFFFFFFFFFFFF");
                        if (this.oct != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.noibr == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.dekabr == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                            this.dataGridView1[1, index2].Value = (object)(this.dataGridView1[1, index2].Value.ToString() + this.noibr + this.dekabr + "FFFFFFFFFFFFFFFF");
                        if (this.noibr != "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" & this.dekabr == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
                            this.dataGridView1[1, index2].Value = (object)(this.dataGridView1[1, index2].Value.ToString() + this.dekabr + "FFFFFFFFFFFFFFFF");
                    }
                    if (newdata.Checked == true)
                    {
                        string lol = dataGridView1[1, index1].Value.ToString();
                        string name = dataGridView1[0, index1].Value.ToString();
                        string sClearSQL = "INSERT INTO GTime VALUES (" + index1 + ", '" + name + "', '', " + lol + " ,0, '0')";
                        SqlCommand SqlCmd = new SqlCommand(sClearSQL, Loginform.connection);
                        Loginform.connection.Open();
                        SqlCmd.ExecuteNonQuery();
                        Loginform.connection.Close();
                        index1++;
                        this.us = this.us + "\n" + (object)index1 + ". " + name;
                    }
                    if (newdata.Checked == false)
                    {
                        try
                        {
                            Loginform.connection.Open();
                            string str1 = this.dataGridView1[0, index1].Value.ToString();
                            SqlDataReader sqlDataReader2 = new SqlCommand("SELECT * FROM GTime WHERE Name LIKE '" + str1 + "'", Loginform.connection).ExecuteReader();
                            DataTable dataTable2 = new DataTable();
                            dataTable2.Load((IDataReader)sqlDataReader2);
                            string str2 = dataTable2.Rows[0][1].ToString();
                            string str3 = dataTable2.Rows[0][0].ToString();
                            if (str2 == str1)
                            {
                                new SqlCommand("UPDATE GTime SET Calendar = " + this.dataGridView1[1, index1].Value.ToString() + " WHERE ID = " + str3, Loginform.connection).ExecuteNonQuery();
                                Loginform.connection.Close();
                            }
                            ++index1;
                            this.us = this.us + "\n" + (object)index1 + ". " + str1;
                        }
                        catch

                        {
                            messageBox.Show("\tНа сервере отсутствуют данные, либо быбран неверный месяц для обновления!\n\t\tСначала нужно загрузить 'Новые данные' а за тем обнавить их!\t\t");
                            reset();
                            return;
                        }
                    }
                }
                if (newdata.Checked == true)
                {
                    messageBox.Show("\tДанные успешно загружены на сервер!\t");
                }
                else
                {
                    messageBox.Show("\tГрафик обновлён для следующих сотрудников: \n" + this.us, "          Данные успешно загружены на сервер!\t");
                }
                this.reset();
                new mainformm().Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                Loginform.connection.Close();
                messageBox.Show(ex.Message, "\tНе удалось выгрузить данные!\t");
            }
        }

        private void reset()
        {
            this.dataGridView1.DataSource = (object)null;
            this.us = (string)null;
            this.DS = (DataSet)null;
            this.dataGridView1.Refresh();
            mainformm.cout = 0;
            this.brute = 0;
            this.listBox1.Items.Clear();
            this.monthbox.Items.Clear();
            this.label1.Text = "Сотрудники: ";
            this.monthbox.Enabled = false;
            this.groupBox1.Enabled = false;
            this.groupBox2.Enabled = false;
            this.add.Enabled = false;
            this.unload.Enabled = false;
            this.monthcheck.Checked = false;
            this.yearcheck.Checked = false;
            this.yearcheck.Enabled = true;
            add.Enabled = false;
            this.stroka = (string)null;
            this.Refresh();
            this.graf = "";
            this.invar = "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF";
            this.fevral = "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF";
            this.mart = "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF";
            this.aprel = "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF";
            this.mai = "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF";
            this.iun = "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF";
            this.iul = "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF";
            this.avgust = "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF";
            this.sent = "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF";
            this.oct = "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF";
            this.noibr = "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF";
            this.dekabr = "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF";
            monthbox.Text = "";
            try
            {
                Loginform.connection.Close();
            }
            catch (Exception ex)
            {
                Loginform.connection.Close();
                messageBox.Show(ex.Message, "\tОшибка!\t");
            }

        }

        private void open_excel_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Excel Files|*.xls;*.xlsx;";
                openFileDialog1.ValidateNames = true;
                using (OpenFileDialog openFileDialog2 = openFileDialog1)
                {
                    if (openFileDialog2.ShowDialog() != DialogResult.OK)
                        return;
                    this.reset();
                    FileStream fileStream = File.Open(openFileDialog2.FileName, FileMode.Open, FileAccess.Read);
                    IExcelDataReader self = openFileDialog2.FilterIndex != 1 ? ExcelReaderFactory.CreateOpenXmlReader((Stream)fileStream, 
                        (ExcelReaderConfiguration)null) : ExcelReaderFactory.CreateBinaryReader((Stream)fileStream, (ExcelReaderConfiguration)null);
                    this.DS = self.AsDataSet((ExcelDataSetConfiguration)null);
                    this.monthbox.Items.Clear();
                    foreach (DataTable table in (InternalDataCollectionBase)this.DS.Tables)
                        this.monthbox.Items.Add((object)table.TableName);
                    self.Close();
                    this.groupBox1.Enabled = true;
                    this.groupBox2.Enabled = true;
                    this.showtab.Enabled = true;
                    this.monthbox.Enabled = false;

                }
            }
            catch (Exception ex)
            {
                messageBox.Show("    " + ex.Message, "\t\t\t\t\t\tНе удалось открыть файл!\t");
            }
        }

        private void server_replace_Click(object sender, EventArgs e)
        {
            try
            {
                new Loginform().Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                messageBox.Show(ex.Message);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            try
            {
                Loginform.connection.Close();
                Application.Exit();
                Environment.Exit(0);
            }
            catch (Exception ex)
            {
                messageBox.Show(ex.Message);
            }

        }

        private void remove_Bd_Click(object sender, EventArgs e)
        {
            try
            {
                var result = messageBox.Show("             Вы уверены, что хотите очистить таблицу?", "\t          Очистка таблицы", AmRoMessageBoxButton.YesNo);
                if (result == AmRoMessageBoxResult.No)
                {
                    return;
                }
                SqlCommand sqlCommand = new SqlCommand("DELETE FROM " + "GTime", Loginform.connection);
                Loginform.connection.Open();
                sqlCommand.ExecuteNonQuery();
                Loginform.connection.Close();
                messageBox.Show("\t\tТаблица очищена!\t\t");
            }
            catch (Exception ex)
            {
                Loginform.connection.Close();
                int num = (int)MessageBox.Show(ex.Message, "Не удалось очистить таблицу!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void monthcheck_CheckedChanged(object sender, EventArgs e)
        {
            add.Enabled = true;
        }

    }
}
