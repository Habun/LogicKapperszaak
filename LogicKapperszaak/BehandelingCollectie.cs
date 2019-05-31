using System;
using System.Collections.Generic;
using FactoryDAL;
using InterfaceDAL;
using InterfaceUI;

namespace LogicKapperszaak
{
   public class BehandelingCollectie : IBehandelingCollectieUi
    {
        public IBehandelingCollectieDAL BehandelingCollectieDAL = DatabaseFactory.BehandelingCollectieDAL();

        public List<IBehandelingUi> Lijstbehandeling { get;} = new List<IBehandelingUi>();

        public void BehandelingToevoegen(IBehandelingUi behandeling, ICategorieUI categorieUi)
        {
            CategorieInfoDal categorieInfoDal = new CategorieInfoDal(categorieUi.CategorieId, categorieUi.Categorienaam);

            BehandelingInfoDal behandelinginfoDal = new BehandelingInfoDal(behandeling.Id,behandeling.Omschrijving, behandeling.Bedrag, categorieInfoDal);
            BehandelingCollectieDAL.VoegBehandelingToe(behandelinginfoDal);
        }

        public void BehandelingVerwijderen(int behandelingId)
        {
            BehandelingCollectieDAL.VerwijderBehandeling(behandelingId);
        }

        public List<IBehandelingUi> AlleBehandelingenOphalen() 
        {
            foreach (var bhInfo in BehandelingCollectieDAL.HaalBehandelingenOp())
            {
                ICategorieUI categorie = new Categorie(bhInfo.categorieinfoDal.CategorieId, bhInfo.categorieinfoDal.Categorienaam);

                IBehandelingUi behandelingUi = new Behandeling(bhInfo.Id, bhInfo.Omschrijving, bhInfo.Bedrag, categorie);
                Lijstbehandeling.Add(behandelingUi);
            }
            return Lijstbehandeling; 
        }
        public List<IBehandelingUi> AlleBehandelingenVoorCategorie(string categorieNaam)
        {
            List<IBehandelingUi> AlleBehandelingenVoorCategorie = new List<IBehandelingUi>();

            foreach (var bhInfo in BehandelingCollectieDAL.GeefAlleBehandelingVoorCategorie(categorieNaam))
            {
                IBehandelingUi behandelingUI = new Behandeling(bhInfo.Id, bhInfo.Omschrijving, bhInfo.Bedrag);
                AlleBehandelingenVoorCategorie.Add(behandelingUI);
            }
            return AlleBehandelingenVoorCategorie;
        }
    }
}
