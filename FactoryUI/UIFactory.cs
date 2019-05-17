using InterfaceUI;
using LogicKapperszaak;

namespace FactoryUI
{
   public class UIFactory
    {
        public static IBehandelingCollectieUI BehandelingCollectie()
        {
            return new BehandelingCollectie();
        }
        public static IBehandelingUi Behandeling()
        {
            return new Behandeling();
        }
        public static IKlantUI Klant()
        {
            return new Klant();
        }
        public static IProductUI Product()
        {
            return new Product();
        }
        public static IKapperszaakUI Kapperszaak()
        {
            return new Kapperszaak();
        }
        public static ICategorieCollectieUI CategorieCollectie()
        {
            return new CategorieCollectie();
        }
    }
}
