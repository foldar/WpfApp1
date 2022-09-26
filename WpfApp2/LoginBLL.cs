using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    internal class LoginBLL
    {
        private int? _TestNumber;
        private string _UserName="";
        private string _pwdHashed="";

        public int? TestNumber
        {
            get => _TestNumber;
            set
            {
                if ((value > 0) && (value < 13))
                {
                    _TestNumber = value;
                }
            }
        }
 
        public string UserName
        {
            get => _UserName;
            set
            {
                if (value != "a")
                    _UserName = value;
            }
        }

        public string password
        {
            set
            {
                if (value != "a")
                {
                    string salt = SecurityHelper.GenerateSalt(70);
                    _pwdHashed = SecurityHelper.HashPassword(value, salt, 10101, 70); ;
                }
            }
        }
        public string pwdHashed
        {
            get => _pwdHashed;
        }
    }
}