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
        void VoegProductToe(ProductInfoUI productInfoUI);
        void VerwijderProduct(ProductInfoUI productInfoUI);
        List<ProductInfoUI> AlleProductenOphalen();
        List<AfspraakInfoUI> AlleAfsprakenOphalen();
        List<CadeauKaartInfoUI> AlleCadeauKaartenOphalen();
    }
}
