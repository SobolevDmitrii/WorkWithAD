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
            this.SerchButton = new System.Windows.Forms.Button();
            this.DomainDefaultTextBox = new System.Windows.Forms.TextBox();
            this.DomainTextBox = new System.Windows.Forms.TextBox();
            this.UserTextbox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ReturnTextBox = new System.Windows.Forms.TextBox();
            this.DefaultRootOUTextBox1 = new System.Windows.Forms.TextBox();
            this.DefaultRootOUTextBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SerchButton
            // 
            this.SerchButton.Location = new System.Drawing.Point(12, 144);
            this.SerchButton.Name = "SerchButton";
            this.SerchButton.Size = new System.Drawing.Size(75, 23);
            this.SerchButton.TabIndex = 0;
            this.SerchButton.Text = "Запрс";
            this.SerchButton.UseVisualStyleBackColor = true;
            this.SerchButton.Click += new System.EventHandler(this.SerchButton_Click);
            // 
            // DomainDefaultTextBox
            // 
            this.DomainDefaultTextBox.Location = new System.Drawing.Point(12, 13);
            this.DomainDefaultTextBox.Name = "DomainDefaultTextBox";
            this.DomainDefaultTextBox.Size = new System.Drawing.Size(342, 20);
            this.DomainDefaultTextBox.TabIndex = 1;
            // 
            // DomainTextBox
            // 
            this.DomainTextBox.Location = new System.Drawing.Point(12, 39);
            this.DomainTextBox.Name = "DomainTextBox";
            this.DomainTextBox.Size = new System.Drawing.Size(342, 20);
            this.DomainTextBox.TabIndex = 2;
            // 
            // UserTextbox
            // 
            this.UserTextbox.Location = new System.Drawing.Point(12, 65);
            this.UserTextbox.Name = "UserTextbox";
            this.UserTextbox.Size = new System.Drawing.Size(342, 20);
            this.UserTextbox.TabIndex = 3;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(12, 91);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(342, 20);
            this.PasswordTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Стандартный домен";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Юзер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Домен";
            // 
            // ReturnTextBox
            // 
            this.ReturnTextBox.Location = new System.Drawing.Point(12, 174);
            this.ReturnTextBox.Multiline = true;
            this.ReturnTextBox.Name = "ReturnTextBox";
            this.ReturnTextBox.Size = new System.Drawing.Size(342, 259);
            this.ReturnTextBox.TabIndex = 9;
            // 
            // DefaultRootOUTextBox1
            // 
            this.DefaultRootOUTextBox1.Location = new System.Drawing.Point(12, 117);
            this.DefaultRootOUTextBox1.Name = "DefaultRootOUTextBox1";
            this.DefaultRootOUTextBox1.Size = new System.Drawing.Size(167, 20);
            this.DefaultRootOUTextBox1.TabIndex = 10;
            // 
            // DefaultRootOUTextBox2
            // 
            this.DefaultRootOUTextBox2.Location = new System.Drawing.Point(187, 117);
            this.DefaultRootOUTextBox2.Name = "DefaultRootOUTextBox2";
            this.DefaultRootOUTextBox2.Size = new System.Drawing.Size(167, 20);
            this.DefaultRootOUTextBox2.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 453);
            this.Controls.Add(this.DefaultRootOUTextBox2);
            this.Controls.Add(this.DefaultRootOUTextBox1);
            this.Controls.Add(this.ReturnTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UserTextbox);
            this.Controls.Add(this.DomainTextBox);
            this.Controls.Add(this.DomainDefaultTextBox);
            this.Controls.Add(this.SerchButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SerchButton;
        private System.Windows.Forms.TextBox DomainDefaultTextBox;
        private System.Windows.Forms.TextBox DomainTextBox;
        private System.Windows.Forms.TextBox UserTextbox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ReturnTextBox;
        private System.Windows.Forms.TextBox DefaultRootOUTextBox1;
        private System.Windows.Forms.TextBox DefaultRootOUTextBox2;
    }
}

