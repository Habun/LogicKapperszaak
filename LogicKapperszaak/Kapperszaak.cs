using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicKapperszaak
{
   public class Kapperszaak
    {
        public string naam { get; set; }
        public List<Product> productLijst { get; private set; } = new List<Product>();

        public Kapperszaak()
        {

        }

        public void Inloggen(string Emailadres, string Wachtwoord) // admin meegeven 
        {
            if (Emailadres == null && Wachtwoord == null)
            {
                throw new NotImplementedException();
            }
            else
            {
                
            }
        }

        public void VoegProductToe(Product product)
        {
            
        }

        public void VerwijderProduct(Product product)
        {

        }
        public List<Product> AlleProductenOphalen()
        {
            throw new NotImplementedException();
        }
        public List<Afspraak> AlleAfsprakenOphalen() 
        {
            throw new NotImplementedException();
        }
        public List<CadeauKaart> AlleCadeauKaartenOphalen()
        {
            throw new NotImplementedException();
        }
    }
}
