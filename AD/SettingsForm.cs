using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AD
{
    
    public partial class SettingsForm : Form
    {
        Form1 F1;
        public SettingsForm(Form1 _F1)
        {
            F1 = _F1;
            InitializeComponent();
            DomainDefaultTextBox.Text = Properties.Settings.Default.DomainDefault;
            DomainTextBox.Text = Properties.Settings.Default.Domain;
            UserTextbox.Text = Properties.Settings.Default.ServiceUser;
            PasswordTextBox.Text = Properties.Settings.Default.ServicePassword ;
            DefaultRootOUTextBox1.Text = Properties.Settings.Default.RootDom ;
            DefaultRootOUTextBox2.Text = Properties.Settings.Default.RootDNS ;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DomainDefault = DomainDefaultTextBox.Text;
            Properties.Settings.Default.Domain = DomainTextBox.Text;
            Properties.Settings.Default.ServiceUser = UserTextbox.Text;
            Properties.Settings.Default.ServicePassword = PasswordTextBox.Text;
            Properties.Settings.Default.RootDom = DefaultRootOUTextBox1.Text;
            Properties.Settings.Default.RootDNS = DefaultRootOUTextBox2.Text;
            Properties.Settings.Default.Save();

            this.Close();
        }
    }
}
