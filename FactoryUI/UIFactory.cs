using InterfaceUI;
using LogicKapperszaak;
using System.Configuration;

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

        public static ICategorieUI Categorie()
        {
            return new Categorie();
        }

        public static IAfspraakUi Afspraak()
        {
            return new Afspraak();
        }
        public static IAdminUi Admin(string emailadres, string wachtwoord)
        {
            return new Admin(emailadres, wachtwoord);
        }
    }
}
