using FactoryDAL;
using InterfaceDAL;
using InterfaceUI;
using System;

namespace LogicKapperszaak
{
    public class Behandeling : IBehandelingUi
    {
        public IBehandelingDAL behandelingDal = DatabaseFactory.Behandelingdal();

        public BehandelingInfoDal behandelingsinfoDal;

        public CategorieInfoDal categorieInfoDal;

        public void UpdateBehandeling(int behandelingId, BehandelingsInfoUI behandelingUI, CategorieInfoUI categorieUI)
        {
            categorieInfoDal = new CategorieInfoDal(categorieUI.CategorieId, categorieUI.Categorienaam);

            behandelingsinfoDal = new BehandelingInfoDal(behandelingId, behandelingUI.Omschrijving, behandelingUI.Bedrag, categorieInfoDal);
            behandelingDal.UpdateBehandeling(behandelingsinfoDal);
        }
        public int BehandelingIDdoorGeven()
        {
            if (behandelingDal.GeefBehandelingIDdoor() == 0)
            {
                throw new ArgumentException($"Geen behandelingId gevonden.");
            }
            return behandelingDal.GeefBehandelingIDdoor();
        }
    }
}
