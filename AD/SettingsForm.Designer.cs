namespace AD
{
    partial class SettingsForm
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
            this.DefaultRootOUTextBox2 = new System.Windows.Forms.TextBox();
            this.DefaultRootOUTextBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UserTextbox = new System.Windows.Forms.TextBox();
            this.DomainTextBox = new System.Windows.Forms.TextBox();
            this.DomainDefaultTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DefaultRootOUTextBox2
            // 
            this.DefaultRootOUTextBox2.Location = new System.Drawing.Point(187, 116);
            this.DefaultRootOUTextBox2.Name = "DefaultRootOUTextBox2";
            this.DefaultRootOUTextBox2.Size = new System.Drawing.Size(167, 20);
            this.DefaultRootOUTextBox2.TabIndex = 23;
            // 
            // DefaultRootOUTextBox1
            // 
            this.DefaultRootOUTextBox1.Location = new System.Drawing.Point(12, 116);
            this.DefaultRootOUTextBox1.Name = "DefaultRootOUTextBox1";
            this.DefaultRootOUTextBox1.Size = new System.Drawing.Size(167, 20);
            this.DefaultRootOUTextBox1.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Домен";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Юзер";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Стандартный домен";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(12, 90);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(342, 20);
            this.PasswordTextBox.TabIndex = 16;
            // 
            // UserTextbox
            // 
            this.UserTextbox.Location = new System.Drawing.Point(12, 64);
            this.UserTextbox.Name = "UserTextbox";
            this.UserTextbox.Size = new System.Drawing.Size(342, 20);
            this.UserTextbox.TabIndex = 15;
            // 
            // DomainTextBox
            // 
            this.DomainTextBox.Location = new System.Drawing.Point(12, 38);
            this.DomainTextBox.Name = "DomainTextBox";
            this.DomainTextBox.Size = new System.Drawing.Size(342, 20);
            this.DomainTextBox.TabIndex = 14;
            // 
            // DomainDefaultTextBox
            // 
            this.DomainDefaultTextBox.Location = new System.Drawing.Point(12, 12);
            this.DomainDefaultTextBox.Name = "DomainDefaultTextBox";
            this.DomainDefaultTextBox.Size = new System.Drawing.Size(342, 20);
            this.DomainDefaultTextBox.TabIndex = 13;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(12, 143);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 12;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 186);
            this.Controls.Add(this.DefaultRootOUTextBox2);
            this.Controls.Add(this.DefaultRootOUTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UserTextbox);
            this.Controls.Add(this.DomainTextBox);
            this.Controls.Add(this.DomainDefaultTextBox);
            this.Controls.Add(this.SaveButton);
            this.Name = "SettingsForm";
            this.Text = "Настройки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DefaultRootOUTextBox2;
        private System.Windows.Forms.TextBox DefaultRootOUTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UserTextbox;
        private System.Windows.Forms.TextBox DomainTextBox;
        private System.Windows.Forms.TextBox DomainDefaultTextBox;
        private System.Windows.Forms.Button SaveButton;
    }
}