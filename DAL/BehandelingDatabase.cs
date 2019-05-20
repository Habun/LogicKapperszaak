using InterfaceDAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class BehandelingDatabase : IBehandelingDAL, IBehandelingCollectieDAL
    {
        private SqlCommand cmd;
        private SqlDataReader reader;

        SqlConnection conn = ConnectieDatabase.Connection;
        BehandelingInfoDal behandelingInfo;

        public void VoegBehandelingToe(BehandelingInfoDal behandelingsinfo)
        {
            string query = "INSERT INTO Behandeling (CategorieId, Omschrijving, Bedrag) VALUES(@CategorieId, @Omschrijving, @Bedrag)";
            conn.Open();

            using (cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@CategorieId", behandelingsinfo.categorieinfoDal.CategorieId);
                cmd.Parameters.AddWithValue("@Omschrijving", behandelingsinfo.Omschrijving);
                cmd.Parameters.AddWithValue("@Bedrag", behandelingsinfo.Bedrag);
            }
            cmd.ExecuteNonQuery();
        }

        public void VerwijderBehandeling(int behandelingId)
        {
            string query = "Delete FROM Behandeling Where BehandelingId = @BehandelingsId ";
            conn.Open();

            using (cmd = new SqlCommand(query, conn))
            {
              cmd.Parameters.AddWithValue("@BehandelingsId", behandelingId);
            }
            cmd.ExecuteNonQuery();
        }

        public List<BehandelingInfoDal> HaalBehandelingenOp()
        {
            List<BehandelingInfoDal> behandelingen = new List<BehandelingInfoDal>();

            string query = "Select Categorie.CategorieId, Behandeling.BehandelingId , Omschrijving, Bedrag, Categorie.Categorienaam FROM Behandeling INNER JOIN Categorie on Behandeling.CategorieId = Categorie.CategorieId ;";
            
            conn.Open();
            cmd = new SqlCommand(query, conn);

            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    CategorieInfoDal categorieInfoDal = new CategorieInfoDal(reader.GetInt32(0), reader.GetString(4));
                    BehandelingInfoDal behandelingInfo = new BehandelingInfoDal(reader.GetInt32(1),reader.GetString(2), reader.GetDecimal(3), categorieInfoDal);
                    behandelingen.Add(behandelingInfo);
                }
            }
            return behandelingen;
        }
        public List<BehandelingInfoDal> GeefAlleBehandelingVoorCategorie(string categorieNaam)
        {
            List<BehandelingInfoDal> behandelingVoorCategorie = new List<BehandelingInfoDal>();

            string query = "Select Behandeling.BehandelingId, Behandeling.Omschrijving, Behandeling.Bedrag FROM Behandeling INNER JOIN Categorie on Categorie.CategorieId = Behandeling.CategorieId Where Categorie.Categorienaam =@CategorieNaam ";

            conn.Open();
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@CategorieNaam", categorieNaam);

            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    BehandelingInfoDal behandelingInfo = new BehandelingInfoDal(reader.GetInt32(0), reader.GetString(1), reader.GetDecimal(2));
                    behandelingVoorCategorie.Add(behandelingInfo);
                }
            }
            return behandelingVoorCategorie;
        }

        public void UpdateBehandeling(BehandelingInfoDal behandelingsinfo)
        {
            throw new NotImplementedException();
        }

        public int GeefBehandelingIDdoor()
        {
            int behandelingId = behandelingInfo.BehandelingId;

            string query = "Select * FROM Behandeling WHERE BehandelingId= BehandelingId";

            conn.Open();
            cmd = new SqlCommand(query, conn);

            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    behandelingId = reader.GetInt32(0);
                }
            }
            conn.Close();

            return behandelingId;
        }
    }
}