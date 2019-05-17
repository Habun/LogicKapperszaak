

namespace InterfaceUI
{
    public struct CategorieInfoUI
    {
        public int CategorieId { get;}
        public string Categorienaam { get;}
        public CategorieInfoUI(int categorieId, string categorieNaam)
        {
            CategorieId = categorieId;
            Categorienaam = categorieNaam;
        }
    }
}

