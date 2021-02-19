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

            HelperMetods.sDomain = Properties.Settings.Default.Domain;
            HelperMetods.sDomainDefault = Properties.Settings.Default.DomainDefault;
            HelperMetods.sServiceUser = Properties.Settings.Default.ServiceUser;
            HelperMetods.sServicePassword = Properties.Settings.Default.ServicePassword;
            HelperMetods.sDefaultRootOU = String.Format(@"DC={0},DC={1}", Properties.Settings.Default.RootDom, Properties.Settings.Default.RootDNS);

            WorkWithAD.sDomain = Properties.Settings.Default.Domain;
            WorkWithAD.sDomainDefault = Properties.Settings.Default.DomainDefault;
            WorkWithAD.sServiceUser = Properties.Settings.Default.ServiceUser;
            WorkWithAD.sServicePassword = Properties.Settings.Default.ServicePassword;
            WorkWithAD.sDefaultRootOU = String.Format(@"DC={0},DC={1}", Properties.Settings.Default.RootDom, Properties.Settings.Default.RootDNS);

            work_ad.cAD.sDomain = Properties.Settings.Default.Domain;
            work_ad.cAD.sDomainDefault = Properties.Settings.Default.DomainDefault;
            work_ad.cAD.sServiceUser = Properties.Settings.Default.ServiceUser;
            work_ad.cAD.sServicePassword = Properties.Settings.Default.ServicePassword;
            work_ad.cAD.sDefaultRootOU = String.Format(@"DC={0},DC={1}", Properties.Settings.Default.RootDom, Properties.Settings.Default.RootDNS);


            AccountManagement.sDomain = Properties.Settings.Default.Domain;
            AccountManagement.sDomainDefault = Properties.Settings.Default.DomainDefault;
            AccountManagement.sServiceUser = Properties.Settings.Default.ServiceUser;
            AccountManagement.sServicePassword = Properties.Settings.Default.ServicePassword;
            AccountManagement.sDefaultRootOU = String.Format(@"DC={0},DC={1}", Properties.Settings.Default.RootDom, Properties.Settings.Default.RootDNS);
            AccountManagement.sRootDom = Properties.Settings.Default.RootDom;
            AccountManagement.sRootDNS = Properties.Settings.Default.RootDNS;
        }

        private void SreachButton_Click(object sender, EventArgs e)
        {
            if (WorkWithAD.ValidateController())
            {
                SerchErrTextBox.Text = "Server connected";
            }
            else
            {
                SerchErrTextBox.Text = "Server disconnected";
            }
        }
    }
}
