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
    public partial class FRM_UpdatePersone : Form
    {
        Persone _persone;
        int _IdPersn;
        private bool CheckFields()
        {
            if (txtCin.Text == "" || txtEmail.Text == "" || txtFirstName.Text == "" || txtSecondName.Text == "" || txtThirdName.Text == "" || txtLastName.Text == ""
                || txtPhone.Text == "" || txtAdress.Text == "") return false;
            if (!RadioMale.Checked && !RadioFemale.Checked) return false;
            return true;
        }
        public FRM_UpdatePersone(int idpersn)
        {
            InitializeComponent();
            _persone = Persone.Find(idpersn);
        }
        private void UpdatePersone()
        {
            _persone.Adress1 = txtAdress.Text;
            _persone.CIN1 = txtCin.Text;
            _persone.Email1 = txtEmail.Text;
            _persone.DateOfBirth1 = PickerDateOfBirth.Value;
            _persone.FirstName1 = txtFirstName.Text;
            _persone.SecondName1 = txtSecondName.Text;
            _persone.ThirdName1 = txtThirdName.Text;
            _persone.LastName1 = txtLastName.Text;
            _persone.Nationality1 = Convert.ToInt16(ComboCountries.SelectedValue);
            _persone.Phone1 = txtPhone.Text;
            _persone.Gendor1 = RadioMale.Checked ? false : true;
            if (openFileDialog1.FileName != "openFileDialog1") _persone.ImagePath1 = openFileDialog1.FileName;
            else
            {
                _persone.LoadImage();
            }
        }
        private void LoadPersoneInfoFields()
        {
            lblIdPersone.Text = _persone.ID1.ToString();
            txtAdress.Text = _persone.Adress1;
            txtCin.Text = _persone.CIN1;
            txtEmail.Text = _persone.Email1;
            PickerDateOfBirth.Value = _persone.DateOfBirth1;
            txtFirstName.Text = _persone.FirstName1;
            txtSecondName.Text = _persone.SecondName1;
            txtThirdName.Text = _persone.ThirdName1;
            txtLastName.Text = _persone.LastName1;
            ComboCountries.SelectedValue = _persone.Nationality1;
            txtPhone.Text = _persone.Phone1;
            if (_persone.Gendor1) this.RadioFemale.Checked=true;
            else this.RadioMale.Checked = true;
            ImagePersone.Image=Image.FromFile(_persone.ImagePath1);
            ImagePersone.ImageLocation = _persone.ImagePath1;
            //openFileDialog1.FileName = _persone.ImagePath1;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckFields())
            {
                MessageBox.Show("Some Field Is Empty");
                return;
            }
            bool IsPersoneUpdated= _persone.Update(txtCin.Text, txtFirstName.Text, txtSecondName.Text, txtThirdName.Text, txtLastName.Text, PickerDateOfBirth.Value,
                RadioFemale.Checked, txtAdress.Text, txtPhone.Text,txtEmail.Text,Convert.ToInt16(ComboCountries.SelectedValue), ImagePersone.ImageLocation);
            if (IsPersoneUpdated) MessageBox.Show("Persone Has Updated Succesfuly");
            else MessageBox.Show("Persone With National Na " + _persone.CIN1 + " Is Already In System !\n Try Another (National Na)");
        }
        private void LoadCountries()
        {
            DataTable dt_Countries = Country.Countries();
            this.ComboCountries.DataSource = dt_Countries;
            this.ComboCountries.ValueMember = dt_Countries.Columns["CountryID"] + "";
            this.ComboCountries.DisplayMember = dt_Countries.Columns["CountryName"] + "";
        }
        private void FRM_UpdatePersone_Load(object sender, EventArgs e)
        {
            LoadCountries();
            LoadPersoneInfoFields();
        }
        private void linkLabel1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ImagePersone.Image = Image.FromFile(openFileDialog1.FileName);
                ImagePersone.ImageLocation=openFileDialog1.FileName;
            }
        }
        private void RadioMale_Click(object sender, EventArgs e)
        {
            string ImagePath = "C:\\Users\\KHIRI\\source\\repos\\DVLD_Projet\\Images\\Male.png";
            ImagePersone.Image = Image.FromFile(ImagePath);
            ImagePersone.ImageLocation = ImagePath;
        }
        private void RadioFemale_Click(object sender, EventArgs e)
        {
            string ImagePath = "C:\\Users\\KHIRI\\source\\repos\\DVLD_Projet\\Images\\Female.png";
            ImagePersone.Image = Image.FromFile(ImagePath);
            ImagePersone.ImageLocation = ImagePath;
        }
    }
}