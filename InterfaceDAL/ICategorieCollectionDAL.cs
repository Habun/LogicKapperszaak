using System.Collections.Generic;


namespace InterfaceDAL
{
   public interface ICategorieCollectionDAL
    {
        void VoegCategorieToe(CategorieInfoDal categorieinfoDal);
        void VerwijderCategorie(int categorieId);
        List<CategorieInfoDal> HaalCategorieOp();
    }
}
