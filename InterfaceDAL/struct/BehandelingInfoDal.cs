

namespace InterfaceDAL
{
    public struct BehandelingInfoDal
    {
        public int BehandelingId { get;}
        public string Omschrijving { get;}
        public decimal Bedrag { get;}
        public CategorieInfoDal categorieinfoDal { get; }
        public BehandelingInfoDal(int behandelingId, string omschrijving, decimal bedrag, CategorieInfoDal categorieInfodal)
        {
            BehandelingId = behandelingId;
            Omschrijving = omschrijving;
            Bedrag = bedrag;
            categorieinfoDal = categorieInfodal;
        }

        public BehandelingInfoDal(int behandelingId, string omschrijving, decimal bedrag) : this()
        {
            BehandelingId = behandelingId;
            Omschrijving = omschrijving;
            Bedrag = bedrag;
        }
    }
}
