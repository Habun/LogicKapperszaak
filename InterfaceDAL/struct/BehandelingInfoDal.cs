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
        public CategorieInfoDal CategorieinfoDal { get; }
        public BehandelingInfoDal(string Omschrijving, decimal Bedrag, CategorieInfoDal categorieInfodal)
        {
            omschrijving = Omschrijving;
            bedrag = Bedrag;
            CategorieinfoDal = categorieInfodal;
        }
    }
}
