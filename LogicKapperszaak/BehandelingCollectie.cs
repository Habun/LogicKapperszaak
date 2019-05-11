using InterfaceUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryDAL;
using InterfaceDAL;

namespace LogicKapperszaak
{
   public class BehandelingCollectie : IBehandelingCollectieUI
    {
        IBehandelingCollectieDAL BehandelingCollectieDAL = DatabaseFactory.BehandelingCollectieDAL();

        BehandelingInfoDal behandelinginfoDal = new BehandelingInfoDal();
        CategorieInfoUI categorieInfoUI = new CategorieInfoUI();


        public void BehandelingToevoegen(BehandelingsInfoUI behandelingUI, CategorieInfoUI categorieInfoUI)
        {
            CategorieInfoDal categorieInfoDal = new CategorieInfoDal(categorieInfoUI.categorieId, categorieInfoUI.categorienaam);

            behandelinginfoDal = new BehandelingInfoDal(behandelinginfoDal.behandelingId, behandelingUI.omschrijving, behandelingUI.bedrag, categorieInfoDal);
            BehandelingCollectieDAL.VoegBehandelingToe(behandelinginfoDal);
        }
        public void BehandelingVerwijderen(int behandelingId)
        {
            behandelinginfoDal = new BehandelingInfoDal(behandelingId);
            BehandelingCollectieDAL.VerwijderBehandeling(behandelingId);
        }
        public List<BehandelingsInfoUI> AlleBehandelingenOphalen() 
        {
            List<BehandelingsInfoUI> lijstbehandeling = new List<BehandelingsInfoUI>();

            foreach (var bhInfo in BehandelingCollectieDAL.HaalBehandelingenOp())
            {
                CategorieInfoUI categorieInfoUI = new CategorieInfoUI(bhInfo.CategorieinfoDal.categorieId, bhInfo.CategorieinfoDal.categorienaam);

                BehandelingsInfoUI behandelingUI = new BehandelingsInfoUI(bhInfo.behandelingId,bhInfo.omschrijving, bhInfo.bedrag, categorieInfoUI);
                lijstbehandeling.Add(behandelingUI);
            }
            return lijstbehandeling; 
        }
        public List<BehandelingsInfoUI> AlleBehandelingenVoorCategorie(int categoryid)
        {
            List<BehandelingsInfoUI> behandelingMannen = new List<BehandelingsInfoUI>();

            foreach (var bhInfo in BehandelingCollectieDAL.GeefAlleBehandelingVoorCategorie(categoryid))
            {                
                    BehandelingsInfoUI behandelingUI = new BehandelingsInfoUI(bhInfo.behandelingId, bhInfo.omschrijving, bhInfo.bedrag);
                    behandelingMannen.Add(behandelingUI);
            }
            return behandelingMannen;
        }

        public BehandelingsInfoUI HaalBehandelingIdOp(int id)
        {
            BehandelingCollectieDAL.BehandelingIdOphalen(id);
            BehandelingsInfoUI behandelingsInfoUI = new BehandelingsInfoUI(id);

            if (id == 0)
            {
                throw new NotImplementedException();
            }
            else
            {
                return behandelingsInfoUI;
            }
        }
    }
}
