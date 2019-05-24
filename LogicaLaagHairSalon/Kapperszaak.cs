using System;
using System.Collections.Generic;

namespace LogicaLaagHairSalon
{
    public class Kapperszaak
   {
       public int Id { get; }
       public string Naam { get; }

       public List<Product> products { get; set;  } = new List<Product>();
       public List<Werknemer> werknemers { get; set; } = new List<Werknemer>();
       public List<Cadeaukaart> cadeaukaarten { get; set; } = new List<Cadeaukaart>();
       public List<Afspraak> afspraken { get; set; } = new List<Afspraak>();

       public Kapperszaak()
       {
       }

       public Kapperszaak(int id, string naam)
       {
           Id = id;
           Naam = naam;
       }

        public void Inloggen(string emailadres, string wachtwoord)
        {
            if (emailadres == null && wachtwoord == null)
            {
                throw new NotImplementedException("Vul alle gegevens in");
            }
            throw new NotImplementedException();
        }

       public void ProductToevoegen(Product product)
       {
            products.Add(product);
       }

       public void ProductVerwijderen(Product product)
       {
           products.Remove(product);
       }

       public void WerknemerToevoegen(Werknemer werknemer)
       {
            werknemers.Add(werknemer);
       }

       public List<Product> AlleProductenOphalen()
       {
           return products;
       }

       public List<Werknemer> AlleWerknemersOphalen()
       {
           return werknemers;
       }

       public List<Afspraak> AlleAfsprakenOphalen()
       {
           return afspraken;
       }

       {
       public List<Cadeaukaart> AlleCadeaukaartenOphalen()
           return cadeaukaarten;
       }
   }
}
