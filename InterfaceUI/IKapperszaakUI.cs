using System.Collections.Generic;

namespace InterfaceUI
{
   public interface IKapperszaakUI
    {
        void Inloggen(AdminInfoUI adminInfoUI);
        void VoegProductToe(ProductInfoUI productInfoUI, KapperszaakinfoUI kappersinfoUI);
        void ProductVerwijderen(int productId);
        List<ProductInfoUI> AlleProductenOphalen();
        List<AfspraakInfoUI> AlleAfsprakenOphalen();
        List<CadeauKaartInfoUI> AlleCadeauKaartenOphalen();
    }
}
