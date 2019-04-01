using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicKapperszaak
{
    public class Categorie
    {
        public int categorieId { get; set; }
        public string categorienaam { get; set; }

        public List<Behandeling> behandelingen { get; private set; } = new List<Behandeling>();

        public Categorie()
        {
        }

        public Categorie(int CategorieId, string CategorieNaam)
        {
            categorieId = CategorieId;
            categorienaam = CategorieNaam;
        }
    }
}
