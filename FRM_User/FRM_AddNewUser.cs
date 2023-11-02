using DVLD_BusinessLayer;
using DVLD_Projet.FRM_Person;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Projet.FRM_User
{
    public partial class FRM_AddNewUser : Form
    {
        public FRM_AddNewUser()
        {
            InitializeComponent();
        }
        private void btnSelectPerson_Click(object sender, EventArgs e)
        {
            FRM_FindPerson fRM_FindPerson = new FRM_FindPerson();
            fRM_FindPerson.DataBack += this.FRM_AddNewUser_DataBack;
            fRM_FindPerson.ShowDialog();
        }
        private void FRM_AddNewUser_DataBack(object sender, int IdPerson) 
        {
            this.uC_PersoneInfo1.LoadPersonInfo(IdPerson);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool Validation()
        {
            if(txtUserName.Text==""||txtPassword1.Text==""||txtPassword2.Text==""||!uC_PersoneInfo1.IsNotEmpty())
            {
                return false;
            }
            else if(txtPassword1.Text!=txtPassword2.Text)
            {
                return false;
            }
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                User user = new User(uC_PersoneInfo1.PersonId, txtUserName.Text, txtPassword1.Text, CheckActive.Checked);
                Persone persone = Persone.Find(uC_PersoneInfo1.PersonId);
                if (persone.IsConnectWithUser())
                {
                    MessageBox.Show("Persone with Id "+persone.ID1+" Is Already Connect with Another User ! \nSelect Another Persone .");
                    return;
                }
                if (user.Add()) 
                {
                    MessageBox.Show("User Is Added Succesfuly");
                    return;
                }
                else
                {
                    MessageBox.Show("User with UserName= "+user.UserName1+" IsAlready Used !");
                    return;
                }
            }
            else MessageBox.Show("Error Some Field Is Empty !");
        }
    }
}