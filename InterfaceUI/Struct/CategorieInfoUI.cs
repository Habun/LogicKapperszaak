using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUI
{
    public struct CategorieInfoUI
    {
        public int categorieId { get;}
        public string categorienaam { get;}
        public CategorieInfoUI(int CategorieId, string CategorieNaam)
        {
            categorieId = CategorieId;
            categorienaam = CategorieNaam;
        }

        public CategorieInfoUI(int id) : this()
        {
            this.categorieId = id;
        }
    }
}

