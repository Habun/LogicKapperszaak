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
            try
            {
                string query = "Delete FROM Behandeling Where BehandelingId = @BehandelingsId ";
                conn.Open();

                using (cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@BehandelingsId", behandelingsinfo.behandelingId);
                }
                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }

        public List<BehandelingInfoDal> HaalBehandelingenOp()
        {
            List<BehandelingInfoDal> behandelingen = new List<BehandelingInfoDal>();

            string query = "Select Categorie.CategorieId, Omschrijving, Bedrag, Categorie.Categorienaam FROM Behandeling INNER JOIN Categorie on Behandeling.CategorieId = Categorie.CategorieId;";
            
            conn.Open();
            cmd = new SqlCommand(query, conn);

            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    CategorieInfoDal categorieInfoDal = new CategorieInfoDal(reader.GetInt32(0), reader.GetString(3));
                    BehandelingInfoDal behandelingInfo = new BehandelingInfoDal(reader.GetInt32(0),reader.GetString(1), reader.GetDecimal(2), categorieInfoDal);
                    behandelingen.Add(behandelingInfo);
                }
                reader.Close();
            }
            conn.Close();

            return behandelingen;
        }
        public List<BehandelingInfoDal> HaalAlleMannenBehandelingenOp()
        {
            List<BehandelingInfoDal> behandelingMannen = new List<BehandelingInfoDal>();

            string query = "Select Behandeling.BehandelingId, Behandeling.Omschrijving, Behandeling.Bedrag FROM Behandeling INNER JOIN Categorie on Categorie.CategorieId = Behandeling.CategorieId Where Behandeling.CategorieId = 1";

            conn.Open();
            cmd = new SqlCommand(query, conn);

            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    BehandelingInfoDal behandelingInfo = new BehandelingInfoDal(reader.GetInt32(0), reader.GetString(1), reader.GetDecimal(2));
                    behandelingMannen.Add(behandelingInfo);
                }
                reader.Close();
            }
            conn.Close();

            return behandelingMannen;
        }

        public void UpdateBehandeling(BehandelingInfoDal behandelingsinfo)
        {
            throw new NotImplementedException();
        }

        //public BehandelingInfoDal HaalIDop(int id)
        //{
        //    BehandelingInfoDal behandelingInfo;
        //    string query = "Select * FROM Behandeling WHERE BehandelingId=@BehandelingId";

        //    conn.Open();
        //    cmd = new SqlCommand(query, conn);

        //    using (reader = cmd.ExecuteReader())
        //    {
        //        cmd.Parameters.AddWithValue("@BehandelingId", id);
        //        while (reader.Read())
        //        {
        //            behandelingInfo = new BehandelingInfoDal(reader.GetInt32(0), reader.GetString(1), reader.GetDecimal(2));
        //        }
        //        reader.Close();
        //    }
        //    conn.Close();

        //    return behandelingInfo;
        //}
    }
}