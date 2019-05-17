
namespace InterfaceUI
{
   public struct ProductInfoUI
    {
        public int ProductId { get; }
        public string Titel { get;}
        public string Omschrijving { get;}
        public string Image { get;}

        public KapperszaakinfoUI kapperszaakinfoUI { get; }

        public ProductInfoUI(KapperszaakinfoUI kapperszaakinfoUi, int productId ,string titel, string omschrijving, string image)
        {
            kapperszaakinfoUI = kapperszaakinfoUi;
            ProductId = productId;
            Titel = titel;
            Omschrijving = omschrijving;
            Image = image;
        }
    }
}
