using InterfaceDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace FactoryDAL
{
    public class DatabaseFactory
    {
        public static IBehandelingDAL Behandelingdal()
        {
            return new BehandelingDatabase();
        }
        public static IBehandelingCollectieDAL BehandelingCollectieDAL()
        {
            return new BehandelingDatabase();
        }
    }
}
