

namespace InterfaceUI
{
   public interface IKlantUi
    {
        string Naam { get; }
        int Telefoonnummer { get; }
        string Emailadres { get; }
        void CadeauKaartReserveren(ICadeauKaartUi cadeauKaart);
        void AfspraakReserveren();
    }
}
