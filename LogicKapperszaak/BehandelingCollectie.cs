using InterfaceUI;
using System.Collections.Generic;
using FactoryDAL;
using InterfaceDAL;

namespace LogicKapperszaak
{
   public class BehandelingCollectie : IBehandelingCollectieUi
    {
        public IBehandelingCollectieDAL BehandelingCollectieDAL = DatabaseFactory.MemoryContext();

        public List<IBehandelingUi> lijstbehandeling { get; private set; } = new List<IBehandelingUi>();

        BehandelingInfoDal behandelinginfoDal;

        public void BehandelingToevoegen(IBehandelingUi behandeling, ICategorieUI categorieUi)
        {
            CategorieInfoDal categorieInfoDal = new CategorieInfoDal(categorieUi.CategorieId, categorieUi.Categorienaam);

            behandelinginfoDal = new BehandelingInfoDal(behandeling.Id,behandeling.Omschrijving, behandeling.Bedrag, categorieInfoDal);
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
                lijstbehandeling.Add(behandelingUi);
            }
            return lijstbehandeling; 
        }
        public List<IBehandelingUi> AlleBehandelingenVoorCategorie(string categorieNaam)
        {
            List<IBehandelingUi> alleBehandelingenVoorCategorie = new List<IBehandelingUi>();

            foreach (var bhInfo in BehandelingCollectieDAL.GeefAlleBehandelingVoorCategorie(categorieNaam))
            {
                IBehandelingUi behandelingUI = new Behandeling(bhInfo.Id, bhInfo.Omschrijving, bhInfo.Bedrag);
                alleBehandelingenVoorCategorie.Add(behandelingUI);
            }
            return alleBehandelingenVoorCategorie;
        }
    }
}
