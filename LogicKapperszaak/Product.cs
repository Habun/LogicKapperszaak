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
        public string image { get; set; }

        IProductDAL productdal = DatabaseFactory.ProductDAL();

        ProductInfoDal productInfo = new ProductInfoDal();

        public Product()
        {
        }

        public Product(string Titel, string Omschrijving, string Image)
        {
            titel = Titel;
            omschrijving = Omschrijving;
            image = Image; 
        }

        public void UpdateProduct(ProductInfoUI productInfoUI, KapperszaakinfoUI kapperszaakinfoUI)
        {
            KapperszaakInfoDal kapperszaakInfoDal = new KapperszaakInfoDal(kapperszaakinfoUI.kapperszaakid, kapperszaakinfoUI.naam); 
            productInfo = new ProductInfoDal(kapperszaakInfoDal , productInfoUI.titel, productInfoUI.omschrijving, productInfoUI.image);
            productdal.UpdateProduct(productInfo);
        }
    }
}
