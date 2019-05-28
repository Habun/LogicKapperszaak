using System;
using System.Collections.Generic;



namespace InterfaceUI
{
   public interface IAfspraakUi
    {
        string Opmerkingen { get; }
        DateTime datetime { get; }
        void BehandelingToevoegenAanAfspraak(IBehandelingUi behandeling);
        void BehandelingVerwijderenBijAfspraak();
        List<IBehandelingUi> AfspraakBehandelingenOphalen();
        void KostenVanBehandelingenOptellen();
    }
}
