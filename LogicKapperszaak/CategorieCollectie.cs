using InterfaceDAL;
using InterfaceUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryDAL;

namespace LogicKapperszaak
{
   public class CategorieCollectie : ICategorieCollectieUI
    {
        ICategorieCollectionDAL CategorieCollectionDAL = DatabaseFactory.CategorieDal();
        CategorieInfoDal categorieinfoDal;
        public void CategorieToevoegen(CategorieInfoUI categorieUI)
        {
            categorieinfoDal = new CategorieInfoDal(categorieUI.categorieId, categorieUI.categorienaam);

        }
        public void CategorieVerwijderen(CategorieInfoUI categorieUI)
        {
        }
        public List<CategorieInfoUI> AlleCategorieenOphalen()
        {
            List<CategorieInfoUI> categorielijst = new List<CategorieInfoUI>();

            foreach (var Cinfo in CategorieCollectionDAL.HaalBehandelingenOp())
            {
                CategorieInfoUI categorieInfoUI = new CategorieInfoUI(Cinfo.categorieId, Cinfo.categorienaam);
                categorielijst.Add(categorieInfoUI);
            }
            return categorielijst;
        }
        public CategorieInfoUI HaalCategorieIdOp(int id)
        {
            CategorieCollectionDAL.CategoryIdOphalen(id);
            CategorieInfoUI categorieInfoUI = new CategorieInfoUI(id);

            if (id == 0)
            {
                throw new NotImplementedException();
            }
            else
            {
                return categorieInfoUI;
            }
        }
    }
}
