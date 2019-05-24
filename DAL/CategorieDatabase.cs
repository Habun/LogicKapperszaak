using System.Collections.Generic;
using System.Data.SqlClient;
using InterfaceDAL;

namespace DAL
{
   public class CategorieDatabase : ICategorieCollectionDAL
    {
        private SqlCommand cmd;
        private SqlDataReader reader;

        SqlConnection conn = ConnectieDatabase.Connection;
        CategorieInfoDal categorieInfoDal;

        public void VoegCategorieToe(CategorieInfoDal categorieinfoDal)
        {
        }

        public void VerwijderCategorie(CategorieInfoDal categorieinfoDal)
        {
        }

        public List<CategorieInfoDal> HaalCategorieOp()
        {
            List<CategorieInfoDal> categorieen = new List<CategorieInfoDal>();
            string query = "Select * From Categorie";

            conn.Open();
            cmd = new SqlCommand(query, conn);

            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    CategorieInfoDal categorieInfoDal = new CategorieInfoDal(reader.GetInt32(0), reader.GetString(1));
                    categorieen.Add(categorieInfoDal);
                }
            }
            return categorieen;
        }
        public CategorieInfoDal CategoryIdOphalen(int id)
        {
            string query = "Select * FROM Categorie WHERE CategorieId=@CategorieID";

            conn.Open();
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@CategorieID", id);

            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    categorieInfoDal = new CategorieInfoDal(reader.GetInt32(0), reader.GetString(1));
                }
            }
            return categorieInfoDal;
        }
    }
}
