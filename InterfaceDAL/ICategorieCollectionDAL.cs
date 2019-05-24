using System.Collections.Generic;


namespace InterfaceDAL
{
   public interface ICategorieCollectionDAL
    {
        void VoegCategorieToe(CategorieInfoDal categorieinfoDal);
        void VerwijderCategorie(CategorieInfoDal categorieinfoDal);
        List<CategorieInfoDal> HaalCategorieOp();
    }
}
