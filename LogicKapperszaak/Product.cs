using InterfaceUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceDAL;
using FactoryDAL;

namespace LogicKapperszaak
{
   public class Product : IProductUI
    {
        public string titel { get; set; }
        public string omschrijving { get; set; }
        public decimal prijs { get; set; }
        public string image { get; set; }

        IProductDAL productdal = DatabaseFactory.ProductDAL();

        ProductInfoDal productInfo = new ProductInfoDal();

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

        public void UpdateProduct(ProductInfoUI productInfoUI)
        {
            productInfo = new ProductInfoDal(productInfoUI.titel, productInfoUI.omschrijving, productInfoUI.prijs, productInfoUI.image);
            productdal.UpdateProduct(productInfo);
        }
    }
}
