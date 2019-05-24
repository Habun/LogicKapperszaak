using System;
using System.Collections.Generic;
using InterfaceDAL;


namespace DAL.Tests
{
    public class MemoryContext : IBehandelingDAL, IBehandelingCollectieDAL
    {
        public List<BehandelingInfoDal> behandelingen { get; private set; } = new List<BehandelingInfoDal>()
        {
            new BehandelingInfoDal(1, "Knippen", 13, new CategorieInfoDal(1, "Mannen"))
        };

        public void VoegBehandelingToe(BehandelingInfoDal behandelingsinfo)
        {
            behandelingen.Add(behandelingsinfo);
        }


        public void UpdateBehandeling(BehandelingInfoDal behandelingsinfo)
        {
            behandelingen.Add(behandelingsinfo);
        }

        public void VerwijderBehandeling(int behandelingId)
        {
            throw new NotImplementedException();
        }

        List<BehandelingInfoDal> IBehandelingCollectieDAL.HaalBehandelingenOp()
        {
            return behandelingen;
        }

        List<BehandelingInfoDal> IBehandelingCollectieDAL.GeefAlleBehandelingVoorCategorie(string categorieNaam)
        {
            return behandelingen;
        }
    }
}