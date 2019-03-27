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

        public IBehandelingDAL behandelingDAL = DatabaseFactory.Behandelingdal();

        public BehandelingInfoDal behandelingsinfo = new BehandelingInfoDal();

        public Behandeling()
        {

        }
        public Behandeling(string Omschrijving, decimal Bedrag)
        {
            omschrijving = Omschrijving;
            bedrag = Bedrag;
        }

        public void UpdateBehandeling(BehandelingsInfoUI behandelingUI)
        {
            behandelingsinfo = new BehandelingInfoDal(behandelingUI.omschrijving, behandelingUI.bedrag);
            behandelingDAL.UpdateBehandeling(behandelingsinfo);
        }
    }
}
