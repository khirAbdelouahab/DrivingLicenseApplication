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
using DVLD_Projet.FRM_Person;
using DVLD_Projet.FRM_User;
using DVLD_Projet.FRMS_Application;

namespace DVLD_Projet
{
    public partial class DrinvingLicenseManagement : Form
    {
        public DrinvingLicenseManagement()
        {
            InitializeComponent();
        }
        void SidePanel(Panel ActivePanel)
        {
            ActivePanel.Visible = !ActivePanel.Visible;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.SelectedTab = HomePage;
            lblNameUserLogin.Text = UserAccount._User.UserName1;
            ImageUserLogin.Image =Image.FromFile(Persone.Find(UserAccount._User.IdPersone1).ImagePath1);
        }
        private void btnListApplications_Click(object sender, EventArgs e)
        {

        }
        private void btnApplications_Click(object sender, EventArgs e)
        {
            SidePanel(ApplicationsPanel);
        }
        private void btnDrivingLicenseServices_Click(object sender, EventArgs e)
        {
            SidePanel(DrivingLicensePanel);
        }
        private void btnNewDrivingLicense_Click(object sender, EventArgs e)
        {
            SidePanel(NewDrivingLicensePanel);
        }
        private void btnUsers_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = ManageUsersPage;
            GridView_Users.DataSource = User.Users();
        }
        private void btnPeople_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = PeoplePage;
            GridView_People.DataSource = Persone.People();
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //=============================================================================

        private void btnFindPersone_Click(object sender, EventArgs e)
        {
            FRM_FindPerson fRM_FindPerson = new FRM_FindPerson();
            fRM_FindPerson.ShowDialog();
        }
        private void btnAddNewPersone_Click(object sender, EventArgs e)
        {
            FRM_AddNewPerson Form = new FRM_AddNewPerson();
            Form.ShowDialog();
            GridView_People.DataSource = Persone.People();
        }
        private void btnDetailsPersone_Click(object sender, EventArgs e)
        {
            int IdPersone = Convert.ToInt16(GridView_People.SelectedRows[0].Cells[0].Value);
            MessageBox.Show(IdPersone.ToString());
            FRM_ShowDetailsPersone showDetails = new FRM_ShowDetailsPersone(IdPersone);
            showDetails.ShowDialog();
        }
        private void btnEditPersone_Click(object sender, EventArgs e)
        {
            int IdPersone = Convert.ToInt16(GridView_People.SelectedRows[0].Cells[0].Value);
            FRM_UpdatePersone Form = new FRM_UpdatePersone(IdPersone);
            Form.ShowDialog();
            GridView_People.DataSource = Persone.People();
        }
        private void btnDeletePersone_Click(object sender, EventArgs e)
        {
            int idPerson =Convert.ToInt16(GridView_People.SelectedRows[0].Cells[0].Value);
            bool IsDeleted= Persone.Delete(idPerson);
            if(IsDeleted)
            {
                MessageBox.Show("Persone with Id " + idPerson + " Has Deleted Succesfuly ");
                GridView_People.DataSource= Persone.People();
                return;
            }
            else
            {
                MessageBox.Show("Error ! you can not delete this  Persone with Id " + idPerson.ToString());
                return;
            }
        }
        // Manage Users  ======================================================
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            FRM_AddNewUser fRM_AddNewUser = new FRM_AddNewUser();
            fRM_AddNewUser.ShowDialog();
            GridView_Users.DataSource = User.Users();
        }
        private void btnUserDetails_Click(object sender, EventArgs e)
        {
            int UserId =Convert.ToInt16(GridView_Users.SelectedRows[0].Cells[0].Value);
            FRM_ShowDetailsUser fRM_ShowDetailsUser = new FRM_ShowDetailsUser(UserId);
            fRM_ShowDetailsUser.ShowDialog();
        }
        private void btnUserUpdate_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt16(GridView_Users.SelectedRows[0].Cells[0].Value);
            FRM_UpdateUser fRM_UpdateUser= new FRM_UpdateUser(userId);
            fRM_UpdateUser.ShowDialog();
            GridView_Users.DataSource = User.Users();
        }
        private void btnUnActiveAccount_Click(object sender, EventArgs e)
        {
            int UserId = Convert.ToInt16(GridView_Users.SelectedRows[0].Cells[0].Value);
            if (User.Find(UserId).FrezeAcount()) MessageBox.Show("User with Id =" + UserId.ToString() + " Is UnActivated Succesfuly");
            else MessageBox.Show("User with Id =" + UserId.ToString() + " Is Already has UnActivated Account !");
            GridView_Users.DataSource = User.Users();
        }

        private void btnLocaleLicense_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = NewLocalDrivingLicenseApplication_Page;
            UC_AddNewDrivingApplication uC_AddNewDrivingApplication= new UC_AddNewDrivingApplication();
            NewLocalDrivingLicenseApplication_Page.Controls.Add(uC_AddNewDrivingApplication);
            uC_AddNewDrivingApplication.Dock = DockStyle.Fill;
            uC_AddNewDrivingApplication.Show();
        }

        private void btnManageApplicationTypes_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = ManageLocalApplication_Page;
            if (ManageLocalApplication_Page.Controls.Count > 0) ManageLocalApplication_Page.Controls.Clear();
            UC_ManageLocalDrivingLicenseApplications uC_ = new UC_ManageLocalDrivingLicenseApplications();
            this.ManageLocalApplication_Page.Controls.Add(uC_);
            uC_.Dock = DockStyle.Fill;
            uC_.Show();
        }
    }
}