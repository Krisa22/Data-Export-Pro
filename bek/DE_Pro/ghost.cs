using AmRoMessageDialog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DE_Pro
{
    public partial class ghost : Form
    {
        private int coutghost;
        private int ibrute;
        private string fio;
        private string graf;

        AmRoMessageBox messageBox = new AmRoMessageBox

        {
            Background = "#424242",
            TextColor = "#ffffff",
            IconColor = "#3399ff",
            RippleEffectColor = "#008000",
            ClickEffectColor = "#008000",
            ShowMessageWithEffect = true,
        };
        public ghost()
        {
            InitializeComponent();
    }
        private void ghost_Load(object sender, EventArgs e)
        {
            try
            {
                mainformm owner = (mainformm)this.Owner;
                if (this.dataGridView1.DataSource == null)
                    this.dataGridView1.DataSource = !owner.fchoice ? (object)owner.DS.Tables[owner.monthbox.SelectedItem.ToString()] : (object)owner.DS.Tables[owner.py];
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
                    ++this.coutghost;
                this.coutghost -= 16;
                this.coutghost /= 2;
                if (mainformm.cout != this.coutghost)
                {
                    this.Close();
                    messageBox.Show("\tКоличество сотрудников должно быть одинаковым!\t", "\tДобавление месяца\t");
                }
                for (int index = 1; index < this.coutghost; ++index)
                    this.dataGridView1.Rows.RemoveAt(int.Parse(Convert.ToString(index)));
                for (int index = 0; index <= 16; ++index)
                    this.dataGridView1.Rows.RemoveAt(int.Parse(Convert.ToString(this.coutghost)));
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
                for (int index1 = 0; index1 < this.coutghost; ++index1)
                {
                    this.graf = "";
                    for (int index2 = 1; index2 < 32; ++index2)
                        this.graf = this.graf + " " + this.dataGridView1[index2, this.ibrute].Value.ToString();
                    this.fio = this.dataGridView1.Rows[this.ibrute].Cells[0].Value.ToString();
                    this.dataGridView1[0, this.ibrute].Value = (object)this.fio;
                    owner.graf = this.graf;
                    owner.importExcelData();
                    this.dataGridView1[1, this.ibrute].Value = (object)owner.stroka;
                    this.dataGridView1.Refresh();
                    ++this.ibrute;
                }
                for (int index = 0; index < 30; ++index)
                    this.dataGridView1.Columns.RemoveAt(2);
                if (owner.dataGridView1[1, 0].Value != null)
                {
                    for (int index = 0; index < this.coutghost; ++index)
                        owner.dataGridView1[1, index].Value = (object)(owner.dataGridView1[1, index].Value.ToString() + this.dataGridView1[1, index].Value.ToString());
                }
                this.dataGridView1.DataSource = (object)null;
                this.Close();
            }
            catch (Exception ex)
            {
                messageBox.Show(ex.Message,"\tОшибка:\t");
                this.dataGridView1.DataSource = (object)null;
                this.Close();
            }

        }
    }
}

