using InterfaceDAL;
using DAL;
using DAL.Tests;
namespace FactoryDAL
{
    public static class DatabaseFactory
    {
        //public static void Main()
        //{
        //    switch (())
        //    {
        //        case false:
        //            MemoryContext();
        //            break;
        //        case true:
        //            BehandelingCollectieDAL();
        //            break;
        //    }
        //}
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
        public static ICategorieCollectionDAL CategorieDAL()
        {
            return new CategorieDatabase();
        }
        public static IAdminDAL AdminDAL()
        {
            return new AdminDatabase();
        }
        public static ICadeauKaartDal CadeauKaartDal()
        {
            return new CadeauKaartDatabase();
        }



        //unit test
        public static IBehandelingCollectieDAL MemoryContext()
        {
            return new BehandelingContext();
        }
        public static IKapperszaakDAL KapperszaakContext()
        {
            return new KappersZaakContext();
        }
    }
}
