using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;

namespace UnlockUser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string sDomain = "***";
        //private string sDefaultOU = "OU=users,OU=system";
        //private string sDefaultRootOU = "DC=test,DC=com";
        private string sServiceUser;
        private string sServicePassword;

        private void Unlock_Click(object sender, EventArgs e)
        {
            sServiceUser = userName.Text;
            sServicePassword = password.Text;
            UnlockUser(user.Text);
        }

        public void UnlockUser(string userDn)
        {
            try
            {
                UserPrincipal oUserPrincipal = GetUser(userDn);
                oUserPrincipal.UnlockAccount();
                oUserPrincipal.Save();

                //DirectoryEntry uEntry = new DirectoryEntry(userDn);
                //uEntry.Properties["LockOutTime"].Value = 0; //unlock account
                ////uEntry.Properties["userAccountControl"].Value = m_Val | 0x0001

                //uEntry.CommitChanges(); //may not be needed but adding it anyways

                //uEntry.Close();
            }
            catch (System.DirectoryServices.DirectoryServicesCOMException E)
            {
                //DoSomethingWith --> E.Message.ToString();
                MessageBox.Show(E.ToString());
            }
        }

        public UserPrincipal GetUser(string sUserName)
        {
            PrincipalContext oPrincipalContext = GetPrincipalContext();

            UserPrincipal oUserPrincipal = UserPrincipal.FindByIdentity(oPrincipalContext, sUserName);
            return oUserPrincipal;
        }

        public PrincipalContext GetPrincipalContext()
        {
            //PrincipalContext oPrincipalContext = new PrincipalContext(ContextType.Domain, sDomain, sDefaultOU, ContextOptions.SimpleBind, sServiceUser, sServicePassword);
            PrincipalContext oPrincipalContext = new PrincipalContext(ContextType.Domain, sDomain, sServiceUser, sServicePassword);
            return oPrincipalContext;
        }

    }
}
