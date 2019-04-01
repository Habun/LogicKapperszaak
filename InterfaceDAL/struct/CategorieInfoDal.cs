using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDAL
{
    public struct CategorieInfoDal
    {
        public int categorieId { get;}
        public string categorienaam { get;}
        public CategorieInfoDal(int CategorieId, string CategorieNaam)
        {
            categorieId = CategorieId;
            categorienaam = CategorieNaam;
        }
    }
}
