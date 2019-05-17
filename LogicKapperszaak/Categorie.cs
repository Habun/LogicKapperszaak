
namespace LogicKapperszaak
{
    public class Categorie
    {
        public int CategorieId { get; set; }
        public string Categorienaam { get; set; }

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
