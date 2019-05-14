using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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