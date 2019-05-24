

namespace InterfaceDAL
{
    public struct BehandelingInfoDal
    {
        public int Id { get; }
        public string Omschrijving { get;}
        public decimal Bedrag { get;}
        public CategorieInfoDal categorieinfoDal { get; }
        public BehandelingInfoDal(int id, string omschrijving, decimal bedrag, CategorieInfoDal categorieInfodal)
        {
            Id = id;
            Omschrijving = omschrijving;
            Bedrag = bedrag;
            categorieinfoDal = categorieInfodal;
        }

        public BehandelingInfoDal(int id, string omschrijving, decimal bedrag) : this()
        {
            Id = id;
            Omschrijving = omschrijving;
            Bedrag = bedrag;
        }
    }
}
