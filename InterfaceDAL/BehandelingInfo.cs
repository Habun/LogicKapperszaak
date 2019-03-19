using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDAL
{
    public struct BehandelingInfo
    {
        public string omschrijving { get; private set; }
        public decimal bedrag { get; private set; }

        public BehandelingInfo(string Omschrijving, decimal Bedrag)
        {
            omschrijving = Omschrijving;
            bedrag = Bedrag;
        }
    }
}
