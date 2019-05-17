using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDAL
{
    public struct ProductInfoDal
    {
        public int ProductId { get; }
        public string Titel { get;}
        public string Omschrijving { get;}
        public string Image { get;}
        public KapperszaakInfoDal kapperszaakdal { get; }

        public ProductInfoDal(KapperszaakInfoDal KappersZaakDal, int productId ,string titel, string omschrijving, string image)
        {
            kapperszaakdal = KappersZaakDal;
            ProductId = productId;
            Titel = titel;
            Omschrijving = omschrijving;
            Image = image;
        }
    }
}
