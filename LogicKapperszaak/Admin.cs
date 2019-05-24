using System;
using System.Collections.Generic;
using InterfaceUI;

namespace LogicKapperszaak
{
    public class Admin : IAdminUi
    {
        private string _emailadres;
        private string _wachtwoord;

        public List<IKapperszaakUi> kapperszaken { get; } = new List<IKapperszaakUi>();
        public Admin(string emailadres, string wachtwoord)
        {
            Emailadres = emailadres;
            Wachtwoord = wachtwoord;
        }

        public string Emailadres { get => _emailadres;
            set => _emailadres = value;
        }
        public string Wachtwoord { get => _wachtwoord;
            set => _wachtwoord = value;
        }

        public List<IKapperszaakUi> AlleKapperZakenOphalen() 
        { 

            throw new NotImplementedException();
        }
    }
}
