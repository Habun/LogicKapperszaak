using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUI
{
   public interface IKapperszaakUI
    {
        void Inloggen(AdminInfoUI adminInfoUI);
        void VoegProductToe(ProductInfoUI productInfoUI, KapperszaakinfoUI kappersinfoUI);
        void VerwijderProduct(ProductInfoUI productInfoUI, KapperszaakinfoUI kappersinfoUI);
        List<ProductInfoUI> AlleProductenOphalen();
        List<AfspraakInfoUI> AlleAfsprakenOphalen();
        List<CadeauKaartInfoUI> AlleCadeauKaartenOphalen();
    }
}
