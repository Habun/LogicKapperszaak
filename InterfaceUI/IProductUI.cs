
namespace InterfaceUI
{
   public interface IProductUi
    {
        string Titel { get;}
        string Omschrijving { get;}
        string Image { get; }

        void UpdateProduct(IProductUi product);
    }
}
