using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDAL
{
    public struct AdminInfoDal
    {
        public string emailadres { get;}
        public string wachtwoord { get; }

        public AdminInfoDal(string Emailadres, string Wachtwoord)
        {
            emailadres = Emailadres;
            wachtwoord = Wachtwoord;
        }
    }
}
