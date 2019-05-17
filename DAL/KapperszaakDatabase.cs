﻿using InterfaceDAL;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class KapperszaakDatabase : IKapperszaakDAL
    {
        private SqlCommand cmd;
        private SqlDataReader reader;

        SqlConnection conn = ConnectieDatabase.Connection;

        public List<AfspraakInfoDal> afspraken { get; private set; } = new List<AfspraakInfoDal>();
        public List<CadeauKaartInfoDal> cadeaukaarten { get; private set; } = new List<CadeauKaartInfoDal>();

        public void VerwijderProduct(int productId)
        {
            string query = "Delete FROM Product Where ProductId = @ProductId ";
            conn.Open();

            using (cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@ProductId", productId);
            }
            cmd.ExecuteNonQuery();
        }

        public void VoegProductToe(ProductInfoDal productInfo)
        {
            string query = "INSERT INTO Product (KapperszaakId, Titel, Omschrijving, Image) VALUES(@KapperszaakId, @Titel, @Omschrijving, @Image)";
            conn.Open();

            using (cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@KapperszaakId", productInfo.kapperszaakdal.Kapperszaakid);
                cmd.Parameters.AddWithValue("@Titel", productInfo.Titel);
                cmd.Parameters.AddWithValue("@Omschrijving", productInfo.Omschrijving);
                cmd.Parameters.AddWithValue("@Image", productInfo.Image);
            }
            cmd.ExecuteNonQuery();
        }
        public void Inloggen(AdminInfoDal adminInfoDal)
        {
            try
            {
                string query = "Select * FROM Admin Where Emailadres =@Emailadres and Wachtwoord =@Wachtwoord ";
                conn.Open();
                cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Emailadres", adminInfoDal.Emailadres);
                cmd.Parameters.AddWithValue("@Wachtwoord", adminInfoDal.Wachtwoord);

                using (reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                       AdminInfoDal admin = new AdminInfoDal(reader.GetString(0), reader.GetString(1));
                    }
                }
                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();

            }
        }
        public List<AfspraakInfoDal> HaalAfspraakOp()
        {
            return afspraken;
        }

        public List<CadeauKaartInfoDal> HaalCadeauKaartOp()
        {
            return cadeaukaarten;
        }

        public List<ProductInfoDal> HaalProductenOp()
        {
            List<ProductInfoDal> productenlijst = new List<ProductInfoDal>();

            string query = "Select ProductId, KapperszaakId, Titel, Omschrijving, Image FROM Product"; 

            conn.Open();

            cmd = new SqlCommand(query, conn);
            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    KapperszaakInfoDal kapperszaakInfoDal = new KapperszaakInfoDal(reader.GetInt32(1), reader.GetString(2));
                    ProductInfoDal productInfoDal = new ProductInfoDal(kapperszaakInfoDal, reader.GetInt32(0), reader.GetString(2), reader.GetString(3), reader.GetString(4));
                    productenlijst.Add(productInfoDal);
                }
                reader.Close();
            }
            conn.Close();

            return productenlijst;
        }
    }
}
