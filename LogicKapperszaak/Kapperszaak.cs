using InterfaceDAL;
using InterfaceUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryDAL;

namespace LogicKapperszaak
{
   public class Kapperszaak : IKapperszaakUI
    {
        public string naam { get; set; }
        public List<ProductInfoUI> producten { get; private set; } = new List<ProductInfoUI>();
        public List<AfspraakInfoUI> afspraken { get; private set; } = new List<AfspraakInfoUI>();
        public List<CadeauKaartInfoUI> cadeaukaarten { get; private set; } = new List<CadeauKaartInfoUI>();

        IKapperszaakDAL kapperszaakDAL = DatabaseFactory.KapperszaakDAL();

        ProductInfoDal productinfo = new ProductInfoDal();
        KlantInfoUI klantInfoUI = new KlantInfoUI();


        public Kapperszaak()
        {
        }

        public void Inloggen(AdminInfoUI adminInfoUI) 
        {
            if (adminInfoUI.emailadres == null && adminInfoUI.wachtwoord == null)
            {
                throw new NotImplementedException();
            }
            else
            {
                AdminInfoDal adminInfoDal = new AdminInfoDal(adminInfoUI.emailadres, adminInfoUI.wachtwoord);
                kapperszaakDAL.Inloggen(adminInfoDal);
            }
        }

        public void VoegProductToe(ProductInfoUI productInfoUI)
        {
            productinfo = new ProductInfoDal(productInfoUI.titel, productInfoUI.omschrijving, productInfoUI.prijs, productInfoUI.image);
            kapperszaakDAL.VoegProductToe(productinfo);
        }

        public void VerwijderProduct(ProductInfoUI productInfoUI)
        {
            productinfo = new ProductInfoDal(productInfoUI.titel, productInfoUI.omschrijving, productInfoUI.prijs, productInfoUI.image);
            kapperszaakDAL.VerwijderProduct(productinfo);
        }
        public List<ProductInfoUI> AlleProductenOphalen()
        {
            foreach (var pinfoDal in kapperszaakDAL.HaalProductenOp())
            {
                ProductInfoUI productInfoUI = new ProductInfoUI(pinfoDal.titel, pinfoDal.omschrijving, pinfoDal.prijs, pinfoDal.image);
                producten.Add(productInfoUI);
            }
            return producten;
        }
        public List<AfspraakInfoUI> AlleAfsprakenOphalen() 
        {
            foreach (var asinfoDal in kapperszaakDAL.HaalAfspraakOp())
            {
                AfspraakInfoUI afspraakInfoUI = new AfspraakInfoUI(asinfoDal.opmerkingen, asinfoDal.datetime, klantInfoUI);
                afspraken.Add(afspraakInfoUI);
            }
            return afspraken;
        }
        public List<CadeauKaartInfoUI> AlleCadeauKaartenOphalen()
        {
            foreach (var ckinfoDal in kapperszaakDAL.HaalCadeauKaartOp())
            {
                CadeauKaartInfoUI cadeauKaartInfoUI = new CadeauKaartInfoUI(ckinfoDal.bestemd, ckinfoDal.bedrag, klantInfoUI);
                cadeaukaarten.Add(cadeauKaartInfoUI);
            }
            return cadeaukaarten; 
        }
    }
}
  