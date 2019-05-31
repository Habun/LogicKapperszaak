using InterfaceDAL;
using InterfaceUI;
using System.Collections.Generic;
using FactoryDAL;
using System;

namespace LogicKapperszaak
{
   public class CategorieCollectie : ICategorieCollectieUi
   {
        public ICategorieCollectionDAL CategorieCollectionDAL = DatabaseFactory.CategorieCollectieDal();

        public void CategorieToevoegen(ICategorieUI categorieUI)
        {
            if (!CategorieCollectionDAL.HaalCategorieOp().Exists(Cnaam => Cnaam.Categorienaam == categorieUI.Categorienaam))
            {
                CategorieInfoDal categorieinfo = new CategorieInfoDal(categorieUI.CategorieId, categorieUI.Categorienaam);
                CategorieCollectionDAL.VoegCategorieToe(categorieinfo);
            }
            else throw new NotImplementedException($"U kunt niet hetzelfde categorie toevoegen");
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
