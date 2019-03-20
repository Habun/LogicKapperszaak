using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUI
{
   public struct BehandelingsInfoUI
    {
        public string omschrijving { get; private set; }
        public decimal bedrag { get; private set; }

        public BehandelingsInfoUI(string Omschrijving, decimal Bedrag)
        {
            omschrijving = Omschrijving;
            bedrag = Bedrag;
        }
    }
}
