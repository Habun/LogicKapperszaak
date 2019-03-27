using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDAL
{
    public struct BehandelingInfoDal
    {
        public string omschrijving { get;}
        public decimal bedrag { get;}

        public BehandelingInfoDal(string Omschrijving, decimal Bedrag)
        {
            omschrijving = Omschrijving;
            bedrag = Bedrag;
        }
    }
}
