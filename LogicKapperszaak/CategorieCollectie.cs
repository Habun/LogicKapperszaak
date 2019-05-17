using InterfaceDAL;
using InterfaceUI;
using System.Collections.Generic;
using FactoryDAL;

namespace LogicKapperszaak
{
   public class CategorieCollectie : ICategorieCollectieUI
    {
        ICategorieCollectionDAL CategorieCollectionDAL = DatabaseFactory.CategorieDal();
        CategorieInfoDal categorieinfoDal;
        public void CategorieToevoegen(CategorieInfoUI categorieUI)
        {
            categorieinfoDal = new CategorieInfoDal(categorieUI.CategorieId, categorieUI.Categorienaam);

        }
        public void CategorieVerwijderen(CategorieInfoUI categorieUI)
        {
        }
        public List<CategorieInfoUI> AlleCategorieenOphalen()
        {
            List<CategorieInfoUI> categorielijst = new List<CategorieInfoUI>();

            foreach (var Cinfo in CategorieCollectionDAL.HaalBehandelingenOp())
            {
                CategorieInfoUI categorieInfoUI = new CategorieInfoUI(Cinfo.CategorieId, Cinfo.Categorienaam);
                categorielijst.Add(categorieInfoUI);
            }
            return categorielijst;
        }
    }
}
