using System.Collections.Generic;
using System.Data.SqlClient;
using InterfaceDAL;

namespace DAL
{
    public class AdminDatabase : IAdminDAL
    {
        private SqlCommand cmd;
        private SqlDataReader reader;

        SqlConnection conn = ConnectieDatabase.Connection;
        public List<KapperszaakInfoDal> AlleKappersZakenOphalen()
        {
            List<KapperszaakInfoDal> kapperszaken = new List<KapperszaakInfoDal>();

            string query = "Select * from Kapperszaak";
            conn.Open();
            cmd = new SqlCommand(query, conn);

            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    KapperszaakInfoDal kapperszaak = new KapperszaakInfoDal(reader.GetInt32(0), reader.GetString(1));
                    kapperszaken.Add(kapperszaak);
                }
            }
            return kapperszaken;
        }
    }
}
