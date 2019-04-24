using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using InterfaceDAL;

namespace DAL
{
   public class CategorieDatabase : ICategorieCollectionDAL
    {
        private SqlCommand cmd;
        private SqlDataReader reader;

        SqlConnection conn = ConnectieDatabase.Connection;

        public void VoegCategorieToe(CategorieInfoDal categorieinfoDal)
        {
        }

        public void VerwijderCategorie(CategorieInfoDal categorieinfoDal)
        {
        }

        public List<CategorieInfoDal> HaalBehandelingenOp()
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
                reader.Close();
            }
            conn.Close();

            return categorieen;
        }

    }
}
