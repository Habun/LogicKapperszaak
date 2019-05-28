using System;


namespace InterfaceDAL
{
    public struct ProductInfoDal
    {
        public int Id { get; }
        public string Titel { get;}
        public string Omschrijving { get;}
        public string Image { get;}

        public ProductInfoDal(int id, string titel, string omschrijving, string image)
        {
            Id = id;
            Titel = titel;
            Omschrijving = omschrijving;
            Image = image;
        }
    }
}
