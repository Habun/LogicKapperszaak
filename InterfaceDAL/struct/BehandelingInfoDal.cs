using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDAL
{
    public struct BehandelingInfoDal
    {
        public int behandelingId { get;}
        public string omschrijving { get;}
        public decimal bedrag { get;}
        public CategorieInfoDal CategorieinfoDal { get; }
        public BehandelingInfoDal(int BehandelingId, string Omschrijving, decimal Bedrag, CategorieInfoDal categorieInfodal)
        {
            behandelingId = BehandelingId;
            omschrijving = Omschrijving;
            bedrag = Bedrag;
            CategorieinfoDal = categorieInfodal;
        }

        public BehandelingInfoDal(int BehandelingId, string Omschrijving, decimal Bedrag) : this()
        {
            behandelingId = BehandelingId;
            omschrijving = Omschrijving;
            bedrag = Bedrag;
        }
        public BehandelingInfoDal(int BehandelingId) : this()
        {
            behandelingId = BehandelingId;
        }
    }
}
