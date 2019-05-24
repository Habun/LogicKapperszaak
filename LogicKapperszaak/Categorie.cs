
using InterfaceUI;

namespace LogicKapperszaak
{
    public class Categorie : ICategorieUI
    {
        public int CategorieId { get;}
        public string Categorienaam { get;}

        public Categorie()
        {
        }

        public Categorie(int categorieId, string categorieNaam)
        {
            CategorieId = categorieId;
            Categorienaam = categorieNaam;
        }
    }
}
