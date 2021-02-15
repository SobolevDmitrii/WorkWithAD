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
            CreateUserPanel.Visible = false;
            DeleteYserPanel.Visible = false;


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
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            SettingsForm F2 = new SettingsForm(this);
            F2.Show();
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm F2 = new SettingsForm(this);
            F2.Show();
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateUserPanel.Visible = true;
            DeleteYserPanel.Visible = false;
           
        }

        private void CreateUserButton_Click(object sender, EventArgs e)
        {
            UserProperty userProp = new UserProperty();
            userProp.sn = NameTextBox.Text;
            userProp.name = String.Format(@"{0} {1}", SecondNameTextBox.Text, NameTextBox.Text);
            userProp.givenname = SecondNameTextBox.Text;
            userProp.displayname = String.Format(@"{0} {1}", SecondNameTextBox.Text, NameTextBox.Text);
            UserFlags userFlags = new UserFlags();
            userFlags.enable = true;
            userFlags.PasswordNeverExpires = true;
            userFlags.UserCannotChangePassword = false;
            userFlags.ExpirePassword = false;
            string err;

            //AccountManagement.CreateNewUser("users", LoginTextBox.Text, PasTextBox.Text, userProp,userFlags, Properties.Settings.Default.DomainDefault);
            AccountManagement.CreateNewUser("Users", LoginTextBox.Text, PasTextBox.Text, userProp, userFlags, out err , Properties.Settings.Default.DomainDefault);
            ErrorTextBox.Text = err;
        }

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            AccountManagement.DeleteUser(LoginUserDeleteTextBox.Text);
            
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteYserPanel.Visible = true;
            CreateUserPanel.Visible = false;
        }

        private void SrechButton_Click(object sender, EventArgs e)
        {
           //WorkWithAD.ValidateController();
            if (WorkWithAD.ValidateController())
            {
                SerchErrTextBox.Text = "Server connected";
            } else
            {
                SerchErrTextBox.Text = "Fuck U!!!!!!!!!!!!!!!!!!!";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           var res =  searchMetods.GetUser(textBox2.Text);
          
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
