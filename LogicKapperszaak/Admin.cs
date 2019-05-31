using System.Collections.Generic;
using FactoryDAL;
using InterfaceUI;
using InterfaceDAL;

namespace LogicKapperszaak
{
    public class Admin : IAdminUi
    {
        private string _emailadres;
        private string _wachtwoord;

        private IAdminDAL adminDal = DatabaseFactory.AdminDAL();
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
            foreach (var kpInfo in adminDal.AlleKappersZakenOphalen())
            {
                IKapperszaakUi kapperszaak = new Kapperszaak(kpInfo.Id, kpInfo.Naam);
                kapperszaken.Add(kapperszaak);
            }
            return kapperszaken;
        }
    }
}
