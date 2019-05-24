using System;
using InterfaceDAL;
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
        public List<WerknemerInfoDal> werknemers { get; private set; } = new List<WerknemerInfoDal>();

        public void VoegProductToe(ProductInfoDal productInfo)
        {
            KapperszaakInfoDal kapperszaak = new KapperszaakInfoDal();
            string query = "INSERT INTO Product (KapperszaakId, Titel, Omschrijving, Image) VALUES(@KapperszaakId, @Titel, @Omschrijving, @Image)";
            conn.Open();

            using (cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@KapperszaakId", kapperszaak.Id);
                cmd.Parameters.AddWithValue("@Titel", productInfo.Titel);
                cmd.Parameters.AddWithValue("@Omschrijving", productInfo.Omschrijving);
                cmd.Parameters.AddWithValue("@Image", productInfo.Image);
            }
            cmd.ExecuteNonQuery();
        }
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

        public int GeefProductId(int id)
        {
            string query = "Select * FROM Product WHERE ProductId= ProductId";

            conn.Open();
            cmd = new SqlCommand(query, conn);

            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                }
            }
            conn.Close();

            return id;
        }
        public void VoegWerknemerToe(WerknemerInfoDal werknemerInfo)
        {
            throw new NotImplementedException();
        }
        public void Inloggen(AdminInfoDal adminInfoDal) // string emailadres, wachtwoord 
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
        public List<AfspraakInfoDal> HaalAfspraakOp()
        {
            return afspraken;
        }

        public List<CadeauKaartInfoDal> HaalCadeauKaartOp()
        {
            return cadeaukaarten;
        }
        public List<WerknemerInfoDal> HaalWerknemersOp()
        {
            return werknemers;
        }

        public List<ProductInfoDal> HaalProductenOp()
        {
            List<ProductInfoDal> productenlijst = new List<ProductInfoDal>();

            string query = "Select Titel, Omschrijving, Image FROM Product"; 

            conn.Open();

            cmd = new SqlCommand(query, conn);
            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    ProductInfoDal productInfoDal = new ProductInfoDal(reader.GetString(0), reader.GetString(1), reader.GetString(2));
                    productenlijst.Add(productInfoDal);
                }
            }
            return productenlijst;
        }
    }
}
