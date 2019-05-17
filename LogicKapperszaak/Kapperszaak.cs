using InterfaceDAL;
using InterfaceUI;
using System;
using System.Collections.Generic;
using FactoryDAL;

namespace LogicKapperszaak
{
   public class Kapperszaak : IKapperszaakUI
    {
        public int Kapperszaakid { get; set; }
        public string Naam { get; set; }
        public List<ProductInfoUI> producten { get;} = new List<ProductInfoUI>();
        public List<AfspraakInfoUI> afspraken { get;} = new List<AfspraakInfoUI>();
        public List<CadeauKaartInfoUI> cadeaukaarten { get;} = new List<CadeauKaartInfoUI>();

        IKapperszaakDAL kapperszaakDAL = DatabaseFactory.KapperszaakDAL();

        KapperszaakInfoDal kapperszaakinfodal;

        ProductInfoDal productinfo;

        KlantInfoUI klantInfoUI = new KlantInfoUI();

        public Kapperszaak(int kapperszaakId, string naam)
        {
            Kapperszaakid = kapperszaakId;
            Naam = naam;
        }
        public Kapperszaak()
        {
        }

        public void Inloggen(AdminInfoUI adminInfoUI) 
        {
            AdminInfoDal adminInfoDal = new AdminInfoDal(adminInfoUI.Emailadres, adminInfoUI.Wachtwoord);

            if (adminInfoUI.Emailadres == null && adminInfoUI.Wachtwoord == null)
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
            kapperszaakinfodal = new KapperszaakInfoDal(kappersinfoUI.Kapperszaakid, kappersinfoUI.Naam);

            productinfo = new ProductInfoDal(kapperszaakinfodal, productInfoUI.ProductId, productInfoUI.Titel, productInfoUI.Omschrijving,productInfoUI.Image);
            kapperszaakDAL.VoegProductToe(productinfo);
        }
        public void ProductVerwijderen(int productId)
        {
            kapperszaakDAL.VerwijderProduct(productId);
        }
        public List<ProductInfoUI> AlleProductenOphalen()
        {
            foreach (var pinfoDal in kapperszaakDAL.HaalProductenOp())
            {
                KapperszaakinfoUI kapperszaakinfoUI = new KapperszaakinfoUI(pinfoDal.kapperszaakdal.Kapperszaakid, pinfoDal.kapperszaakdal.Naam);

                ProductInfoUI productInfoUI = new ProductInfoUI(kapperszaakinfoUI, pinfoDal.ProductId, pinfoDal.Titel, pinfoDal.Omschrijving, pinfoDal.Image);
                producten.Add(productInfoUI);
            }
            return producten;
        }
        public List<AfspraakInfoUI> AlleAfsprakenOphalen() 
        {
            foreach (var asinfoDal in kapperszaakDAL.HaalAfspraakOp())
            {
                AfspraakInfoUI afspraakInfoUI = new AfspraakInfoUI(asinfoDal.Opmerkingen, asinfoDal.datetime, klantInfoUI);
                afspraken.Add(afspraakInfoUI);
            }
            return afspraken;
        }
        public List<CadeauKaartInfoUI> AlleCadeauKaartenOphalen()
        {
            foreach (var ckinfoDal in kapperszaakDAL.HaalCadeauKaartOp())
            {
                CadeauKaartInfoUI cadeauKaartInfoUI = new CadeauKaartInfoUI(ckinfoDal.Bestemd, ckinfoDal.Bedrag, klantInfoUI);
                cadeaukaarten.Add(cadeauKaartInfoUI);
            }
            return cadeaukaarten; 
        }
    }
}
  