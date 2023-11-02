using DVLD_BusinessLayer;
using Guna.UI2.WinForms;
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
    public partial class UC_ApplicationRecord : UserControl
    {
        int Normalheight = 0;
        DataRow _ApplicationRecord;
        int _RecordID;
        LocalDrivingLicenseApplication _localDrivingLicenseApplication;
        public UC_ApplicationRecord(DataRow applicationRecord)
        {
            InitializeComponent();
            _ApplicationRecord = applicationRecord;
            _RecordID = Convert.ToInt16(_ApplicationRecord["LocalDrivingLicenseApplicationID"]);
            _localDrivingLicenseApplication = LocalDrivingLicenseApplication.Find(_RecordID);
            Normalheight = this.pnlSection.Height + this.pnlApplicationRecordInfo.Height;
        }
        void _UpDown()
        {
            this.pnlSection.Visible=!this.pnlSection.Visible;
            if(this.pnlSection.Visible)
            {
                this.Height = Normalheight;
            }
            else this.Height = this.pnlApplicationRecordInfo.Height;
        }
        void ScheduleTestAppointment()
        {
            bool IsHaveVesionTest = _localDrivingLicenseApplication.DoesLocalDrivingLicenseAppHaveTestType((int)Test.enTestsType.VesionTest);
            bool IsHaveWrittenTest = _localDrivingLicenseApplication.DoesLocalDrivingLicenseAppHaveTestType((int)Test.enTestsType.WrittenTest);
            bool IsHaveStretTest = _localDrivingLicenseApplication.DoesLocalDrivingLicenseAppHaveTestType((int)Test.enTestsType.StretTest);
            if (IsHaveVesionTest)
            {
                pnlScheduleVesionTest.Enabled=false;
                pnlScheduleVesionTest.BorderStyle=BorderStyle.None;
            }
            if (IsHaveWrittenTest || !IsHaveVesionTest)
            {
                pnlScheduleWrittenTest.Enabled = false;
                pnlScheduleWrittenTest.BorderStyle = BorderStyle.None;
            }
            if (IsHaveStretTest || !IsHaveWrittenTest)
            {
                pnlScheduleStretTest.Enabled = false;
                pnlScheduleStretTest.BorderStyle = BorderStyle.None;

            }
        }
        private void btnUpDown_Click(object sender, EventArgs e)
        {
            ScheduleTestAppointment();
            UC_ManageLocalDrivingLicenseApplications.Intance._UpBar(this);
            _UpDown();
            GeneratePermessions();
        }
        void UnEnabledButton(Guna2Button button)
        {
            button.Enabled=false;
        }
        void EnabledButton(Guna2Button button)
        {
            button.Enabled=true;
        }
        bool CheckPassedTests()
        {
            int countPassedTests = _localDrivingLicenseApplication.TestsPassed();
            if(countPassedTests < 3) 
            {
                return false;
            }
            return true;
        }
        void GeneratePermessions()
        {
            if (IsApplicationCompleted())
            {
                UnEnabledButton(btnCancelApp);
                UnEnabledButton(btnDeleteApp);
                UnEnabledButton(btnUpdateApp);
            }
            if (!CheckPassedTests())
            {
                UnEnabledButton(btnIssueDrivingLicense);
                UnEnabledButton(btnShowLicense);

            }
            else EnabledButton(btnIssueDrivingLicense);
        }
        void _FillApplicationInfo()
        {
            this.lblID.Text = _ApplicationRecord["LocalDrivingLicenseApplicationID"].ToString();
            this.lblClassName.Text = _ApplicationRecord["ClassName"].ToString();
            this.lblNationalNo.Text = _ApplicationRecord["NationalNo"].ToString();
            this.lblFullName.Text = _ApplicationRecord["FullName"].ToString();
            this.lblDate.Text = _ApplicationRecord["ApplicationDate"].ToString();
            this.lblPassedTests.Text = _ApplicationRecord["PassedTests"].ToString();
            this.lblAppstate.Text = _ApplicationRecord["ApplicationState"].ToString();
        }
        public bool Hidden()
        {
            return this.pnlSection.Visible==false;
        }
        public void UpBar()
        {
            this.pnlSection.Visible=false;
            this.Height= this.pnlApplicationRecordInfo.Height;
        }
         void DownBar()
        {
            this.pnlSection.Visible = true;
            this.Height = Normalheight;
        }
        bool IsApplicationCompleted()
        {
            return (Applicationn.Find(_localDrivingLicenseApplication.ApplicationId).State == Applicationn.enApplicationState.Completed);
        }
        private void UC_ApplicationRecord_Load(object sender, EventArgs e)
        {
            UpBar();
            this.pnlScheduleWrittenTest.Enabled=false;
            this.pnlScheduleStretTest.Enabled=false;

            _FillApplicationInfo();
        }
        private void btnShowAppInfo_Click(object sender, EventArgs e)
        {

        }
        private void btnUpdateApp_Click(object sender, EventArgs e)
        {

        }
        private void btnDeleteApp_Click(object sender, EventArgs e)
        {

        }
        private void btnCancelApp_Click(object sender, EventArgs e)
        {

        }
        private void btnShowLicense_Click(object sender, EventArgs e)
        {

        }
        private void btnShowPersonLicensesHistory_Click(object sender, EventArgs e)
        {

        }
        private void btnIssueDrivingLicense_Click(object sender, EventArgs e)
        {

        }

        //Thes Buttons For Tests Appointments
        private void btnAppointment_VestionTest_Click(object sender, EventArgs e)
        {

        }
    }
}