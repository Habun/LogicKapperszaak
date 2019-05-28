using InterfaceDAL;
using InterfaceUI;
using System.Collections.Generic;
using FactoryDAL;

namespace LogicKapperszaak
{
   public class CategorieCollectie : ICategorieCollectieUi
   {
       public ICategorieCollectionDAL CategorieCollectionDAL = DatabaseFactory.CategorieDAL();

        public void CategorieToevoegen(ICategorieUI categorieUI)
        {
            CategorieInfoDal categorieinfo = new CategorieInfoDal(categorieUI.CategorieId, categorieUI.Categorienaam);
            CategorieCollectionDAL.VoegCategorieToe(categorieinfo);
        }
        public void CategorieVerwijderen(int categorieId)
        {
            CategorieCollectionDAL.VerwijderCategorie(categorieId);
        }
        public List<ICategorieUI> AlleCategorieenOphalen()
        {
            List<ICategorieUI> categorielijst = new List<ICategorieUI>();

            foreach (var Cinfo in CategorieCollectionDAL.HaalCategorieOp())
            {
                ICategorieUI categorieInfoUI = new Categorie(Cinfo.CategorieId, Cinfo.Categorienaam);
                categorielijst.Add(categorieInfoUI);
            }
            return categorielijst;
        }
    }
}
