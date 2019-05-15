using InterfaceDAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                cmd.Parameters.AddWithValue("@KapperszaakId", productInfo.kapperszaakdal.kapperszaakid);
                cmd.Parameters.AddWithValue("@Titel", productInfo.titel);
                cmd.Parameters.AddWithValue("@Omschrijving", productInfo.omschrijving);
                cmd.Parameters.AddWithValue("@Image", productInfo.image);
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

                cmd.Parameters.AddWithValue("@Emailadres", adminInfoDal.emailadres);
                cmd.Parameters.AddWithValue("@Wachtwoord", adminInfoDal.wachtwoord);

                using (reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        AdminInfoDal amInfoDal = new AdminInfoDal(reader.GetString(0), reader.GetString(1));
                    }
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
