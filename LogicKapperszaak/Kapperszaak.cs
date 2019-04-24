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
        public int kapperszaakid { get; set; }
        public string naam { get; set; }
        public List<ProductInfoUI> producten { get; private set; } = new List<ProductInfoUI>();
        public List<AfspraakInfoUI> afspraken { get; private set; } = new List<AfspraakInfoUI>();
        public List<CadeauKaartInfoUI> cadeaukaarten { get; private set; } = new List<CadeauKaartInfoUI>();

        IKapperszaakDAL kapperszaakDAL = DatabaseFactory.KapperszaakDAL();

        KapperszaakInfoDal kapperszaakinfodal = new KapperszaakInfoDal();

        ProductInfoDal productinfo = new ProductInfoDal();

        KlantInfoUI klantInfoUI = new KlantInfoUI();

        public Kapperszaak(int KapperszaakId, string Naam)
        {
            kapperszaakid = KapperszaakId;
            naam = Naam;
        }
        public Kapperszaak()
        {
        }

        public void Inloggen(AdminInfoUI adminInfoUI) 
        {
            AdminInfoDal adminInfoDal = new AdminInfoDal(adminInfoUI.emailadres, adminInfoUI.wachtwoord);

            if (adminInfoUI.emailadres == null && adminInfoUI.wachtwoord == null)
            {
                throw new NotImplementedException();
            }
            else
            {
                kapperszaakDAL.Inloggen(adminInfoDal);
            }
        }

        public void VoegProductToe(ProductInfoUI productInfoUI, KapperszaakinfoUI kappersinfoUI)
        {
            kapperszaakinfodal = new KapperszaakInfoDal(kappersinfoUI.kapperszaakid, kappersinfoUI.naam);

            productinfo = new ProductInfoDal(kapperszaakinfodal, productInfoUI.titel, productInfoUI.omschrijving,productInfoUI.image);
            kapperszaakDAL.VoegProductToe(productinfo);
        }

        public void VerwijderProduct(ProductInfoUI productInfoUI, KapperszaakinfoUI kappersinfoUI)
        {
            kapperszaakinfodal = new KapperszaakInfoDal(kappersinfoUI.kapperszaakid, kappersinfoUI.naam);

            productinfo = new ProductInfoDal(kapperszaakinfodal , productInfoUI.titel, productInfoUI.omschrijving, productInfoUI.image);
            kapperszaakDAL.VerwijderProduct(productinfo);
        }
        public List<ProductInfoUI> AlleProductenOphalen()
        {
            foreach (var pinfoDal in kapperszaakDAL.HaalProductenOp())
            {
                KapperszaakinfoUI kapperszaakinfoUI = new KapperszaakinfoUI(pinfoDal.kapperszaakdal.kapperszaakid, pinfoDal.kapperszaakdal.naam);

                ProductInfoUI productInfoUI = new ProductInfoUI(kapperszaakinfoUI, pinfoDal.titel, pinfoDal.omschrijving, pinfoDal.image);
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
  