using System.Collections.Generic;

namespace InterfaceUI
{
   public interface IKapperszaakUi
   {
        int Id { get; }
        string Naam { get; }
        void Inloggen(string emailadres, string wachtwoord);
        void VoegProductToe(IProductUi product);
        void ProductVerwijderen(int productId);
        int ProductIdDoorGeven(int id);
        void VoegWerknemerToe(IWerknemerUi werknemer);
        List<IProductUi> AlleProductenOphalen();
        List<IAfspraakUi> AlleAfsprakenOphalen();
        List<ICadeauKaartUi> AlleCadeauKaartenOphalen();
        List<IWerknemerUi> AlleWerknemersOphalen();
   }
}
