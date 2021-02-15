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
            this.работаСПользовтелямиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateUserPanel = new System.Windows.Forms.Panel();
            this.ErrorTextBox = new System.Windows.Forms.TextBox();
            this.CreateUserButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PasTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SecondNameTextBox = new System.Windows.Forms.TextBox();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.DeleteYserPanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DeleteUserButton = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.LoginUserDeleteTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SrechButton = new System.Windows.Forms.Button();
            this.SerchErrTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.CreateUserPanel.SuspendLayout();
            this.DeleteYserPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.работаСПользовтелямиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1045, 24);
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
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.настройкиToolStripMenuItem_Click);
            // 
            // работаСПользовтелямиToolStripMenuItem
            // 
            this.работаСПользовтелямиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.работаСПользовтелямиToolStripMenuItem.Name = "работаСПользовтелямиToolStripMenuItem";
            this.работаСПользовтелямиToolStripMenuItem.Size = new System.Drawing.Size(154, 20);
            this.работаСПользовтелямиToolStripMenuItem.Text = "Работа с пользовтелями";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // CreateUserPanel
            // 
            this.CreateUserPanel.Controls.Add(this.ErrorTextBox);
            this.CreateUserPanel.Controls.Add(this.CreateUserButton);
            this.CreateUserPanel.Controls.Add(this.label9);
            this.CreateUserPanel.Controls.Add(this.label8);
            this.CreateUserPanel.Controls.Add(this.PasTextBox);
            this.CreateUserPanel.Controls.Add(this.label7);
            this.CreateUserPanel.Controls.Add(this.label6);
            this.CreateUserPanel.Controls.Add(this.label5);
            this.CreateUserPanel.Controls.Add(this.SecondNameTextBox);
            this.CreateUserPanel.Controls.Add(this.FullNameTextBox);
            this.CreateUserPanel.Controls.Add(this.LoginTextBox);
            this.CreateUserPanel.Controls.Add(this.NameTextBox);
            this.CreateUserPanel.Location = new System.Drawing.Point(12, 152);
            this.CreateUserPanel.Name = "CreateUserPanel";
            this.CreateUserPanel.Size = new System.Drawing.Size(354, 216);
            this.CreateUserPanel.TabIndex = 15;
            // 
            // ErrorTextBox
            // 
            this.ErrorTextBox.Location = new System.Drawing.Point(11, 177);
            this.ErrorTextBox.Name = "ErrorTextBox";
            this.ErrorTextBox.Size = new System.Drawing.Size(331, 20);
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
            // PasTextBox
            // 
            this.PasTextBox.Location = new System.Drawing.Point(148, 122);
            this.PasTextBox.Name = "PasTextBox";
            this.PasTextBox.Size = new System.Drawing.Size(194, 20);
            this.PasTextBox.TabIndex = 16;
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
            // SecondNameTextBox
            // 
            this.SecondNameTextBox.Location = new System.Drawing.Point(148, 44);
            this.SecondNameTextBox.Name = "SecondNameTextBox";
            this.SecondNameTextBox.Size = new System.Drawing.Size(194, 20);
            this.SecondNameTextBox.TabIndex = 3;
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(148, 70);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(194, 20);
            this.FullNameTextBox.TabIndex = 2;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(148, 96);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(194, 20);
            this.LoginTextBox.TabIndex = 1;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(148, 15);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(194, 20);
            this.NameTextBox.TabIndex = 0;
            // 
            // DeleteYserPanel
            // 
            this.DeleteYserPanel.Controls.Add(this.textBox1);
            this.DeleteYserPanel.Controls.Add(this.DeleteUserButton);
            this.DeleteYserPanel.Controls.Add(this.label14);
            this.DeleteYserPanel.Controls.Add(this.LoginUserDeleteTextBox);
            this.DeleteYserPanel.Location = new System.Drawing.Point(12, 27);
            this.DeleteYserPanel.Name = "DeleteYserPanel";
            this.DeleteYserPanel.Size = new System.Drawing.Size(482, 119);
            this.DeleteYserPanel.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(331, 20);
            this.textBox1.TabIndex = 19;
            // 
            // DeleteUserButton
            // 
            this.DeleteUserButton.Location = new System.Drawing.Point(13, 41);
            this.DeleteUserButton.Name = "DeleteUserButton";
            this.DeleteUserButton.Size = new System.Drawing.Size(132, 23);
            this.DeleteUserButton.TabIndex = 18;
            this.DeleteUserButton.Text = "Удалить";
            this.DeleteUserButton.UseVisualStyleBackColor = true;
            this.DeleteUserButton.Click += new System.EventHandler(this.DeleteUserButton_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Логин:";
            // 
            // LoginUserDeleteTextBox
            // 
            this.LoginUserDeleteTextBox.Location = new System.Drawing.Point(148, 15);
            this.LoginUserDeleteTextBox.Name = "LoginUserDeleteTextBox";
            this.LoginUserDeleteTextBox.Size = new System.Drawing.Size(194, 20);
            this.LoginUserDeleteTextBox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SerchErrTextBox);
            this.panel1.Controls.Add(this.SrechButton);
            this.panel1.Location = new System.Drawing.Point(500, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 119);
            this.panel1.TabIndex = 21;
            // 
            // SrechButton
            // 
            this.SrechButton.Location = new System.Drawing.Point(16, 7);
            this.SrechButton.Name = "SrechButton";
            this.SrechButton.Size = new System.Drawing.Size(75, 23);
            this.SrechButton.TabIndex = 0;
            this.SrechButton.Text = "Запрос";
            this.SrechButton.UseVisualStyleBackColor = true;
            this.SrechButton.Click += new System.EventHandler(this.SrechButton_Click);
            // 
            // SerchErrTextBox
            // 
            this.SerchErrTextBox.Location = new System.Drawing.Point(16, 36);
            this.SerchErrTextBox.Name = "SerchErrTextBox";
            this.SerchErrTextBox.Size = new System.Drawing.Size(331, 20);
            this.SerchErrTextBox.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(372, 152);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(409, 119);
            this.panel2.TabIndex = 22;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(16, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(331, 20);
            this.textBox2.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Запрос";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(16, 89);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(331, 20);
            this.textBox3.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 552);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DeleteYserPanel);
            this.Controls.Add(this.CreateUserPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.CreateUserPanel.ResumeLayout(false);
            this.CreateUserPanel.PerformLayout();
            this.DeleteYserPanel.ResumeLayout(false);
            this.DeleteYserPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работаСПользовтелямиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.Panel CreateUserPanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SecondNameTextBox;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button CreateUserButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PasTextBox;
        private System.Windows.Forms.TextBox ErrorTextBox;
        private System.Windows.Forms.Panel DeleteYserPanel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button DeleteUserButton;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox LoginUserDeleteTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox SerchErrTextBox;
        private System.Windows.Forms.Button SrechButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
    }
}

