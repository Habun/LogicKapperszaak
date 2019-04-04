using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUI
{
   public struct ProductInfoUI
    {
        public string titel { get;}
        public string omschrijving { get;}
        public decimal prijs { get;}
        public string image { get;}

        public KapperszaakinfoUI kapperszaakinfoUI { get; }

        public ProductInfoUI(KapperszaakinfoUI KappersZaakInfoUI,string Titel, string Omschrijving, decimal Prijs, string Image)
        {
            kapperszaakinfoUI = KappersZaakInfoUI;
            titel = Titel;
            omschrijving = Omschrijving;
            prijs = Prijs;
            image = Image;
        }
    }
}
