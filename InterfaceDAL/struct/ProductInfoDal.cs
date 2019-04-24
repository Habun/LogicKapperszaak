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
        public string image { get;}
        public KapperszaakInfoDal kapperszaakdal { get; }

        public ProductInfoDal(KapperszaakInfoDal KappersZaakDal, string Titel, string Omschrijving, string Image)
        {
            kapperszaakdal = KappersZaakDal;
            titel = Titel;
            omschrijving = Omschrijving;
            image = Image;
        }
    }
}
