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
    public partial class FRM_UpdateUser : Form
    {
        int _userId;
        User _user;
        public FRM_UpdateUser(int UserId)
        {
            InitializeComponent();
            _userId = UserId;
            _user = User.Find(UserId);
        }
        private void btnSelectPersone_Click(object sender, EventArgs e)
        {
            FRM_FindPerson fRM_FindPerson = new FRM_FindPerson();
            fRM_FindPerson.DataBack += FRM_FindPerson_DataBack;
            fRM_FindPerson.ShowDialog();
        }
        private void FRM_FindPerson_DataBack(object sender, int PersonId)
        {
            uC_PersoneInfo1.LoadPersonInfo(PersonId);
        }
        private void btnUpdatePerson_Click(object sender, EventArgs e)
        {
            FRM_UpdatePersone fRM_UpdatePersone = new FRM_UpdatePersone(_user.IdPersone1);
            fRM_UpdatePersone.ShowDialog();
            this.uC_PersoneInfo1.LoadPersonInfo(_user.IdPersone1);
        }
        bool Validation()
        {
            if(txtUserName.Text=="" || txtPassword1.Text==""||txtPassword2.Text=="") return false;
            if(txtPassword1.Text!=txtPassword2.Text) return false;
            return true;
        }
        private void FRM_UpdateUser_Load(object sender, EventArgs e)
        {
            this.uC_PersoneInfo1.LoadPersonInfo(_user.IdPersone1);
            this.lblId.Text = _user.Id1.ToString();
            this.txtUserName.Text = _user.UserName1;
            this.txtPassword1.Text = _user.Password1;
            this.txtPassword2.Text = _user.Password1;
            this.checkIsActive.Checked = _user.IsActive1;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                if(_user.Update(uC_PersoneInfo1.PersonId,txtUserName.Text,txtPassword1.Text,checkIsActive.Checked))
                {
                    MessageBox.Show("User with Id " + _user.Id1 + " Is Updated Succesfuly");
                }
                else MessageBox.Show("Persone with Id " + uC_PersoneInfo1.PersonId + " Is already connect with another User !\nselect anotherparson");
            }
            else MessageBox.Show("some Fields or Password Is not valid");
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = Tab_LogInUser;
        }
    }
}