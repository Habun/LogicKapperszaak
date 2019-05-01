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
        void VerwijderBehandeling(BehandelingInfoDal behandelingsinfo);
        List<BehandelingInfoDal> HaalBehandelingenOp();
        List<BehandelingInfoDal> HaalAlleMannenBehandelingenOp();
    }
}
