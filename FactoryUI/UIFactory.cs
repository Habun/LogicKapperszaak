using InterfaceUI;
using LogicKapperszaak;

namespace FactoryUI
{
   public class UIFactory
    {
        public static IBehandelingCollectieUi BehandelingCollectie()
        {
            return new BehandelingCollectie();
        }
        public static IBehandelingUi Behandeling()
        {
            return new Behandeling();
        }
        public static IKlantUi Klant()
        {
            return new Klant();
        }
        public static IProductUi Product()
        {
            return new Product();
        }
        public static IKapperszaakUi Kapperszaak()
        {
            return new Kapperszaak();
        }
        public static ICategorieCollectieUi CategorieCollectie()
        {
            return new CategorieCollectie();
        }
    }
}
