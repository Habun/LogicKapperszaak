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

        BehandelingInfoDal behandelinginfo = new BehandelingInfoDal();

        public void BehandelingToevoegen(BehandelingsInfoUI behandelingUI)
        {
            behandelinginfo = new BehandelingInfoDal(behandelingUI.omschrijving, behandelingUI.bedrag);
            BehandelingCollectieDAL.VoegBehandelingToe(behandelinginfo);
        }

        public void BehandelingVerwijderen(BehandelingsInfoUI behandelingUI)
        {
            behandelinginfo = new BehandelingInfoDal(behandelingUI.omschrijving, behandelingUI.bedrag);
            BehandelingCollectieDAL.VerwijderBehandeling(behandelinginfo);
        }

        public List<BehandelingsInfoUI> AlleBehandelingenOphalen() 
        {
            List<BehandelingsInfoUI> lijstbehandeling = new List<BehandelingsInfoUI>();

            foreach (var bhInfo in BehandelingCollectieDAL.HaalBehandelingenOp())
            {
                BehandelingsInfoUI behandelingUI = new BehandelingsInfoUI(bhInfo.omschrijving, bhInfo.bedrag);
                lijstbehandeling.Add(behandelingUI);
            }
            return lijstbehandeling; 
        }
    }
}
