using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_BusinessLayer;
namespace DVLD_Projet.Authentification
{
    public  class UserAccount
    {
        public static User _User;
        public static bool Login(string username, string password)
        {
            _User=User.Login(username, password);
            return _User!=null;
        }
    }
}
