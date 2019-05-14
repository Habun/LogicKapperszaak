using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDAL
{
   public interface IBehandelingDAL
    {
        void UpdateBehandeling(BehandelingInfoDal behandelingsinfo);
        int GeefBehandelingIDdoor();
    }
}
