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
        public string image { get;}

        public KapperszaakinfoUI kapperszaakinfoUI { get; }

        public ProductInfoUI(KapperszaakinfoUI KappersZaakInfoUI,string Titel, string Omschrijving,string Image)
        {
            kapperszaakinfoUI = KappersZaakInfoUI;
            titel = Titel;
            omschrijving = Omschrijving;
            image = Image;
        }
    }
}
