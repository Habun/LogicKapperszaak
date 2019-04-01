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
                string query = "INSERT INTO Behandeling (Omschrijving, Bedrag) VALUES(@Omschrijving, @Bedrag)";
                conn.Open();

                using (cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Omschrijving", behandelingsinfo.omschrijving);
                    cmd.Parameters.AddWithValue("@Bedrag", behandelingsinfo.bedrag);
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                var test = e;
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

            string query = "Select Omschrijving, Bedrag, Behandeling.CategorieId, Categorie.Categorienaam FROM Behandeling INNER JOIN Categorie on Behandeling.CategorieId = Categorie.CategorieId;";
            
            conn.Open();
            cmd = new SqlCommand(query, conn);

            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    CategorieInfoDal categorieInfoDal = new CategorieInfoDal(reader.GetInt32(2), reader.GetString(3));
                    BehandelingInfoDal behandelingInfo = new BehandelingInfoDal(reader.GetString(0), reader.GetDecimal(1), categorieInfoDal);
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