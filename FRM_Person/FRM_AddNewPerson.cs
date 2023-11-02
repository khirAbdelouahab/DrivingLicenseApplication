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

namespace DVLD_Projet.FRM_Person
{
    public partial class FRM_AddNewPerson : Form
    {
        public FRM_AddNewPerson()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool CheckFields()
        {
            if(txtCin.Text=="" ||txtEmail.Text==""||txtFirstName.Text==""||txtSecondName.Text==""||txtThirdName.Text=="" || txtLastName.Text==""
                ||txtPhone.Text==""|| txtAdress.Text=="") return false;
            if (!RadioMale.Checked && !RadioFemale.Checked) return false;
            return true;
        }
        private void CreatePersone(ref Persone persone)
        {
            persone = new Persone();
            persone.Adress1 = txtAdress.Text;
            persone.CIN1 = txtCin.Text;
            persone.Email1 = txtEmail.Text;
            persone.DateOfBirth1 = PickerDateOfBirth.Value;
            persone.FirstName1 = txtFirstName.Text;
            persone.SecondName1 = txtSecondName.Text;
            persone.ThirdName1 = txtThirdName.Text;
            persone.LastName1 = txtLastName.Text;
            persone.Nationality1 =Convert.ToInt16(ComboCountries.SelectedValue);
            persone.Phone1 = txtPhone.Text;
            persone.Gendor1=RadioMale.Checked ? false:true;
            if (openFileDialog1.FileName != "openFileDialog1") persone.ImagePath1 = openFileDialog1.FileName;
            else
            {
                persone.LoadImage();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckFields())
            {
                MessageBox.Show("Some Field Is Empty");
                return;
            }
            Persone _Persone=null;
            CreatePersone(ref _Persone);
            if (_Persone.Add())
            {
                MessageBox.Show("This Persone Has Added Succesfuly");
                return;
            }
            else
            {
                MessageBox.Show("Persone with National Na = "+_Persone.CIN1+" Is Already In System !");
                return;
            } 
        }
        private void linkLabel1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ImagePersone.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
        private void RadioMale_Click(object sender, EventArgs e)
        {
            ImagePersone.Image = Image.FromFile("C:\\Users\\KHIRI\\source\\repos\\DVLD_Projet\\Images\\Male.png");
        }
        private void RadioFemale_Click(object sender, EventArgs e)
        {
            ImagePersone.Image =Image.FromFile("C:\\Users\\KHIRI\\source\\repos\\DVLD_Projet\\Images\\Female.png");
        }
        private void FRM_AddNewPerson_Load(object sender, EventArgs e)
        {
            DataTable dt_Countries = Country.Countries();
            this.ComboCountries.DataSource=dt_Countries;
            this.ComboCountries.ValueMember = dt_Countries.Columns["CountryID"] + "";
            this.ComboCountries.DisplayMember = dt_Countries.Columns["CountryName"] + "";
        }
    }
}