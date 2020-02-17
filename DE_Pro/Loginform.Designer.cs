namespace DE_Pro
{
    partial class Loginform
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>


        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>


        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loginform));
            this.Exit = new MaterialSkin.Controls.MaterialFlatButton();
            this.server = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.user = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.enter = new MaterialSkin.Controls.MaterialFlatButton();
            this.savedatacheck = new MaterialSkin.Controls.MaterialCheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Exit.Depth = 0;
            this.Exit.Icon = null;
            this.Exit.Location = new System.Drawing.Point(13, 322);
            this.Exit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Exit.MaximumSize = new System.Drawing.Size(139, 36);
            this.Exit.MinimumSize = new System.Drawing.Size(139, 36);
            this.Exit.MouseState = MaterialSkin.MouseState.HOVER;
            this.Exit.Name = "Exit";
            this.Exit.Primary = false;
            this.Exit.Size = new System.Drawing.Size(139, 36);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // server
            // 
            this.server.Depth = 0;
            this.server.Hint = "";
            this.server.Location = new System.Drawing.Point(58, 103);
            this.server.MaxLength = 32767;
            this.server.MouseState = MaterialSkin.MouseState.HOVER;
            this.server.Name = "server";
            this.server.PasswordChar = '\0';
            this.server.SelectedText = "";
            this.server.SelectionLength = 0;
            this.server.SelectionStart = 0;
            this.server.Size = new System.Drawing.Size(204, 23);
            this.server.TabIndex = 1;
            this.server.TabStop = false;
            this.server.UseSystemPasswordChar = false;
            // 
            // user
            // 
            this.user.Depth = 0;
            this.user.Hint = "";
            this.user.Location = new System.Drawing.Point(57, 179);
            this.user.MaxLength = 32767;
            this.user.MouseState = MaterialSkin.MouseState.HOVER;
            this.user.Name = "user";
            this.user.PasswordChar = '\0';
            this.user.SelectedText = "";
            this.user.SelectionLength = 0;
            this.user.SelectionStart = 0;
            this.user.Size = new System.Drawing.Size(205, 23);
            this.user.TabIndex = 2;
            this.user.TabStop = false;
            this.user.UseSystemPasswordChar = false;
            // 
            // password
            // 
            this.password.Depth = 0;
            this.password.Hint = "";
            this.password.Location = new System.Drawing.Point(58, 239);
            this.password.MaxLength = 32767;
            this.password.MouseState = MaterialSkin.MouseState.HOVER;
            this.password.Name = "password";
            this.password.PasswordChar = '\0';
            this.password.SelectedText = "";
            this.password.SelectionLength = 0;
            this.password.SelectionStart = 0;
            this.password.Size = new System.Drawing.Size(204, 23);
            this.password.TabIndex = 3;
            this.password.TabStop = false;
            this.password.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(119, 81);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(71, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "IP-адрес:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(113, 157);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(89, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Имя входа:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(124, 217);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(66, 19);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "Пароль:";
            // 
            // enter
            // 
            this.enter.AutoSize = true;
            this.enter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.enter.Depth = 0;
            this.enter.Icon = null;
            this.enter.Location = new System.Drawing.Point(160, 322);
            this.enter.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.enter.MaximumSize = new System.Drawing.Size(139, 36);
            this.enter.MinimumSize = new System.Drawing.Size(139, 36);
            this.enter.MouseState = MaterialSkin.MouseState.HOVER;
            this.enter.Name = "enter";
            this.enter.Primary = false;
            this.enter.Size = new System.Drawing.Size(139, 36);
            this.enter.TabIndex = 8;
            this.enter.Text = "Подключиться";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // savedatacheck
            // 
            this.savedatacheck.AutoSize = true;
            this.savedatacheck.Depth = 0;
            this.savedatacheck.Font = new System.Drawing.Font("Roboto", 10F);
            this.savedatacheck.Location = new System.Drawing.Point(77, 265);
            this.savedatacheck.Margin = new System.Windows.Forms.Padding(0);
            this.savedatacheck.MouseLocation = new System.Drawing.Point(-1, -1);
            this.savedatacheck.MouseState = MaterialSkin.MouseState.HOVER;
            this.savedatacheck.Name = "savedatacheck";
            this.savedatacheck.Ripple = true;
            this.savedatacheck.Size = new System.Drawing.Size(155, 30);
            this.savedatacheck.TabIndex = 9;
            this.savedatacheck.Text = "Запомнить данные";
            this.savedatacheck.UseVisualStyleBackColor = true;
            this.savedatacheck.CheckedChanged += new System.EventHandler(this.savedatacheck_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DE_Pro.Properties.Resources._1ch;
            this.pictureBox1.Location = new System.Drawing.Point(270, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::DE_Pro.Properties.Resources._802__1_;
            this.pictureBox2.Location = new System.Drawing.Point(270, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // Loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 363);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.savedatacheck);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.user);
            this.Controls.Add(this.server);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Loginform";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Loginform_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton Exit;
        private MaterialSkin.Controls.MaterialSingleLineTextField server;
        private MaterialSkin.Controls.MaterialSingleLineTextField user;
        private MaterialSkin.Controls.MaterialSingleLineTextField password;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialFlatButton enter;
        private MaterialSkin.Controls.MaterialCheckBox savedatacheck;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

