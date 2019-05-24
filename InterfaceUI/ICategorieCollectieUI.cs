using System.Collections.Generic;


namespace InterfaceUI
{
    public interface ICategorieCollectieUi
    {
        void CategorieToevoegen(ICategorieUI categorieUI);
        void CategorieVerwijderen(int categorieId);
        List<ICategorieUI> AlleCategorieenOphalen();
    }
}
