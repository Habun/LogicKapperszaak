

namespace InterfaceUI
{
    public struct AdminInfoUI
    {
        public string Emailadres { get;}
        public string Wachtwoord { get;}

        public AdminInfoUI(string emailadres, string wachtwoord)
        {
            Emailadres = emailadres;
            Wachtwoord = wachtwoord;
        }
    }
}
