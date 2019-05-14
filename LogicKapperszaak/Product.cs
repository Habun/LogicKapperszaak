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
        public int productId { get; set; }
        public string titel { get; set; }
        public string omschrijving { get; set; }
        public string image { get; set; }

        IProductDAL productdal = DatabaseFactory.ProductDAL();

        ProductInfoDal productInfo = new ProductInfoDal();

        public Product()
        {
        }

        public Product(int ProductId, string Titel, string Omschrijving, string Image)
        {
            productId = ProductId;
            titel = Titel;
            omschrijving = Omschrijving;
            image = Image; 
        }

        public void UpdateProduct(ProductInfoUI productInfoUI, KapperszaakinfoUI kapperszaakinfoUI)
        {
            KapperszaakInfoDal kapperszaakInfoDal = new KapperszaakInfoDal(kapperszaakinfoUI.kapperszaakid, kapperszaakinfoUI.naam); 
            productInfo = new ProductInfoDal(kapperszaakInfoDal, productInfoUI.productId ,productInfoUI.titel, productInfoUI.omschrijving, productInfoUI.image);
            productdal.UpdateProduct(productInfo);
        }

        public ProductInfoUI HaalBehandelingIdOp(int productId)
        {
            productdal.ProductIdOphalen(productId);
            ProductInfoUI productUI = new ProductInfoUI(productId);

            if (productId == 0)
            {
                throw new ArgumentException($"Geen productId gevonden.");
            }
            else
            {
                return productUI;
            }
        }
    }
}
