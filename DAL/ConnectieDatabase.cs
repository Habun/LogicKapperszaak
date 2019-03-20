using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class ConnectieDatabase
    {
        private static readonly string connectionString = "Data Source = mssql.fhict.local; Initial Catalog = dbi386308; Persist Security Info=True;User ID = dbi386308; Password=Sherekoerda72";
        public static SqlConnection Connection
        {
            get
            {
                SqlConnection conn = new SqlConnection(connectionString);
                return conn;
            }
        }
    }
}
