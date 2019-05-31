using InterfaceDAL;
using DAL;
using DAL.Tests;
using IntergratieDatabase;

namespace FactoryDAL
{
    public static class DatabaseFactory
    {
        public static bool UnitTesting { get; set; } = false;
        public static bool IntergratieTest { get; set; } = false;
        public static IBehandelingDAL Behandelingdal()
        {
            return new BehandelingDatabase();
        }
        public static IBehandelingCollectieDAL BehandelingCollectieDAL()
        {
            if (UnitTesting)
            {
                return new BehandelingContext();
            }
            if (IntergratieTest)
            {
                return new BehandelingIntergratieTest();
            }
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
        public static ICategorieCollectionDAL CategorieCollectieDal()
        {
            if (UnitTesting)
            {
                return new CategorieContext();
            }
            return new CategorieDatabase();
        }
        public static ICategorieDAL CategorieDal()
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

        public static IAfspraakDAL AfspraakDal()
        {
            if (UnitTesting)
            {
            }
            if (IntergratieTest)
            {
                return new AfspraakIntergratrietest();
            }
            return new AfspraakDatabase();
        }
    }
}
