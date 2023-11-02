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
    public partial class FRM_FindPerson : Form
    {
        public delegate void DataBackEventHandler (object sender, int PersonInfo);
        public event DataBackEventHandler DataBack;
        public FRM_FindPerson()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            if(uC_PersoneInfo1.IsNotEmpty()) DataBack?.Invoke(this,this.uC_PersoneInfo1.PersonId);
            this.Close();
        }
        bool Validation()
        {
            if (txtShearchPerson.Text==""||comboSearch.Text == "") return false;
            return true;
        }
        private void btnShearch_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                if (comboSearch.SelectedIndex == 0)
                {
                    int idPerson;
                    if (int.TryParse(txtShearchPerson.Text, out idPerson))
                    {
                        uC_PersoneInfo1.LoadPersonInfo(idPerson);
                    }
                    else MessageBox.Show("enter An integer Number for Id ! ");
                }
                else if(comboSearch.SelectedIndex == 1)
                {
                    string NationalNa=txtShearchPerson.Text;
                    uC_PersoneInfo1.LoadPersonInfo(NationalNa);
                }
            }
            else
            {
                MessageBox.Show("Select Type Find Or Fill Text Box ");
            }
        }

        private void btnAddNewPersone_Click(object sender, EventArgs e)
        {
            FRM_AddNewPerson fRM_AddNewPerson = new FRM_AddNewPerson();
            fRM_AddNewPerson.ShowDialog();
        }
    }
}