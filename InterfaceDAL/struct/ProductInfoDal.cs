using System;


namespace InterfaceDAL
{
    public struct ProductInfoDal
    {
        public string Titel { get;}
        public string Omschrijving { get;}
        public string Image { get;}

        public ProductInfoDal(string titel, string omschrijving, string image)
        {
            Titel = titel;
            Omschrijving = omschrijving;
            Image = image;
        }
    }
}
