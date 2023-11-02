using DVLD_BusinessLayer;
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
    public partial class UC_ManageLocalDrivingLicenseApplications : UserControl
    {
        private static UC_ManageLocalDrivingLicenseApplications _obj;
        public static UC_ManageLocalDrivingLicenseApplications Intance
        {
            get
            {
                if(_obj == null) return new UC_ManageLocalDrivingLicenseApplications();
                return _obj;
            }
        }
        DataTable _LocalDrivingLicenseAppInfo;
        void _LoadApplicationsInfoToFLP()
        {
            if (_LocalDrivingLicenseAppInfo == null) return;
            if (this.FLP_ApplicationInfo.Controls.Count > 0) this.FLP_ApplicationInfo.Controls.Clear();
            foreach (DataRow row in _LocalDrivingLicenseAppInfo.Rows)
            {
                UC_ApplicationRecord appRecord = new UC_ApplicationRecord(row);
                this.FLP_ApplicationInfo.Controls.Add(appRecord);
            }
        }
        public void _UpBar(UC_ApplicationRecord application)
        {
            foreach (Control control in this.FLP_ApplicationInfo.Controls)
            {
                UC_ApplicationRecord applicationRecord=(UC_ApplicationRecord)control;
                if (!applicationRecord.Hidden() && applicationRecord!=application)
                {
                    applicationRecord.UpBar();
                }
            }
        }
        public UC_ManageLocalDrivingLicenseApplications()
        {

            InitializeComponent();
            _obj=this;
            _LocalDrivingLicenseAppInfo = LocalDrivingLicenseApplication.GetAll_DVLDApplications();
        }
        private void UC_ManageLocalDrivingLicenseApplications_Load(object sender, EventArgs e)
        {
            _LoadApplicationsInfoToFLP();
        }
    }
}
