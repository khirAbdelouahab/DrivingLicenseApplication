using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Projet.FRM_Person
{
    public partial class FRM_ShowDetailsPersone : Form
    {
        int _IdPersone;
        public FRM_ShowDetailsPersone(int idPersone)
        {
            InitializeComponent();
            _IdPersone = idPersone;
        }
        private void FRM_ShowDetailsPersone_Load(object sender, EventArgs e)
        {
            uC_PersoneInfo1.LoadPersonInfo(_IdPersone);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}