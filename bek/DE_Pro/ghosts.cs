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
    class ghosts : mainformm
    {
        private int coutghost;
        private int ibrute;
        private string fio;
        private static string graf;
        private DataTable table = new DataTable();
        DataColumn column;
        DataRow row;
        AmRoMessageBox messageBox = new AmRoMessageBox
        {
            Background = "#424242",
            TextColor = "#ffffff",
            IconColor = "#3399ff",
            RippleEffectColor = "#008000",
            ClickEffectColor = "#008000",
            ShowMessageWithEffect = true,
        };
        
        public void ghost()
        {
            try
            {
                

               // mainform owner = (mainform)this.Owner;
                if (this.table == null)
                    this.table = !mainformm.fchoice ? DS.Tables[mainformm.ghostvalue] : DS.Tables[py];
                int rowIndex = table.Rows.Count;
                this.table.Rows.RemoveAt(rowIndex);
                this.table.Rows.RemoveAt(rowIndex);
                this.table.Rows.RemoveAt(rowIndex);
                this.table.Rows.RemoveAt(rowIndex);
                this.table.Rows.RemoveAt(rowIndex);
                this.table.Rows.RemoveAt(rowIndex);
                this.table.Rows.RemoveAt(rowIndex);
                this.table.Rows.RemoveAt(rowIndex);
                this.table.Rows.RemoveAt(rowIndex);
                this.table.Rows.RemoveAt(rowIndex);
                this.table.Rows.RemoveAt(rowIndex);
                this.table.Rows.RemoveAt(rowIndex);
                this.table.Rows.RemoveAt(rowIndex);
                this.table.Rows.RemoveAt(rowIndex);
                for (int index = 0; index < this.table.Rows.Count; ++index)
                    ++this.coutghost;
                this.coutghost -= 16;
                this.coutghost /= 2;
                if (mainformm.cout != this.coutghost)
                {
                    messageBox.Show("\tКоличество сотрудников должно быть одинаковым!\t", "\tДобавление месяца\t");
                    return;
                }
                for (int index = 1; index < this.coutghost; ++index)
                    this.table.Rows.RemoveAt(int.Parse(Convert.ToString(index)));
                for (int index = 0; index <= 16; ++index)
                    this.table.Rows.RemoveAt(int.Parse(Convert.ToString(this.coutghost)));
                this.table.Columns.RemoveAt(0);
                this.table.Columns.RemoveAt(0);
                this.table.Columns.RemoveAt(34);
                this.table.Columns.RemoveAt(34);
                this.table.Columns.RemoveAt(34);
                this.table.Columns.RemoveAt(34);
                this.table.Columns.RemoveAt(34);
                this.table.Columns.RemoveAt(34);
                this.table.Columns.RemoveAt(34);
                this.table.Columns.RemoveAt(34);
                this.table.Columns.RemoveAt(34);
                this.table.Columns.RemoveAt(34);
                this.table.Columns.RemoveAt(34);
                this.table.Columns.RemoveAt(34);
                this.table.Columns.RemoveAt(33);
                this.table.Columns.RemoveAt(1);
                for (int index1 = 0; index1 < this.coutghost; ++index1)
                {
                    ghosts.graf = "";
                    for (int index2 = 1; index2 < 32; ++index2)
                        ghosts.graf = ghosts.graf + " " + this.table.Rows[index2][this.ibrute].ToString();
                    this.fio = this.table.Rows[this.ibrute][0].ToString();
                    this.table.Rows[0] [this.ibrute] = (object)this.fio;
                    graf = ghosts.graf;
                    importExcelData();
                    this.table.Rows[1][this.ibrute] = (object)stroka;
                    ++this.ibrute;
                }
                for (int index = 0; index < 30; ++index)
                    this.table.Columns.RemoveAt(2);
                if (dataGridView1[1, 0].Value != null)
                {
                    for (int index = 0; index < this.coutghost; ++index)
                        dataGridView1[1, index].Value = (object)(dataGridView1[1, index].Value.ToString() + this.dataGridView1[1, index].Value.ToString());
                }
                this.dataGridView1.DataSource = (object)null;
                this.Close();
            }
            catch (Exception ex)
            {
                messageBox.Show(ex.Message, "\tОшибка:\t");
                this.dataGridView1.DataSource = (object)null;
                this.Close();
            }

        }
            

        }
    }

    

