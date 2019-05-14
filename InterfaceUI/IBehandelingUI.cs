using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUI
{
    public interface IBehandelingUI
    {
        void UpdateBehandeling(int BehandelingId, BehandelingsInfoUI behandeling, CategorieInfoUI categorieInfoUI);
        int BehandelingIDdoorGeven();
    }
}
