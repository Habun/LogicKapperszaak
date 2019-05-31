using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
   public class ConnectieDatabase
   {
        private static readonly string DbConnString = "Data Source = mssql.fhict.local; Initial Catalog = dbi386308; Persist Security Info=True;User ID = dbi386308; Password=Sherekoerda72";
        public static SqlConnection Connection
        {
            get
            {
                SqlConnection conn = new SqlConnection(DbConnString);
                return conn;
            }
        }
    }
}
