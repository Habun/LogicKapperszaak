using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUI
{
    public interface ICategorieCollectieUI
    {
        void CategorieToevoegen(CategorieInfoUI categorieUI);
        void CategorieVerwijderen(CategorieInfoUI categorieUI);
        List<CategorieInfoUI> AlleCategorieenOphalen();
    }
}
