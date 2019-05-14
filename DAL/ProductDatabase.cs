using InterfaceDAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductDatabase : IProductDAL
    {
        private SqlCommand cmd;
        private SqlDataReader reader;

        SqlConnection conn = ConnectieDatabase.Connection;
        ProductInfoDal productInfoDal;
        public void UpdateProduct(ProductInfoDal productInfo)
        {
            try
            {
                string query = "Update dbo.Product SET Titel =@titel, Omschrijving =@omschrijving, Image =@image Where Product.ProductId =@ProductId";
                conn.Open();

                using (cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@titel", productInfo.titel);
                    cmd.Parameters.AddWithValue("@omschrijving", productInfo.omschrijving);
                    cmd.Parameters.AddWithValue("@image", productInfo.image);
                }
                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }
        public ProductInfoDal ProductIdOphalen(int productId)
        {
            string query = "Select * FROM Product WHERE ProductId=@ProductId";

            conn.Open();
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ProductId", productId);

            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    productInfoDal = new ProductInfoDal(reader.GetInt32(0));
                }
            }
            conn.Close();
            return productInfoDal;
        }

    }
}
