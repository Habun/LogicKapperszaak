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
        public static IBehandelingCollectieUI behandelingCollectieUI()
        {
            return new BehandelingCollectie();
        }
        public static IBehandelingUI behandelingUI()
        {
            return new Behandeling();
        }
    }
}
