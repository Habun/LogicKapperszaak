using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicKapperszaak
{
   public class Product
    {
        public string titel { get; set; }
        public string omschrijving { get; set; }
        public decimal prijs { get; set; }
        public string image { get; set; }

        public Product()
        {
        }

        public Product(string Titel, string Omschrijving, int Prijs, string Image)
        {
            titel = Titel;
            omschrijving = Omschrijving;
            prijs = Prijs;
            image = Image; 
        }

        public void UpdateProduct(string Titel, string Omschrijving, int Prijs, string Image)
        {
            titel = Titel;
            omschrijving = Omschrijving;
            prijs = Prijs;
            image = Image;
        }
    }
}
