using System;
using InterfaceDAL;
using System.Data.SqlClient;

namespace DAL
{
    public class ProductDatabase : IProductDAL
    {
        private SqlCommand cmd;
        private SqlDataReader reader;

      //  SqlConnection conn = ConnectieDatabase.Connection;
        public void UpdateProduct(ProductInfoDal productInfo)
        {
            throw new NotImplementedException();
        }
    }
}
