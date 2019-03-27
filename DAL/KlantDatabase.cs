using InterfaceDAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KlantDatabase : IKlantDAL
    {
        private SqlCommand cmd;
        private SqlDataReader reader;

        SqlConnection conn = ConnectieDatabase.Connection;
        public void AfspraakReserveren()
        {
            throw new NotImplementedException();
        }
        public void CadeauKaartReserveren(CadeauKaartInfoDal cadeauKaartInfo)
        {
            throw new NotImplementedException();
        }
    }
}
