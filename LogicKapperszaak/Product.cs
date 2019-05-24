using System;
using InterfaceUI;
using InterfaceDAL;
using FactoryDAL;

namespace LogicKapperszaak
{
   public class Product : IProductUi
    {
        public string Titel { get;}
        public string Omschrijving { get;}
        public string Image { get;}

        IProductDAL productdal = DatabaseFactory.ProductDAL();

        public ProductInfoDal productInfo;

        public Product()
        {

        }

        public Product(string titel, string omschrijving, string image)
        {
            Titel = titel;
            Omschrijving = omschrijving;
            Image = image; 
        }

        public void UpdateProduct(IProductUi product)
        {
            productInfo = new ProductInfoDal(product.Titel, product.Omschrijving, product.Image);
            productdal.UpdateProduct(productInfo);
        }
    }
}
