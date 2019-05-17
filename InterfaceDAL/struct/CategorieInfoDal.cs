

namespace InterfaceDAL
{
    public struct CategorieInfoDal
    {
        public int CategorieId { get;}
        public string Categorienaam { get;}
        public CategorieInfoDal(int categorieId, string categorieNaam)
        {
            CategorieId = categorieId;
            Categorienaam = categorieNaam;
        }
    }
}
