using System.Collections.Generic;


namespace InterfaceDAL
{
    public interface IBehandelingCollectieDAL
    {
        void VoegBehandelingToe(BehandelingInfoDal behandelingsinfo);
        void VerwijderBehandeling(int behandelingId);
        List<BehandelingInfoDal> HaalBehandelingenOp();
        List<BehandelingInfoDal> GeefAlleBehandelingVoorCategorie(int categoryid);
    }
}