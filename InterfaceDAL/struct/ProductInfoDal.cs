using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDAL
{
    public struct ProductInfoDal
    {
        public string titel { get; private set; }
        public string omschrijving { get; private set; }
        public decimal prijs { get; private set; }
        public string image { get; private set; }

        public ProductInfoDal(string Titel, string Omschrijving, decimal Prijs, string Image)
        {
            titel = Titel;
            omschrijving = Omschrijving;
            prijs = Prijs;
            image = Image;
        }
    }
}
