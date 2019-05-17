

namespace InterfaceDAL
{
    public struct AdminInfoDal
    {
        public string Emailadres { get;}
        public string Wachtwoord { get; }

        public AdminInfoDal(string emailadres, string wachtwoord)
        {
            Emailadres = emailadres;
            Wachtwoord = wachtwoord;
        }
    }
}
