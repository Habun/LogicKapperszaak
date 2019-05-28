using System.Collections.Generic;

namespace InterfaceUI
{
   public interface IKapperszaakUi
   {
        int Id { get; }
        string Naam { get; }
        void Inloggen(string emailadres, string wachtwoord);
        void VoegProductToe(IProductUi product, int kapperszaakId);
        void ProductVerwijderen(int productId);
        void VoegWerknemerToe(IWerknemerUi werknemer);
        List<IProductUi> AlleProductenOphalen();
        List<IAfspraakUi> AlleAfsprakenOphalen();
        List<ICadeauKaartUi> AlleCadeauKaartenOphalen();
        List<IWerknemerUi> AlleWerknemersOphalen();
   }
}
