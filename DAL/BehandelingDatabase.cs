using InterfaceDAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BehandelingDatabase : IBehandelingDAL, IBehandelingCollectieDAL
    {
        private SqlCommand cmd;
        private SqlDataReader reader;

        SqlConnection conn = ConnectieDatabase.Connection;

        public List<BehandelingInfo> lijstbehandeling = new List<BehandelingInfo>()
        {
            new BehandelingInfo("test", 12),
            new BehandelingInfo("test2", 14),
        };

        public void VoegBehandelingToe(BehandelingInfo behandelingsinfo)
        {
            lijstbehandeling.Add(behandelingsinfo);
        }

        public void VerwijderBehandeling(BehandelingInfo behandelingsinfo)
        {
            lijstbehandeling.Remove(behandelingsinfo);
        }

        public List<BehandelingInfo> HaalBehandelingenOp()
        {
            return lijstbehandeling;
        }

        public void UpdateBehandeling(BehandelingInfo behandelingsinfo)
        {
            throw new NotImplementedException();
        }

        
    }
}
