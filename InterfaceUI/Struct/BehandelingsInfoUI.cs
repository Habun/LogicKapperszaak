using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUI
{
   public struct BehandelingsInfoUI
    {
        public int behandelingsId { get; }
        public string omschrijving { get;}
        public decimal bedrag { get;}
        public CategorieInfoUI CategorieinfoUI { get; }
        public BehandelingsInfoUI(int BehandelingsId, string Omschrijving, decimal Bedrag, CategorieInfoUI categorieInfoUI)
        {
            behandelingsId = BehandelingsId;
            omschrijving = Omschrijving;
            bedrag = Bedrag;
            CategorieinfoUI = categorieInfoUI;
        }
    }
}
