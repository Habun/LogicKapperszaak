using System;
using System.Collections.Generic;
using System.Linq;
using InterfaceDAL;


namespace DAL.Tests
{
    public class BehandelingContext : IBehandelingDAL, IBehandelingCollectieDAL
    {
        public List<BehandelingInfoDal> behandelingen { get;  set; } = new List<BehandelingInfoDal>()
        {
            new BehandelingInfoDal(1, "Scheren", 13, new CategorieInfoDal(1, "Mannen"))
        };

        public void VoegBehandelingToe(BehandelingInfoDal behandelingsinfo)
        {
            behandelingen.Add(behandelingsinfo);
        }

        List<BehandelingInfoDal> IBehandelingCollectieDAL.HaalBehandelingenOp()
        {
            return behandelingen;
        }

        List<BehandelingInfoDal> IBehandelingCollectieDAL.GeefAlleBehandelingVoorCategorie(string categorieNaam)
        {
            return behandelingen;
        }

        public void UpdateBehandeling(BehandelingInfoDal behandelingsinfo)
        {
            throw new NotImplementedException();
        }

        public void VerwijderBehandeling(int behandelingId)
        {
            throw new NotImplementedException();
        }
    }
}