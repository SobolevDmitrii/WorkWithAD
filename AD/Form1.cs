using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;
using System.DirectoryServices.AccountManagement;



namespace AD
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void SerchButton_Click(object sender, EventArgs e)
        {
            HelperMetods.sDomain = DomainTextBox.Text;
            HelperMetods.sDomainDefault = DomainDefaultTextBox.Text;
            HelperMetods.sServiceUser = UserTextbox.Text;
            HelperMetods.sServicePassword = PasswordTextBox.Text;
            HelperMetods.sDefaultRootOU = String.Format(@"DC={0},DC={1}", DefaultRootOUTextBox1.Text, DefaultRootOUTextBox2.Text);

            if (WorkWithAD.ValidateController())
            {
                ReturnTextBox.Text = "Есть подключение к серверу";
            }
            else
            {
                ReturnTextBox.Text = "Подключение к серверу отсутсвует";
            }
        }
    }
}
