using InterfaceUI;
using InterfaceDAL;
using FactoryDAL;

namespace LogicKapperszaak
{
   public class Product : IProductUi
    {
        public int Id { get; }
        public string Titel { get;}
        public string Omschrijving { get;}
        public string Image { get;}

        IProductDAL productdal = DatabaseFactory.ProductDAL();

        public Product()
        {
        }

        public Product(int id, string titel, string omschrijving, string image)
        {
            Id = id;
            Titel = titel;
            Omschrijving = omschrijving;
            Image = image; 
        }

        public void UpdateProduct(IProductUi product)
        {
            ProductInfoDal productInfo = new ProductInfoDal(product.Id, product.Titel, product.Omschrijving, product.Image);
            productdal.UpdateProduct(productInfo);
        }
    }
}
