using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDAL
{
    public struct AdminInfoDal
    {
        public string emailadres { get; private set; }
        public string wachtwoord { get; private set; }

        public AdminInfoDal(string Emailadres, string Wachtwoord)
        {
            emailadres = Emailadres;
            wachtwoord = Wachtwoord;
        }
    }
}
