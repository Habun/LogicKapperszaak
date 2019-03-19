using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicKapperszaak
{
    public class Admin
    {
        private string _emailadres;
        private string _wachtwoord;

        public string emailadres { get { return _emailadres; } set { _emailadres = value; } }
        public string wachtwoord { get { return _wachtwoord; } set { _wachtwoord = value; } }

        public Admin(string Emailadres, string Wachtwoord)
        {
            emailadres = Emailadres;
            wachtwoord = Wachtwoord; 
        }

        public List<Kapperszaak> AlleKapperszakenOphalen() //moet kapperszaak zijn
        {
            throw new NotImplementedException();
        }
    }
}
