using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicKapperszaak
{
    public class Behandeling
    {
        public string omschrijving { get; set; }
        public decimal bedrag { get; set; }

        public Behandeling(string Omschrijving, decimal Bedrag)
        {
            omschrijving = Omschrijving;
            bedrag = Bedrag;
        }

        public void UpdateBehandeling(string Omschrijving, decimal Bedrag)
        {
            omschrijving = Omschrijving;
            bedrag = Bedrag;
        }
    }
}
