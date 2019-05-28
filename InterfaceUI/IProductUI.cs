
namespace InterfaceUI
{
   public interface IProductUi
    {
        int Id { get; }
        string Titel { get;}
        string Omschrijving { get;}
        string Image { get; }

        void UpdateProduct(IProductUi product);
    }
}
