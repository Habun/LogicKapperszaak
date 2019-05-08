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

        BehandelingInfoDal BehandelingInfoDalID;
        BehandelingInfoDal behandelingInfo;
        CategorieInfoDal categorieInfoDal;

        public void VoegBehandelingToe(BehandelingInfoDal behandelingsinfo)
        {
            try
            {
                string query = "INSERT INTO Behandeling (CategorieId, Omschrijving, Bedrag) VALUES(@CategorieId, @Omschrijving, @Bedrag)";
                conn.Open();

                using (cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CategorieId", behandelingsinfo.CategorieinfoDal.categorieId);
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
            string query = "Delete FROM Behandeling Where BehandelingId = @BehandelingsId ";
            conn.Open();

            using (cmd = new SqlCommand(query, conn))
            {
              cmd.Parameters.AddWithValue("@BehandelingsId", behandelingsinfo.behandelingId);
            }
            cmd.ExecuteNonQuery();
        }

        public List<BehandelingInfoDal> HaalBehandelingenOp()
        {
            List<BehandelingInfoDal> behandelingen = new List<BehandelingInfoDal>();

            string query = "Select Categorie.CategorieId, Omschrijving, Bedrag, Categorie.Categorienaam FROM Behandeling INNER JOIN Categorie on Behandeling.CategorieId = Categorie.CategorieId ;";
            
            conn.Open();
            cmd = new SqlCommand(query, conn);

            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    categorieInfoDal = new CategorieInfoDal(reader.GetInt32(0), reader.GetString(3));
                    behandelingInfo = new BehandelingInfoDal(reader.GetInt32(0),reader.GetString(1), reader.GetDecimal(2), categorieInfoDal);
                    behandelingen.Add(behandelingInfo);
                }
            }
            return behandelingen;
        }
        public List<BehandelingInfoDal> GeefAlleBehandelingVoorCategorie(int categoryid)
        {
            List<BehandelingInfoDal> behandelingMannen = new List<BehandelingInfoDal>();

            string query = "Select Behandeling.BehandelingId, Behandeling.Omschrijving, Behandeling.Bedrag FROM Behandeling INNER JOIN Categorie on Categorie.CategorieId = Behandeling.CategorieId Where Behandeling.CategorieId =@CategoryId ";

            conn.Open();
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@CategoryId", categoryid);

            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    categorieInfoDal = new CategorieInfoDal(reader.GetInt32(0), reader.GetString(1));
                    behandelingInfo = new BehandelingInfoDal(reader.GetInt32(0), reader.GetString(1), reader.GetDecimal(2), categorieInfoDal);
                    behandelingMannen.Add(behandelingInfo);
                }
            }
            return behandelingMannen;
        }

        public void UpdateBehandeling(BehandelingInfoDal behandelingsinfo)
        {
            throw new NotImplementedException();
        }
    }
}