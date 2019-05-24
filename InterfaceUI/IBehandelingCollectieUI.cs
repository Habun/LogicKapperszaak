using System.Collections.Generic;


namespace InterfaceUI
{
   public interface IBehandelingCollectieUi
   {
       void BehandelingToevoegen(IBehandelingUi behandeling);
       void BehandelingVerwijderen(int behandelingId);
       List<IBehandelingUi> AlleBehandelingenOphalen();
       List<IBehandelingUi> AlleBehandelingenVoorCategorie(string categorieNaam);
    }
}
