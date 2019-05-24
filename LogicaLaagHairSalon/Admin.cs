using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaLaagHairSalon
{
    public class Admin
    {
        private string _emailadres;
        private string _wachtwoord;

        public string Emailadres
        {
            get => _emailadres;
            set => _emailadres = value;
        }
        public string Wachtwoord
        {
            get => _wachtwoord;
            set => _wachtwoord = value;
        }
        public Admin(string emailadres, string wachtwoord)
        {
            Emailadres = emailadres;
            Wachtwoord = wachtwoord;
        }

        public List<Kapperszaak> AlleKapperszakenOphalen()
        {
            List<Kapperszaak> lijst = new List<Kapperszaak>();

            return lijst;
        }
    }
}
