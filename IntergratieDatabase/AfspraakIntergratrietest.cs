using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceDAL;

namespace IntergratieDatabase
{
    public class AfspraakIntergratrietest : IAfspraakDAL
    {
        private SqlCommand cmd;
        private SqlDataReader reader;

        private SqlConnection conn = TestDatabaseConnectie.ConnectieIntergratie;


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

            conn.Close();
        }

        public void VerwijderBehandeling(int behandelingId)
        {
            throw new NotImplementedException();
        }
        public List<BehandelingInfoDal> GekozenBehandelingenOphalen(int afspraakId)
        {
            List<BehandelingInfoDal> gekozenBehandelingenOphalen = new List<BehandelingInfoDal>();

            string query = "Select AfspraakBehandeling.BehandelingId, Behandeling.Omschrijving, Behandeling.Bedrag from AfspraakBehandeling " +
                           "Inner join Behandeling on AfspraakBehandeling.BehandelingId = Behandeling.BehandelingId " +
                           "Where AfspraakId = @AfspraakId"; 
            conn.Open();
            cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@AfspraakId", afspraakId);

            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    BehandelingInfoDal behandelingInfoDal = new BehandelingInfoDal(reader.GetInt32(0), reader.GetString(1), reader.GetDecimal(2));
                    gekozenBehandelingenOphalen.Add(behandelingInfoDal);
                }
            }
            conn.Close();
            return gekozenBehandelingenOphalen;
        }
    }
}
