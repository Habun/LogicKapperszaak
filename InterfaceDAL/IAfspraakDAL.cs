using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDAL
{
   public interface IAfspraakDAL
   {
       void VoegBehandelingToeAanAfspraak(BehandelingInfoDal behandelingInfo, int afspraakId);
       void VerwijderBehandeling(int behandelingId);
       List<BehandelingInfoDal> GekozenBehandelingenOphalen(int afspraakId);
   }
}
