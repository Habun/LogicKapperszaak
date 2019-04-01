using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDAL
{
    public struct ProductInfoDal
    {
        public string titel { get;}
        public string omschrijving { get;}
        public decimal prijs { get;}
        public string image { get;}

        public ProductInfoDal(string Titel, string Omschrijving, decimal Prijs, string Image)
        {
            titel = Titel;
            omschrijving = Omschrijving;
            prijs = Prijs;
            image = Image;
        }
    }
}
