using System;
using InterfaceUI;
using InterfaceDAL;
using FactoryDAL;

namespace LogicKapperszaak
{
   public class Product : IProductUI
    {
        public int ProductId { get; set; }
        public string Titel { get; set; }
        public string Omschrijving { get; set; }
        public string Image { get; set; }

        IProductDAL productdal = DatabaseFactory.ProductDAL();

        private ProductInfoDal productInfo;

        public Product()
        {
        }

        public Product(int productId, string titel, string omschrijving, string image)
        {
            ProductId = productId;
            Titel = titel;
            Omschrijving = omschrijving;
            Image = image; 
        }

        public void UpdateProduct(ProductInfoUI productInfoUI, KapperszaakinfoUI kapperszaakinfoUI)
        {
            KapperszaakInfoDal kapperszaakInfoDal = new KapperszaakInfoDal(kapperszaakinfoUI.Kapperszaakid, kapperszaakinfoUI.Naam); 
            productInfo = new ProductInfoDal(kapperszaakInfoDal, productInfoUI.ProductId ,productInfoUI.Titel, productInfoUI.Omschrijving, productInfoUI.Image);
            productdal.UpdateProduct(productInfo);
        }

        public int ProductIdDoorGeven()
        {
            if (productdal.GeefProductId() == 0)
            {
                throw new ArgumentException($"Geen productId gevonden.");
            }
            return productdal.GeefProductId();
        }
    }
}
