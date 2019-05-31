using System;
using System.Collections.Generic;
using InterfaceDAL;

namespace DAL.Tests
{
    public class CategorieContext : ICategorieCollectionDAL, ICategorieDAL
    {
        public List<CategorieInfoDal> Categorielijst { get; } = new List<CategorieInfoDal>()
        {
            new CategorieInfoDal(1, "Mannen"),
            new CategorieInfoDal(2, "Vrouwen"),
            new CategorieInfoDal(3, "Kinderen"),
            new CategorieInfoDal(4, "Kleuren")
        };

        public void VoegCategorieToe(CategorieInfoDal categorieinfoDal)
        {
            Categorielijst.Add(categorieinfoDal);
        }

        public void VerwijderCategorie(int categorieId)
        {
            throw new NotImplementedException();
        }

        public List<CategorieInfoDal> HaalCategorieOp()
        {
            return Categorielijst;
        }

        public void UpdateCategorie(CategorieInfoDal categorieInfoDal)
        {
            throw new NotImplementedException();
        }
    }
}
