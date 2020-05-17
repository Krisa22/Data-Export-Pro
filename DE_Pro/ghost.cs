using AmRoMessageDialog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DE_Pro
{
    public class Ghost : Mainformm
    {
        private int coutghost;
        private int ibrute;
        private string fio;
        private static new string graf;
        public DataTable table = new DataTable();
        public static DataTable table2 = new DataTable();
        AmRoMessageBox messageBox = new AmRoMessageBox
        {
            Background = "#424242",
            TextColor = "#ffffff",
            IconColor = "#3399ff",
            RippleEffectColor = "#008000",
            ClickEffectColor = "#008000",
            ShowMessageWithEffect = true,
        };
        
        public void Ghost_()
        {
            table = null;
            try
            {
                Mainformm owner = (Mainformm)this.Owner;
                if (this.table == null)
                    this.table = !owner.fchoice ? owner.DS.Tables[owner.monthbox.SelectedItem.ToString()] : owner.DS.Tables[owner.py];
                int rowIndex = table.Rows.Count;
                for (int i = 1; i <= 14; i++) 
                {
                    this.table.Rows.Remove(table.Rows[0]);
                }
                for (int index = 0; index < this.table.Rows.Count; ++index)
                    ++this.coutghost;
                this.coutghost -= 16;
                this.coutghost /= 2;
                if (Mainformm.cout != this.coutghost)
                {
                    messageBox.Show("\tКоличество сотрудников должно быть одинаковым!\t", "\tДобавление месяца\t");
                    return;
                }
                for (int index = 1; index < this.coutghost; ++index)
                    this.table.Rows.RemoveAt(int.Parse(Convert.ToString(index)));
                for (int index = 0; index <= 16; ++index)
                    this.table.Rows.RemoveAt(int.Parse(Convert.ToString(this.coutghost)));
                this.table.Columns.Remove(table.Columns[0]);
                this.table.Columns.Remove(table.Columns[0]);
                this.table.Columns.Remove(table.Columns[1]);
                for (int index1 = 0; index1 < this.coutghost; ++index1)
                {
                    DE_Pro.Ghost.graf = "";
                    for (int index2 = 1; index2 < 32; ++index2)
                        DE_Pro.Ghost.graf = DE_Pro.Ghost.graf + " " + this.table.Rows[this.ibrute][index2].ToString();
                    this.fio = this.table.Rows[this.ibrute][0].ToString();
                    this.table.Rows[this.ibrute] [0] = (object)this.fio;
                    owner.graf = graf;
                    owner.ImportExcelData();
                    this.table.Rows[this.ibrute] [1] = (object)owner.stroka;
                    ++this.ibrute;
                }
                for (int index = 0; index < 43; ++index)
                this.table.Columns.Remove(table.Columns[2]);
                if (owner.dataGridView1[1, 0].Value != null)
                {
                    for (int index = 0; index < this.coutghost; ++index)
                        owner.dataGridView1[1, index].Value = (object)(owner.dataGridView1[1, index].Value.ToString() + this.table.Rows[index] [1].ToString());
                }
                this.table = null;
                return;
            }
            catch (Exception ex)
            {
                messageBox.Show(ex.Message, "\tОшибка:\t");
                this.dataGridView1.DataSource = (object)null;
                return;
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // monthbox
            // 
            this.monthbox.Size = new System.Drawing.Size(250, 24);
            // 
            // ghost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1512, 706);
            this.Name = "ghost";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
    }