using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntergratieDatabase
{
   public class TestDatabaseConnectie
    {
        private static readonly string TestDbConnString = @"Data Source = LAPTOP-0IRU71CR\SQLEXPRESS ; Initial Catalog = HairSalonDatabase; Integrated Security=SSPI;";

        public static SqlConnection ConnectieIntergratie
        {
            get
            {
                SqlConnection conn = new SqlConnection(TestDbConnString);
                return conn;
            }
        }
    }
}
