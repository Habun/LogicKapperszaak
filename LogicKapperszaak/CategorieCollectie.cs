using InterfaceDAL;
using InterfaceUI;
using System.Collections.Generic;
using FactoryDAL;

namespace LogicKapperszaak
{
   public class CategorieCollectie : ICategorieCollectieUi
    {
        ICategorieCollectionDAL CategorieCollectionDAL = DatabaseFactory.CategorieDal();
        public CategorieInfoDal categorieinfoDal { get; set; }

        public void CategorieToevoegen(ICategorieUI categorieUI)
        {

        }
        public void CategorieVerwijderen(int categorieId)
        {

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
