using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUI
{
   public interface IKlantUI
    {
        void CadeauKaartReserveren(KlantInfoUI klantInfoUI, CadeauKaartInfoUI cadeauKaartInfoUI);
        void AfspraakReserveren();
    }
}
