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

namespace DVLD_Projet
{
    public partial class UC_PersoneInfo : UserControl
    {
        private Persone _persone;
        private int IdPerson=-1;
        public bool IsNotEmpty()
        {
            return _persone != null;
        }
        public int PersonId
        {
            get {
                if(_persone == null) return -1;
                return _persone.ID1; 
            }
        }
        private void _FillPersonInfo()
        {
            this.lblId.Text = _persone.ID1.ToString();
            this.lblCin.Text = _persone.CIN1;
            this.lblName.Text = _persone.FirstName1 + " " + _persone.SecondName1 + " " + _persone.LastName1;
            this.lblDateOfBirth.Text=_persone.DateOfBirth1.ToString();
            this.lblEmail.Text = _persone.Email1;
            this.lblGendor.Text = _persone.Gendor1.ToString();
            this.lblPhone.Text = _persone.Phone1;
            this.lblCountry.Text = _persone.CountryName();
            this.lblAdress.Text = _persone.Adress1;
            if(_persone.ImagePath1 == "")
            {
                if(!_persone.Gendor1) this.ImagePerson.Image = Image.FromFile("C:\\Users\\KHIRI\\source\\repos\\DVLD_Projet\\Images\\Male.png");
                else this.ImagePerson.Image = Image.FromFile("C:\\Users\\KHIRI\\source\\repos\\DVLD_Projet\\Images\\Female.png");
            }
            else this.ImagePerson.Image = Image.FromFile(_persone.ImagePath1);
        }
        private void _ResetPersonInfo()
        {
            this.lblId.Text = "[???????]";
             this.lblCin.Text = "[???????]";
            this.lblName.Text = "[???????]";
            this.lblDateOfBirth.Text= "[???????]";
            this.lblEmail.Text = "[???????]";
            this.lblGendor.Text = "[???????]";
            this.lblPhone.Text = "[???????]";
            this.lblCountry.Text = "[???????]";
            this.lblAdress.Text = "[???????]";
            this.ImagePerson.Image = null;
        }
        public void LoadPersonInfo(int personeId)
        {
            _persone = Persone.Find(personeId);
            if (_persone == null)
            {
                _ResetPersonInfo();
                MessageBox.Show("Persone with Id " + IdPerson.ToString()+" Is Not Found");
                return;
            }
            else
            {
                _FillPersonInfo();
            }
        }
        public void LoadPersonInfo(string NationalNa)
        {
            _persone = Persone.Find(NationalNa);
            if (_persone == null)
            {
                _ResetPersonInfo();
                MessageBox.Show("Persone with National Na " + NationalNa + " Is Not Found");
                return;
            }
            else
            {
                _FillPersonInfo();
            }
        }
        public UC_PersoneInfo()
        {
            InitializeComponent();
        }
        private void UC_PersoneInfo_Load(object sender, EventArgs e)
        {
            _ResetPersonInfo();
        }
    }
}
