using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceDAL;

namespace DAL
{
   public class AfspraakDatabase : IAfspraakDAL
    {
        private SqlCommand cmd;
        private SqlDataReader reader;

        private SqlConnection conn = ConnectieDatabase.Connection;

        public void VoegBehandelingToeAanAfspraak(BehandelingInfoDal behandelingInfo, int afspraakId)
        {
            string query = "INSERT INTO AfspraakBehandeling (AfspraakId, BehandelingId) VALUES(@AfspraakId, @BehandelingId)";
            conn.Open();

            using (cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@AfspraakId", afspraakId);
                cmd.Parameters.AddWithValue("@BehandelingId", behandelingInfo.Id);
            }
            cmd.ExecuteNonQuery();
        }

        public void VerwijderBehandeling(int behandelingId)
        {
            throw new NotImplementedException();
        }

        public List<BehandelingInfoDal> GekozenBehandelingenOphalen(int afspraakId)
        {
            throw new NotImplementedException();
        }
    }
}
