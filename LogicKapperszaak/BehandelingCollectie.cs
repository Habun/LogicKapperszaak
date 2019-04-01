﻿using InterfaceUI;
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

        CategorieInfoDal categorieInfoDal = new CategorieInfoDal();

        CategorieInfoUI categorieInfoUI = new CategorieInfoUI();

        public void BehandelingToevoegen(BehandelingsInfoUI behandelingUI)
        {
            categorieInfoDal = new CategorieInfoDal(categorieInfoUI.categorieId, categorieInfoUI.categorienaam);

            behandelinginfo = new BehandelingInfoDal(behandelingUI.omschrijving, behandelingUI.bedrag, categorieInfoDal);
            BehandelingCollectieDAL.VoegBehandelingToe(behandelinginfo);
        }
        public void BehandelingVerwijderen(BehandelingsInfoUI behandelingUI)
        {
            categorieInfoDal = new CategorieInfoDal(categorieInfoUI.categorieId, categorieInfoUI.categorienaam);

            behandelinginfo = new BehandelingInfoDal(behandelingUI.omschrijving, behandelingUI.bedrag, categorieInfoDal);
            BehandelingCollectieDAL.VerwijderBehandeling(behandelinginfo);
        }
        public List<BehandelingsInfoUI> AlleBehandelingenOphalen() 
        {
            List<BehandelingsInfoUI> lijstbehandeling = new List<BehandelingsInfoUI>();

            foreach (var bhInfo in BehandelingCollectieDAL.HaalBehandelingenOp())
            {
                CategorieInfoUI categorieInfoUI = new CategorieInfoUI(bhInfo.CategorieinfoDal.categorieId, bhInfo.CategorieinfoDal.categorienaam);

                BehandelingsInfoUI behandelingUI = new BehandelingsInfoUI(bhInfo.omschrijving, bhInfo.bedrag, categorieInfoUI);
                lijstbehandeling.Add(behandelingUI);
            }
            return lijstbehandeling; 
        }
    }
}
