using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUI
{
   public struct BehandelingsInfoUI
    {
        public string omschrijving { get;}
        public decimal bedrag { get;}
        public CategorieInfoUI CategorieinfoUI { get; }
        public BehandelingsInfoUI(string Omschrijving, decimal Bedrag, CategorieInfoUI categorieInfoUI)
        {
            omschrijving = Omschrijving;
            bedrag = Bedrag;
            CategorieinfoUI = categorieInfoUI;
        }
    }
}
