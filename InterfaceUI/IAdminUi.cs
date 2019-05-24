using System.Collections.Generic;

namespace InterfaceUI
{
   public interface IAdminUi
    {
        string Emailadres { get; }
        string Wachtwoord { get; }

        List<IKapperszaakUi> AlleKapperZakenOphalen();
    }
}
