using System.Collections.Generic;


namespace InterfaceUI
{
    public interface ICategorieCollectieUI
    {
        void CategorieToevoegen(CategorieInfoUI categorieUI);
        void CategorieVerwijderen(CategorieInfoUI categorieUI);
        List<CategorieInfoUI> AlleCategorieenOphalen();
    }
}
