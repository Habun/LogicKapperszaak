using System;
using System.Collections.Generic;



namespace InterfaceUI
{
   public interface IAfspraakUi
    {
        int AfspraakId { get; }
        string Opmerkingen { get; }
        DateTime Datetime { get; }
        void BehandelingToevoegenAanAfspraak(IBehandelingUi behandeling, int afspraakId);
        void BehandelingVerwijderenBijAfspraak(int behandelingId);
        decimal KostenVanBehandelingenOptellen();
        List<IBehandelingUi> AfspraakBehandelingenOphalen(int afspraakId);
    }
}
