using System.Collections.Generic;


namespace InterfaceUI
{
   public interface IBehandelingCollectieUI
    {
        void BehandelingToevoegen(BehandelingsInfoUI behandeling, CategorieInfoUI categorieInfoUI);
        void BehandelingVerwijderen(int behandelingId);
        List<BehandelingsInfoUI> AlleBehandelingenOphalen();
        List<BehandelingsInfoUI> AlleBehandelingenVoorCategorie(int categoryid);
    }
}
