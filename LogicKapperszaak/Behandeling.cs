using InterfaceUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceDAL;
using FactoryDAL;

namespace LogicKapperszaak 
{
    public class Behandeling : IBehandelingUI
    {
        public string omschrijving { get; set; }
        public decimal bedrag { get; set; }

        Categorie categorie = new Categorie();

        public IBehandelingDAL behandelingDAL = DatabaseFactory.Behandelingdal();

        public BehandelingInfoDal behandelingsinfoDal = new BehandelingInfoDal();

        public CategorieInfoDal categorieInfoDal = new CategorieInfoDal();

        public Behandeling()
        {

        }
        public Behandeling(string Omschrijving, decimal Bedrag, Categorie categorieen)
        {
            omschrijving = Omschrijving;
            bedrag = Bedrag;
            categorie = categorieen;
        }

        public void UpdateBehandeling(BehandelingsInfoUI behandelingUI, CategorieInfoUI categorieInfoUI)
        {
            categorieInfoDal = new CategorieInfoDal(categorieInfoUI.categorieId, categorieInfoUI.categorienaam);

            behandelingsinfoDal = new BehandelingInfoDal(behandelingUI.omschrijving, behandelingUI.bedrag, categorieInfoDal);
            behandelingDAL.UpdateBehandeling(behandelingsinfoDal);
        }
    }
}
