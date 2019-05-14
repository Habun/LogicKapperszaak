using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUI
{
   public struct ProductInfoUI
    {
        public int productId { get; }
        public string titel { get;}
        public string omschrijving { get;}
        public string image { get;}

        public KapperszaakinfoUI kapperszaakinfoUI { get; }

        public ProductInfoUI(KapperszaakinfoUI KappersZaakInfoUI, int ProductId ,string Titel, string Omschrijving,string Image)
        {
            kapperszaakinfoUI = KappersZaakInfoUI;
            productId = ProductId;
            titel = Titel;
            omschrijving = Omschrijving;
            image = Image;
        }

        public ProductInfoUI(int productId) : this()
        {
            this.productId = productId;
        }
    }
}
