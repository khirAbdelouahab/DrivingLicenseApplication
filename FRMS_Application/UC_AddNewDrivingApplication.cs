using DVLD_BusinessLayer;
using DVLD_Projet.Authentification;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Projet.FRMS_Application
{
    public partial class UC_AddNewDrivingApplication : UserControl
    {
        private Applicationn application;
        public UC_AddNewDrivingApplication()
        {
            InitializeComponent();
            application = new Applicationn();
        }
        void Load_LicenseClasses()
        {
            DataTable LicenseClasses = new DataTable();
            LicenseClasses = LicenseClass.LicenseClasses();
            cbLicenseClasses.DataSource = LicenseClasses;
            cbLicenseClasses.ValueMember = LicenseClasses.Columns[0] + "";
            cbLicenseClasses.DisplayMember = LicenseClasses.Columns[1] + "";
        }
        private void UC_AddNewDrivingApplication_Load(object sender, EventArgs e)
        {
            Load_LicenseClasses();
            pnlApplication_Container.Enabled = false;
            cbFindBy.SelectedIndex = 0;
        }
        private void btnFindPerson_Click(object sender, EventArgs e)
        {
            if (txtFindPerson.Text == "")
            {
                MessageBox.Show("Error ! Enter an Id or National Na");
                return;
            }
            if (cbFindBy.SelectedIndex == 0)
            {
                int idPerson;
                if (int.TryParse(txtFindPerson.Text, out int id)) { idPerson = id; }
                else { MessageBox.Show("Error Enter A valid Id "); return; }
                uC_PersoneInfo1.LoadPersonInfo(idPerson);
            }
            else
            {
                uC_PersoneInfo1.LoadPersonInfo(txtFindPerson.Text);
            }
            if (uC_PersoneInfo1.PersonId != -1) pnlApplication_Container.Enabled = true;
            _FillApplicationInfo();
        }
        private void _FillApplicationInfo()
        {
            application.ApplicantPersoneId = uC_PersoneInfo1.PersonId;
            application.ApplicationTypeId = 1;
            application.CreatedByUserId = UserAccount._User.Id1;
            lblApplicationId.Text = "[???]";
            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            lblApplicationFees.Text = ApplicationType.Find(1).Fees.ToString() + "$";
            lblCreatedBy.Text = UserAccount._User.UserName1;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            int LicenseclassId = Convert.ToUInt16(cbLicenseClasses.SelectedValue);
            LocalDrivingLicenseApplication localDrivingLicenseApplication = new LocalDrivingLicenseApplication(application, LicenseclassId);
            if (localDrivingLicenseApplication.DoesPersonHaveActiveApplication())
            {
                MessageBox.Show("Persone with id = " + application.ApplicantPersoneId.ToString() + " Already Have an Activate Application for this Class");
                return;
            }
            if (LicenseClass.DoesPersonHaveLicenseClass(application.ApplicantPersoneId, LicenseclassId))
            {
                MessageBox.Show("Persone with id = " + application.ApplicantPersoneId.ToString() + " Already Have an Activate License for The Same  Class");
                return;
            }
            application.Save();
            localDrivingLicenseApplication.ApplicationId = application.Id;
            if (localDrivingLicenseApplication.Save())
            {
                lblApplicationId.Text = localDrivingLicenseApplication.Id.ToString();
                MessageBox.Show("Data Saved Succesfuly ");
            }

        }
    }
}