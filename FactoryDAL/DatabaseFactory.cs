using InterfaceDAL;
using DAL;

namespace FactoryDAL
{
    public static class DatabaseFactory
    {
        public static IBehandelingDAL Behandelingdal()
        {
            return new BehandelingDatabase();
        }
        public static IBehandelingCollectieDAL BehandelingCollectieDAL()
        {
            return new BehandelingDatabase();
        }
        public static IKlantDAL KlantDAL()
        {
            return new KlantDatabase();
        }
        public static IProductDAL ProductDAL()
        {
            return new ProductDatabase();
        }
        public static IKapperszaakDAL KapperszaakDAL()
        {
            return new KapperszaakDatabase();
        }
        public static ICategorieCollectionDAL CategorieDal()
        {
            return new CategorieDatabase();
        }
    }
}
