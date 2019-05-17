using System;
using System.Collections.Generic;

namespace LogicKapperszaak
{
    public class Admin
    {
        private string _emailadres;
        private string _wachtwoord;

        public string Emailadres { get => _emailadres;
            set => _emailadres = value;
        }
        public string Wachtwoord { get => _wachtwoord;
            set => _wachtwoord = value;
        }

        public Admin(string emailadres, string wachtwoord)
        {
            Emailadres = emailadres;
            Wachtwoord = wachtwoord; 
        }

        public List<Kapperszaak> AlleKapperszakenOphalen()
        {
            throw new NotImplementedException();
        }
    }
}
