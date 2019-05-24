using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaLaagHairSalon
{
    public class Cadeaukaart
    {
        public string Bestemd { get; }
        public int Bedrag { get; }

        public Cadeaukaart()
        {
        }

        public Cadeaukaart(string bestemd, int bedrag)
        {
            Bestemd = bestemd;
            Bedrag = bedrag;
        }

        public void UpdateCadeaukaart(Cadeaukaart cadeaukaart)
        {
        }
    }
}
