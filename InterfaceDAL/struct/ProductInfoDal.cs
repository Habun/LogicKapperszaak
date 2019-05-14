using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDAL
{
    public struct ProductInfoDal
    {
        public int productId { get; }
        public string titel { get;}
        public string omschrijving { get;}
        public string image { get;}
        public KapperszaakInfoDal kapperszaakdal { get; }

        public ProductInfoDal(KapperszaakInfoDal KappersZaakDal, int ProductId ,string Titel, string Omschrijving, string Image)
        {
            kapperszaakdal = KappersZaakDal;
            productId = ProductId;
            titel = Titel;
            omschrijving = Omschrijving;
            image = Image;
        }
        public ProductInfoDal(int ProductId) : this()
        {
            productId = ProductId;
        }
    }
}
