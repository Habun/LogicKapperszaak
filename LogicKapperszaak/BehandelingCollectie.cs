using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicKapperszaak
{
   public class BehandelingCollectie
    {
        public List<Behandeling> behandelinglijst { get; private set; } = new List<Behandeling>();
        public void BehandelingToevoegen(Behandeling behandeling)
        {
        }

        public void BehandelingVerwijderen(Behandeling behandeling)
        {
        }

        public List<Behandeling> AlleBehandelingenOphalen() //moet behandeling zijn
        {
            throw new NotImplementedException();
        }
    }
}
