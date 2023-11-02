using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_BusinessLayer;
using DVLD_Projet.Authentification;

namespace DVLD_Projet
{
    public partial class FRM_LoginPage : Form
    {
        public FRM_LoginPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool IsLogged;
            IsLogged = UserAccount.Login(txtUserName.Text, txtPassword.Text);
            if (IsLogged)
            {
                DrinvingLicenseManagement drinvingLicenseManagement = new DrinvingLicenseManagement();
                drinvingLicenseManagement.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error ! UserName Or Password Is UnCorrect ! \nTry Again");
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
