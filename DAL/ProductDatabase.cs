using InterfaceDAL;
using System.Data.SqlClient;

namespace DAL
{
    public class ProductDatabase : IProductDAL
    {
        private SqlCommand cmd;
        private SqlDataReader reader;

        SqlConnection conn = ConnectieDatabase.Connection;
        private ProductInfoDal productInfodal;
        public void UpdateProduct(ProductInfoDal productInfo)
        {
            try
            {
                string query = "Update dbo.Product SET Titel =@titel, Omschrijving =@omschrijving, Image =@image Where Product.ProductId =@ProductId";
                conn.Open();

                using (cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@titel", productInfo.Titel);
                    cmd.Parameters.AddWithValue("@omschrijving", productInfo.Omschrijving);
                    cmd.Parameters.AddWithValue("@image", productInfo.Image);
                }
                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }

        public int GeefProductId()
        {
            int productId = productInfodal.ProductId;

            string query = "Select * FROM Product WHERE ProductId= ProductId";

            conn.Open();
            cmd = new SqlCommand(query, conn);

            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    productId = reader.GetInt32(0);
                }
            }
            conn.Close();

            return productId;
        }
    }
}
