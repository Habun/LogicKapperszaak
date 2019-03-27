using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceUI;
using LogicKapperszaak;

namespace FactoryUI
{
   public class UIFactory
    {
        public static IBehandelingCollectieUI behandelingCollectie()
        {
            return new BehandelingCollectie();
        }
        public static IBehandelingUI behandeling()
        {
            return new Behandeling();
        }
        public static IKlantUI klant()
        {
            return new Klant();
        }
        public static IProductUI product()
        {
            return new Product();
        }
        public static IKapperszaakUI kapperszaak()
        {
            return new Kapperszaak();
        }
    }
}
