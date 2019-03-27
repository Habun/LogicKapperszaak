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


        public void VoegBehandelingToe(BehandelingInfoDal behandelingsinfo)
        {
            try
            {
                string query = "INSERT INTO Product (Omschrijving, Bedrag) VALUES(@Omschrijving, @Bedrag)";
                conn.Open();

                using (cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Omschrijving", behandelingsinfo.omschrijving);
                    cmd.Parameters.AddWithValue("@Bedrag", behandelingsinfo.bedrag);
                }
                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
                }
        }

        public void VerwijderBehandeling(BehandelingInfoDal behandelingsinfo)
        {
            throw new NotImplementedException();
        }

        public List<BehandelingInfoDal> HaalBehandelingenOp()
        {
            List<BehandelingInfoDal> behandelingen = new List<BehandelingInfoDal>();

            //  string query = "SELECT Categorie.Categorienaam, Behandeling.Omschrijving, Behandeling.Bedrag FROM Categorie " +
            //                 "INNER JOIN Behandeling ON Categorie.CategorieId = Behandeling.CategorieId";

            string query = "Select Behandeling.Omschrijving, Behandeling.Bedrag FROM Behandeling";
            conn.Open();
            cmd = new SqlCommand(query, conn);

            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    BehandelingInfoDal behandelingInfo = new BehandelingInfoDal(reader.GetString(0), reader.GetDecimal(1));
                    behandelingen.Add(behandelingInfo);
                }
                reader.Close();
            }
            conn.Close();

            return behandelingen;
        }

        public void UpdateBehandeling(BehandelingInfoDal behandelingsinfo)
        {
            throw new NotImplementedException();
        }
    }
}