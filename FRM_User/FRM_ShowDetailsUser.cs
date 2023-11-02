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

namespace DVLD_Projet.FRM_User
{
    public partial class FRM_ShowDetailsUser : Form
    {
        User _user;
        int _UserId;
        public FRM_ShowDetailsUser(int userId)
        {
            InitializeComponent();
            _UserId = userId;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FRM_ShowDetailsUser_Load(object sender, EventArgs e)
        {
            _user = User.Find(_UserId);
            uC_PersoneInfo1.LoadPersonInfo(_user.IdPersone1);
            lblIdUser.Text = _user.Id1.ToString();
            lblUserName.Text = _user.UserName1;
            lblIsActive.Text = (_user.IsActive1) ? "yes" : "No";
        }
    }
}
