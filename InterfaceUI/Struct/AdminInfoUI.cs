using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUI
{
    public struct AdminInfoUI
    {
        public string emailadres { get;}
        public string wachtwoord { get;}

        public AdminInfoUI(string Emailadres, string Wachtwoord)
        {
            emailadres = Emailadres;
            wachtwoord = Wachtwoord;
        }
    }
}
