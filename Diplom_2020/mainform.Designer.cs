using DE_Pro.Properties;
namespace DE_Pro
{
    partial class mainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.yearcheck = new MaterialSkin.Controls.MaterialCheckBox();
            this.monthcheck = new MaterialSkin.Controls.MaterialCheckBox();
            this.monthbox = new System.Windows.Forms.ComboBox();
            this.showtab = new MaterialSkin.Controls.MaterialRaisedButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.unload = new MaterialSkin.Controls.MaterialRaisedButton();
            this.newdata = new MaterialSkin.Controls.MaterialCheckBox();
            this.add = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.open_excel = new System.Windows.Forms.ToolStripMenuItem();
            this.server_replace = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.remove_Bd = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // yearcheck
            // 
            this.yearcheck.Depth = 0;
            this.yearcheck.Font = new System.Drawing.Font("Roboto", 10F);
            this.yearcheck.Location = new System.Drawing.Point(4, 25);
            this.yearcheck.Margin = new System.Windows.Forms.Padding(0);
            this.yearcheck.MouseLocation = new System.Drawing.Point(-1, -1);
            this.yearcheck.MouseState = MaterialSkin.MouseState.HOVER;
            this.yearcheck.Name = "yearcheck";
            this.yearcheck.Ripple = true;
            this.yearcheck.Size = new System.Drawing.Size(125, 24);
            this.yearcheck.TabIndex = 15;
            this.yearcheck.Text = "Год";
            this.yearcheck.UseVisualStyleBackColor = true;
            this.yearcheck.MouseClick += new System.Windows.Forms.MouseEventHandler(this.yearcheck_MouseClick);
            // 
            // monthcheck
            // 
            this.monthcheck.Depth = 0;
            this.monthcheck.Font = new System.Drawing.Font("Roboto", 10F);
            this.monthcheck.Location = new System.Drawing.Point(4, 58);
            this.monthcheck.Margin = new System.Windows.Forms.Padding(0);
            this.monthcheck.MouseLocation = new System.Drawing.Point(-1, -1);
            this.monthcheck.MouseState = MaterialSkin.MouseState.HOVER;
            this.monthcheck.Name = "monthcheck";
            this.monthcheck.Ripple = true;
            this.monthcheck.Size = new System.Drawing.Size(125, 24);
            this.monthcheck.TabIndex = 17;
            this.monthcheck.Text = "Месяц";
            this.monthcheck.UseVisualStyleBackColor = true;
            this.monthcheck.CheckedChanged += new System.EventHandler(this.monthcheck_CheckedChanged);
            this.monthcheck.MouseClick += new System.Windows.Forms.MouseEventHandler(this.monthcheck_MouseClick);
            // 
            // monthbox
            // 
            this.monthbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthbox.FormattingEnabled = true;
            this.monthbox.Location = new System.Drawing.Point(2, 99);
            this.monthbox.Name = "monthbox";
            this.monthbox.Size = new System.Drawing.Size(250, 24);
            this.monthbox.TabIndex = 18;
            // 
            // showtab
            // 
            this.showtab.AutoSize = true;
            this.showtab.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.showtab.BackColor = System.Drawing.Color.White;
            this.showtab.Depth = 0;
            this.showtab.Icon = null;
            this.showtab.Location = new System.Drawing.Point(258, 99);
            this.showtab.MaximumSize = new System.Drawing.Size(129, 24);
            this.showtab.MinimumSize = new System.Drawing.Size(129, 24);
            this.showtab.MouseState = MaterialSkin.MouseState.HOVER;
            this.showtab.Name = "showtab";
            this.showtab.Primary = true;
            this.showtab.Size = new System.Drawing.Size(129, 24);
            this.showtab.TabIndex = 19;
            this.showtab.Text = "Вывести";
            this.showtab.UseVisualStyleBackColor = false;
            this.showtab.Click += new System.EventHandler(this.showtab_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(5, 252);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(252, 316);
            this.listBox1.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.showtab);
            this.groupBox1.Controls.Add(this.yearcheck);
            this.groupBox1.Controls.Add(this.monthcheck);
            this.groupBox1.Controls.Add(this.monthbox);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(5, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 126);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выборка данных:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.unload);
            this.groupBox2.Controls.Add(this.newdata);
            this.groupBox2.Enabled = false;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(5, 619);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 82);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Данные:";
            // 
            // unload
            // 
            this.unload.AutoSize = true;
            this.unload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.unload.Depth = 0;
            this.unload.Icon = null;
            this.unload.Location = new System.Drawing.Point(258, 26);
            this.unload.MaximumSize = new System.Drawing.Size(129, 36);
            this.unload.MinimumSize = new System.Drawing.Size(129, 36);
            this.unload.MouseState = MaterialSkin.MouseState.HOVER;
            this.unload.Name = "unload";
            this.unload.Primary = true;
            this.unload.Size = new System.Drawing.Size(129, 36);
            this.unload.TabIndex = 20;
            this.unload.Text = "Выгрузить";
            this.unload.UseVisualStyleBackColor = true;
            this.unload.Click += new System.EventHandler(this.unload_Click);
            // 
            // newdata
            // 
            this.newdata.BackColor = System.Drawing.Color.White;
            this.newdata.Depth = 0;
            this.newdata.Font = new System.Drawing.Font("Roboto", 10F);
            this.newdata.ForeColor = System.Drawing.Color.Black;
            this.newdata.Location = new System.Drawing.Point(2, 33);
            this.newdata.Margin = new System.Windows.Forms.Padding(0);
            this.newdata.MouseLocation = new System.Drawing.Point(-1, -1);
            this.newdata.MouseState = MaterialSkin.MouseState.HOVER;
            this.newdata.Name = "newdata";
            this.newdata.Ripple = true;
            this.newdata.Size = new System.Drawing.Size(125, 24);
            this.newdata.TabIndex = 20;
            this.newdata.Text = "Новые данные";
            this.newdata.UseVisualStyleBackColor = false;
            // 
            // add
            // 
            this.add.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add.AutoSize = true;
            this.add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.add.Depth = 0;
            this.add.Enabled = false;
            this.add.Icon = null;
            this.add.Location = new System.Drawing.Point(5, 567);
            this.add.MaximumSize = new System.Drawing.Size(252, 24);
            this.add.MinimumSize = new System.Drawing.Size(252, 24);
            this.add.MouseState = MaterialSkin.MouseState.HOVER;
            this.add.Name = "add";
            this.add.Primary = true;
            this.add.Size = new System.Drawing.Size(252, 24);
            this.add.TabIndex = 21;
            this.add.Text = "Добавить месяц";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(404, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1103, 577);
            this.dataGridView1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(898, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Сотрудники:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(-1, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1501, 28);
            this.panel1.TabIndex = 25;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1501, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.open_excel,
            this.server_replace,
            this.exit});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 21);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // open_excel
            // 
            this.open_excel.BackColor = System.Drawing.Color.Transparent;
            this.open_excel.Image = global::DE_Pro.Properties.Resources.images1;
            this.open_excel.Name = "open_excel";
            this.open_excel.Size = new System.Drawing.Size(173, 22);
            this.open_excel.Text = "Открыть Exel";
            this.open_excel.Click += new System.EventHandler(this.open_excel_Click);
            // 
            // server_replace
            // 
            this.server_replace.BackColor = System.Drawing.Color.Transparent;
            this.server_replace.Image = global::DE_Pro.Properties.Resources.computer_servers_computer_icons_file_server_computer_software_application_server_fileserver_server_icon;
            this.server_replace.Name = "server_replace";
            this.server_replace.Size = new System.Drawing.Size(173, 22);
            this.server_replace.Text = "Сменить сервер";
            this.server_replace.Click += new System.EventHandler(this.server_replace_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Image = global::DE_Pro.Properties.Resources.kisspng_computer_icons_download_login_icon_design_exit_5ac228729e8c40_0736373515226737786494;
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(173, 22);
            this.exit.Text = "Выход";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.remove_Bd});
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(99, 21);
            this.toolStripMenuItem3.Text = "Инструменты";
            // 
            // remove_Bd
            // 
            this.remove_Bd.BackColor = System.Drawing.Color.Transparent;
            this.remove_Bd.Image = global::DE_Pro.Properties.Resources.kissclipart_data_cleaning_icon_clipart_data_cleansing_computer_34b4eca0e65e887e;
            this.remove_Bd.Name = "remove_Bd";
            this.remove_Bd.Size = new System.Drawing.Size(217, 22);
            this.remove_Bd.Text = "Отчистить таблицу в БД";
            this.remove_Bd.Click += new System.EventHandler(this.remove_Bd_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(37, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 38);
            this.panel2.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Data Export Pro";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(404, 124);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1103, 577);
            this.panel3.TabIndex = 28;
            this.panel3.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::DE_Pro.Properties.Resources.screen_01;
            this.pictureBox2.Location = new System.Drawing.Point(1440, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.pictureBox1.Image = global::DE_Pro.Properties.Resources._1240_logo1;
            this.pictureBox1.Location = new System.Drawing.Point(4, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1512, 706);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1512, 706);
            this.Name = "mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Экспортирование данных";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainform_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialCheckBox yearcheck;
        private MaterialSkin.Controls.MaterialCheckBox monthcheck;
        private MaterialSkin.Controls.MaterialRaisedButton showtab;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialRaisedButton unload;
        private MaterialSkin.Controls.MaterialCheckBox newdata;
        private MaterialSkin.Controls.MaterialRaisedButton add;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.ComboBox monthbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem open_excel;
        private System.Windows.Forms.ToolStripMenuItem server_replace;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem remove_Bd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}