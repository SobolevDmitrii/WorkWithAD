namespace AD
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UsersTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ControlUserTab = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.CreateUserPanel = new System.Windows.Forms.Panel();
            this.PasTextBox = new System.Windows.Forms.TextBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.SecondNameTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.ErrorTextBox = new System.Windows.Forms.TextBox();
            this.CreateUserButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DeleteUserButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginUserDeleteTextBox = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NewPasTexBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SetPasswordButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginUserTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.DisableButtom = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LoginDisableTextBox = new System.Windows.Forms.TextBox();
            this.EnableButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.UsersTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.ControlUserTab.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.CreateUserPanel.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(362, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.настройкиToolStripMenuItem_Click);
            // 
            // UsersTab
            // 
            this.UsersTab.Controls.Add(this.tabPage1);
            this.UsersTab.Controls.Add(this.tabPage2);
            this.UsersTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsersTab.Location = new System.Drawing.Point(0, 24);
            this.UsersTab.Name = "UsersTab";
            this.UsersTab.SelectedIndex = 0;
            this.UsersTab.Size = new System.Drawing.Size(362, 280);
            this.UsersTab.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ControlUserTab);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(354, 254);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Пользователи";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ControlUserTab
            // 
            this.ControlUserTab.Controls.Add(this.tabPage3);
            this.ControlUserTab.Controls.Add(this.tabPage4);
            this.ControlUserTab.Controls.Add(this.tabPage5);
            this.ControlUserTab.Controls.Add(this.tabPage6);
            this.ControlUserTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlUserTab.Location = new System.Drawing.Point(3, 3);
            this.ControlUserTab.Name = "ControlUserTab";
            this.ControlUserTab.SelectedIndex = 0;
            this.ControlUserTab.Size = new System.Drawing.Size(348, 248);
            this.ControlUserTab.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.CreateUserPanel);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(340, 222);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Новый пользователь";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // CreateUserPanel
            // 
            this.CreateUserPanel.Controls.Add(this.PasTextBox);
            this.CreateUserPanel.Controls.Add(this.LoginTextBox);
            this.CreateUserPanel.Controls.Add(this.FullNameTextBox);
            this.CreateUserPanel.Controls.Add(this.SecondNameTextBox);
            this.CreateUserPanel.Controls.Add(this.NameTextBox);
            this.CreateUserPanel.Controls.Add(this.ErrorTextBox);
            this.CreateUserPanel.Controls.Add(this.CreateUserButton);
            this.CreateUserPanel.Controls.Add(this.label9);
            this.CreateUserPanel.Controls.Add(this.label8);
            this.CreateUserPanel.Controls.Add(this.label7);
            this.CreateUserPanel.Controls.Add(this.label6);
            this.CreateUserPanel.Controls.Add(this.label5);
            this.CreateUserPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreateUserPanel.Location = new System.Drawing.Point(3, 3);
            this.CreateUserPanel.Name = "CreateUserPanel";
            this.CreateUserPanel.Size = new System.Drawing.Size(334, 216);
            this.CreateUserPanel.TabIndex = 26;
            // 
            // PasTextBox
            // 
            this.PasTextBox.Location = new System.Drawing.Point(149, 115);
            this.PasTextBox.Name = "PasTextBox";
            this.PasTextBox.Size = new System.Drawing.Size(175, 20);
            this.PasTextBox.TabIndex = 24;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(149, 89);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(175, 20);
            this.LoginTextBox.TabIndex = 23;
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(149, 63);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(175, 20);
            this.FullNameTextBox.TabIndex = 22;
            // 
            // SecondNameTextBox
            // 
            this.SecondNameTextBox.Location = new System.Drawing.Point(149, 37);
            this.SecondNameTextBox.Name = "SecondNameTextBox";
            this.SecondNameTextBox.Size = new System.Drawing.Size(175, 20);
            this.SecondNameTextBox.TabIndex = 21;
            this.SecondNameTextBox.TextChanged += new System.EventHandler(this.SecondNameTextBox_TextChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(149, 11);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(175, 20);
            this.NameTextBox.TabIndex = 20;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // ErrorTextBox
            // 
            this.ErrorTextBox.Location = new System.Drawing.Point(11, 177);
            this.ErrorTextBox.Name = "ErrorTextBox";
            this.ErrorTextBox.Size = new System.Drawing.Size(313, 20);
            this.ErrorTextBox.TabIndex = 19;
            // 
            // CreateUserButton
            // 
            this.CreateUserButton.Location = new System.Drawing.Point(14, 148);
            this.CreateUserButton.Name = "CreateUserButton";
            this.CreateUserButton.Size = new System.Drawing.Size(132, 23);
            this.CreateUserButton.TabIndex = 18;
            this.CreateUserButton.Text = "Создать";
            this.CreateUserButton.UseVisualStyleBackColor = true;
            this.CreateUserButton.Click += new System.EventHandler(this.CreateUserButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Пароль";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Имя входа пользователя";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Полное имя";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Фамилия:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Имя:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(340, 222);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Удалить";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DeleteUserButton);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.LoginUserDeleteTextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 216);
            this.panel2.TabIndex = 28;
            // 
            // DeleteUserButton
            // 
            this.DeleteUserButton.Location = new System.Drawing.Point(14, 41);
            this.DeleteUserButton.Name = "DeleteUserButton";
            this.DeleteUserButton.Size = new System.Drawing.Size(132, 23);
            this.DeleteUserButton.TabIndex = 18;
            this.DeleteUserButton.Text = "Удалить";
            this.DeleteUserButton.UseVisualStyleBackColor = true;
            this.DeleteUserButton.Click += new System.EventHandler(this.DeleteUserButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Логин:";
            // 
            // LoginUserDeleteTextBox
            // 
            this.LoginUserDeleteTextBox.Location = new System.Drawing.Point(58, 15);
            this.LoginUserDeleteTextBox.Name = "LoginUserDeleteTextBox";
            this.LoginUserDeleteTextBox.Size = new System.Drawing.Size(88, 20);
            this.LoginUserDeleteTextBox.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.panel1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(340, 222);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Сменить пароль";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NewPasTexBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.SetPasswordButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LoginUserTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 216);
            this.panel1.TabIndex = 29;
            // 
            // NewPasTexBox
            // 
            this.NewPasTexBox.Location = new System.Drawing.Point(85, 44);
            this.NewPasTexBox.Name = "NewPasTexBox";
            this.NewPasTexBox.Size = new System.Drawing.Size(194, 20);
            this.NewPasTexBox.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 26);
            this.label2.TabIndex = 20;
            this.label2.Text = "Новое\r\n пароль";
            // 
            // SetPasswordButton
            // 
            this.SetPasswordButton.Location = new System.Drawing.Point(14, 70);
            this.SetPasswordButton.Name = "SetPasswordButton";
            this.SetPasswordButton.Size = new System.Drawing.Size(132, 23);
            this.SetPasswordButton.TabIndex = 18;
            this.SetPasswordButton.Text = "Сменить пароль";
            this.SetPasswordButton.UseVisualStyleBackColor = true;
            this.SetPasswordButton.Click += new System.EventHandler(this.SetPasswordButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Логин:";
            // 
            // LoginUserTextBox
            // 
            this.LoginUserTextBox.Location = new System.Drawing.Point(85, 16);
            this.LoginUserTextBox.Name = "LoginUserTextBox";
            this.LoginUserTextBox.Size = new System.Drawing.Size(194, 20);
            this.LoginUserTextBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(354, 254);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Группы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.EnableButton);
            this.tabPage6.Controls.Add(this.DisableButtom);
            this.tabPage6.Controls.Add(this.label4);
            this.tabPage6.Controls.Add(this.LoginDisableTextBox);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(340, 222);
            this.tabPage6.TabIndex = 3;
            this.tabPage6.Text = "Блокировка/Разблокировка";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // DisableButtom
            // 
            this.DisableButtom.Location = new System.Drawing.Point(22, 42);
            this.DisableButtom.Name = "DisableButtom";
            this.DisableButtom.Size = new System.Drawing.Size(132, 23);
            this.DisableButtom.TabIndex = 21;
            this.DisableButtom.Text = "Блокировать";
            this.DisableButtom.UseVisualStyleBackColor = true;
            this.DisableButtom.Click += new System.EventHandler(this.DisableButtom_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Логин:";
            // 
            // LoginDisableTextBox
            // 
            this.LoginDisableTextBox.Location = new System.Drawing.Point(66, 16);
            this.LoginDisableTextBox.Name = "LoginDisableTextBox";
            this.LoginDisableTextBox.Size = new System.Drawing.Size(88, 20);
            this.LoginDisableTextBox.TabIndex = 19;
            // 
            // EnableButton
            // 
            this.EnableButton.Location = new System.Drawing.Point(22, 71);
            this.EnableButton.Name = "EnableButton";
            this.EnableButton.Size = new System.Drawing.Size(132, 23);
            this.EnableButton.TabIndex = 22;
            this.EnableButton.Text = "Рзблокировать";
            this.EnableButton.UseVisualStyleBackColor = true;
            this.EnableButton.Click += new System.EventHandler(this.EnableButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 304);
            this.Controls.Add(this.UsersTab);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.UsersTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ControlUserTab.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.CreateUserPanel.ResumeLayout(false);
            this.CreateUserPanel.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl UsersTab;
        private System.Windows.Forms.TabControl ControlUserTab;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel CreateUserPanel;
        private System.Windows.Forms.TextBox ErrorTextBox;
        private System.Windows.Forms.Button CreateUserButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button DeleteUserButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LoginUserDeleteTextBox;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SetPasswordButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LoginUserTextBox;
        private System.Windows.Forms.TextBox PasTextBox;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.TextBox SecondNameTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox NewPasTexBox;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button DisableButtom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LoginDisableTextBox;
        private System.Windows.Forms.Button EnableButton;
    }
}

