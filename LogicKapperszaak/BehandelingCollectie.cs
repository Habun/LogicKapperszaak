using InterfaceUI;
using System.Collections.Generic;
using FactoryDAL;
using InterfaceDAL;

namespace LogicKapperszaak
{
   public class BehandelingCollectie : IBehandelingCollectieUI
    {
        IBehandelingCollectieDAL BehandelingCollectieDAL = DatabaseFactory.BehandelingCollectieDAL();

        BehandelingInfoDal behandelinginfoDal;
        public void BehandelingToevoegen(BehandelingsInfoUI behandelingUI, CategorieInfoUI categorieInfoUI)
        {
            CategorieInfoDal categorieInfoDal = new CategorieInfoDal(categorieInfoUI.CategorieId, categorieInfoUI.Categorienaam);

            behandelinginfoDal = new BehandelingInfoDal(behandelinginfoDal.BehandelingId, behandelingUI.Omschrijving, behandelingUI.Bedrag, categorieInfoDal);
            BehandelingCollectieDAL.VoegBehandelingToe(behandelinginfoDal);
        }
        public void BehandelingVerwijderen(int behandelingId)
        {
            BehandelingCollectieDAL.VerwijderBehandeling(behandelingId);
        }
        public List<BehandelingsInfoUI> AlleBehandelingenOphalen() 
        {
            List<BehandelingsInfoUI> lijstbehandeling = new List<BehandelingsInfoUI>();

            foreach (var bhInfo in BehandelingCollectieDAL.HaalBehandelingenOp())
            {
                CategorieInfoUI categorieInfoUI = new CategorieInfoUI(bhInfo.categorieinfoDal.CategorieId, bhInfo.categorieinfoDal.Categorienaam);

                BehandelingsInfoUI behandelingUI = new BehandelingsInfoUI(bhInfo.BehandelingId,bhInfo.Omschrijving, bhInfo.Bedrag, categorieInfoUI);
                lijstbehandeling.Add(behandelingUI);
            }
            return lijstbehandeling; 
        }
        public List<BehandelingsInfoUI> AlleBehandelingenVoorCategorie(int categoryid)
        {
            List<BehandelingsInfoUI> alleBehandelingenVoorCategorie = new List<BehandelingsInfoUI>();

            foreach (var bhInfo in BehandelingCollectieDAL.GeefAlleBehandelingVoorCategorie(categoryid))
            {                
                    BehandelingsInfoUI behandelingUI = new BehandelingsInfoUI(bhInfo.BehandelingId, bhInfo.Omschrijving, bhInfo.Bedrag);
                    alleBehandelingenVoorCategorie.Add(behandelingUI);
            }
            return alleBehandelingenVoorCategorie;
        }
    }
}
