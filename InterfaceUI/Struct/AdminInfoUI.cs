using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUI
{
    public struct AdminInfoUI
    {
        public string emailadres { get; private set; }
        public string wachtwoord { get; private set; }

        public AdminInfoUI(string Emailadres, string Wachtwoord)
        {
            emailadres = Emailadres;
            wachtwoord = Wachtwoord;
        }
    }
}
