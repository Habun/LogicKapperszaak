

namespace InterfaceUI
{
   public interface ICadeauKaartUi
    {
        string Bestemd { get; }
        decimal Bedrag { get; }
        void UpdateCadeauKaart(ICadeauKaartUi cadeauKaart);
    }
}
