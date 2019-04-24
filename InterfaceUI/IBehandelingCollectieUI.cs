using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUI
{
   public interface IBehandelingCollectieUI
    {
        void BehandelingToevoegen(BehandelingsInfoUI behandeling);
        void BehandelingVerwijderen(BehandelingsInfoUI behandeling);
        List<BehandelingsInfoUI> AlleBehandelingenOphalen();
    }
}
