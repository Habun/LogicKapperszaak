using FactoryDAL;
using InterfaceDAL;
using InterfaceUI;
using System;

namespace LogicKapperszaak
{
    public class Behandeling : IBehandelingUI
    {
        public int behandelingId { get; set; }
        public string omschrijving { get; set; }
        public decimal bedrag { get; set; }

        Categorie categorie = new Categorie();

        public IBehandelingDAL behandelingDAL = DatabaseFactory.Behandelingdal();

        public BehandelingInfoDal behandelingsinfoDal = new BehandelingInfoDal();

        public CategorieInfoDal categorieInfoDal = new CategorieInfoDal();

        public Behandeling()
        {

        }
        public Behandeling(int BehandelingId, string Omschrijving, decimal Bedrag, Categorie categorieen)
        {
            behandelingId = BehandelingId;
            omschrijving = Omschrijving;
            bedrag = Bedrag;
            categorie = categorieen;
        }

        public void UpdateBehandeling(int BehandelingId, BehandelingsInfoUI BehandelingUI, CategorieInfoUI CategorieUI)
        {
            categorieInfoDal = new CategorieInfoDal(CategorieUI.categorieId, CategorieUI.categorienaam);

            behandelingsinfoDal = new BehandelingInfoDal(BehandelingId, BehandelingUI.omschrijving, BehandelingUI.bedrag, categorieInfoDal);
            behandelingDAL.UpdateBehandeling(behandelingsinfoDal);
        }
        public int BehandelingIDdoorGeven()
        {
            if (behandelingDAL.GeefBehandelingIDdoor() == 0)
            {
                throw new ArgumentException($"Geen behandelingId gevonden.");
            }
            else
            {
                return behandelingDAL.GeefBehandelingIDdoor();
            }
        }
    }
}
