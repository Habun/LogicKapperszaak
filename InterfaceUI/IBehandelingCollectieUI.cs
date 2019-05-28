using System.Collections.Generic;


namespace InterfaceUI
{
   public interface IBehandelingCollectieUi
   {
       void BehandelingToevoegen(IBehandelingUi behandeling, ICategorieUI categorie);
       void BehandelingVerwijderen(int behandelingId);
       List<IBehandelingUi> AlleBehandelingenOphalen();
       List<IBehandelingUi> AlleBehandelingenVoorCategorie(string categorieNaam);
    }
}
