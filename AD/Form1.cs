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
using System.Collections;

namespace AD
{
    public partial class Form1 : Form
    {
        string sDomain;
        public Form1()
        {
            InitializeComponent();

            sDomain = Properties.Settings.Default.Domain;

            HelperMetods.sDomain = Properties.Settings.Default.Domain;
            HelperMetods.sDomainDefault = Properties.Settings.Default.DomainDefault;
            HelperMetods.sServiceUser = Properties.Settings.Default.ServiceUser;
            HelperMetods.sServicePassword = Properties.Settings.Default.ServicePassword;
            HelperMetods.sDefaultRootOU = String.Format(@"DC={0},DC={1}", Properties.Settings.Default.RootDom, Properties.Settings.Default.RootDNS);

            AccountManagement.sDomain = Properties.Settings.Default.Domain;
            AccountManagement.sDomainDefault = Properties.Settings.Default.DomainDefault;
            AccountManagement.sServiceUser = Properties.Settings.Default.ServiceUser;
            AccountManagement.sServicePassword = Properties.Settings.Default.ServicePassword;
            AccountManagement.sDefaultRootOU = String.Format(@"DC={0},DC={1}", Properties.Settings.Default.RootDom, Properties.Settings.Default.RootDNS);
            AccountManagement.sRootDom = Properties.Settings.Default.RootDom;
            AccountManagement.sRootDNS = Properties.Settings.Default.RootDNS;

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
            //getUsers();
            //GetAllUsers();
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


        private void CreateUserButton_Click(object sender, EventArgs e)
        {
            UserProperty userProp = new UserProperty();
            userProp.sn = SecondNameTextBox.Text;
            userProp.name = String.Format(@"{0} {1}", NameTextBox.Text, SecondNameTextBox.Text);
            userProp.cn = String.Format(@"{0} {1}", NameTextBox.Text, SecondNameTextBox.Text);
            userProp.givenname = NameTextBox.Text;
            userProp.displayname = String.Format(@"{0} {1}", NameTextBox.Text, SecondNameTextBox.Text);
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

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            FullNameTextBox.Text = string.Format("{0} {1}", NameTextBox.Text, SecondNameTextBox.Text);
        }

        private void SecondNameTextBox_TextChanged(object sender, EventArgs e)
        {
            FullNameTextBox.Text = string.Format("{0} {1}", NameTextBox.Text, SecondNameTextBox.Text);
        }


        private void SetPasswordButton_Click(object sender, EventArgs e)
        {
            string err;
            AccountManagement.SetUserPassword(LoginUserTextBox.Text,NewPasTexBox.Text,out err);
            MessageBox.Show(err);
        }

        private void DisableButtom_Click(object sender, EventArgs e)
        {
            AccountManagement.DisableUserAccount(LoginDisableTextBox.Text);
            
        }

        private void EnableButton_Click(object sender, EventArgs e)
        {
            AccountManagement.EnableUserAccount(LoginDisableTextBox.Text);
        }

        public void getUsers()
        {
            if (Properties.Settings.Default.Domain == null || Properties.Settings.Default.Domain == "")
                return;
            else
            {
                using (var context = new PrincipalContext(ContextType.Domain, Properties.Settings.Default.Domain))
                {
                    using (var searcher = new PrincipalSearcher(new UserPrincipal(context)))
                    {
                        foreach (var result in searcher.FindAll())
                        {
                            DirectoryEntry de = result.GetUnderlyingObject() as DirectoryEntry;
                            var enable = de.Properties["userAccountControl"].Value;
                            if (enable.ToString() == "512" || enable.ToString() == "544" || enable.ToString() == "66048" || enable.ToString() == "66080")
                            {
                                dataGridView1.Rows.Add(de.Properties["displayName"].Value, de.Properties["samAccountName"].Value);
                            }
                        }
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            getUsers();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dataGridView1.ContextMenuStrip = contextMenuStrip1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WorkWithAD.CreateNewOU("NewOU FOR TEst");
        }

        private void ReloadtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            getUsers();
        }
    }
 }

