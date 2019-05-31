using FactoryDAL;
using InterfaceDAL;
using InterfaceUI;

namespace LogicKapperszaak
{
    public class Categorie : ICategorieUI
    {
        public int CategorieId { get;}
        public string Categorienaam { get;}

        private ICategorieDAL IcategorieDal = DatabaseFactory.CategorieDal();

        public Categorie()
        {
        }

        public Categorie(int categorieId, string categorieNaam)
        {
            CategorieId = categorieId;
            Categorienaam = categorieNaam;
        }

        public void UpdateCategorie(ICategorieUI categorie)
        {
            CategorieInfoDal categorieInfoDal = new CategorieInfoDal(categorie.CategorieId, categorie.Categorienaam);
            IcategorieDal.UpdateCategorie(categorieInfoDal);
        }
    }
}
