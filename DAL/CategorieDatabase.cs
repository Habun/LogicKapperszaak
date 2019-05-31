using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using InterfaceDAL;

namespace DAL
{
   public class CategorieDatabase : ICategorieCollectionDAL, ICategorieDAL
    {
        private SqlCommand cmd;
        private SqlDataReader reader;

        private SqlConnection conn = ConnectieDatabase.Connection;

        public void VoegCategorieToe(CategorieInfoDal categorieinfoDal)
        {
            throw new NotImplementedException();
        }

        public void VerwijderCategorie(int categorieId)
        {
            throw new NotImplementedException();
        }

        public void UpdateCategorie(CategorieInfoDal categorieInfoDal)
        {
            throw new NotImplementedException();
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
    }
}
