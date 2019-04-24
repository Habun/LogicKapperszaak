using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUI
{
    public interface IBehandelingUI
    {
        void UpdateBehandeling(BehandelingsInfoUI behandeling, CategorieInfoUI categorieInfoUI);
      //  BehandelingsInfoUI HaalIDop(int id);
    }
}
