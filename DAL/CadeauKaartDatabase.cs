using System.Data.SqlClient;
using InterfaceDAL;

namespace DAL
{
    public class CadeauKaartDatabase : ICadeauKaartDal
    {
        private SqlCommand cmd;
        private SqlDataReader reader;

        private SqlConnection conn = ConnectieDatabase.Connection;
        public void UpdateCadeauKaart(CadeauKaartInfoDal cadeauKaartInfoDal)
        {
            throw new System.NotImplementedException();
        }
    }
}
