using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUI
{
   public interface IBehandelingCollectieUI
    {
        void BehandelingToevoegen(BehandelingsInfoUI behandeling, CategorieInfoUI categorieInfoUI);
        void BehandelingVerwijderen(int behandelingId);
        List<BehandelingsInfoUI> AlleBehandelingenOphalen();
        List<BehandelingsInfoUI> AlleBehandelingenVoorCategorie(int categoryid);
        BehandelingsInfoUI HaalBehandelingIdOp(int id);
    }
}
