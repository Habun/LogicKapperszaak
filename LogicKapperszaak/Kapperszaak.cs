using InterfaceDAL;
using InterfaceUI;
using System;
using System.Collections.Generic;
using FactoryDAL;

namespace LogicKapperszaak
{
   public class Kapperszaak : IKapperszaakUi
    {
        public int Id { get;}
        public string Naam { get;}

        IKapperszaakDAL kapperszaakDAL = DatabaseFactory.KapperszaakDAL();
        ProductInfoDal productinfo;

        public Kapperszaak(int id, string naam)
        {
            Id = id;
            Naam = naam;
        }
        public Kapperszaak()
        {

        }
        public void Inloggen(string emailadres, string wachtwoord) 
        {
            AdminInfoDal adminInfoDal = new AdminInfoDal(emailadres, wachtwoord);

            if (emailadres == null && wachtwoord == null)
            {
                throw new NotImplementedException("Vul alle gegevens in");
            }
            kapperszaakDAL.Inloggen(adminInfoDal);
        }

        public void VoegProductToe(IProductUi product)
        {
            productinfo = new ProductInfoDal(product.Titel, product.Omschrijving,product.Image);

            kapperszaakDAL.VoegProductToe(productinfo);
        }
        public void ProductVerwijderen(int productId)
        {
            kapperszaakDAL.VerwijderProduct(productId);
        }
        public void VoegWerknemerToe(IWerknemerUi werknemer)
        {

        }

        public int ProductIdDoorGeven(int id)
        {
            if (kapperszaakDAL.GeefProductId(id) == 0)
            {
                throw new ArgumentException($"Geen productId gevonden.");
            }
            return kapperszaakDAL.GeefProductId(id);
        }

        public List<IWerknemerUi> AlleWerknemersOphalen()
        {
            List<IWerknemerUi> werknemers = new List<IWerknemerUi>();

            return werknemers;
        }
        public List<IProductUi> AlleProductenOphalen()
        {
            List<IProductUi> producten = new List<IProductUi>();

            foreach (var pinfoDal in kapperszaakDAL.HaalProductenOp())
            {
                IProductUi product = new Product(pinfoDal.Titel, pinfoDal.Omschrijving, pinfoDal.Image);
                producten.Add(product);
            }
            return producten;
        }
        public List<IAfspraakUi> AlleAfsprakenOphalen()
        {
            List<IAfspraakUi> afspraken = new List<IAfspraakUi>();

            foreach (var asinfoDal in kapperszaakDAL.HaalAfspraakOp())
            {
                IKlantUi klant = new Klant(asinfoDal.klantinfo.Naam, asinfoDal.klantinfo.Telefoonnummer, asinfoDal.klantinfo.Emailadres);

                IAfspraakUi afspraak = new Afspraak(asinfoDal.Opmerkingen, asinfoDal.datetime, klant);
                afspraken.Add(afspraak);
            }
            return afspraken;
        }
        public List<ICadeauKaartUi> AlleCadeauKaartenOphalen()
        {
            List<ICadeauKaartUi> cadeaukaarten = new List<ICadeauKaartUi>();

            foreach (var ckinfoDal in kapperszaakDAL.HaalCadeauKaartOp())
            {
                IKlantUi klant = new Klant(ckinfoDal.klantDAL.Naam, ckinfoDal.klantDAL.Telefoonnummer, ckinfoDal.klantDAL.Emailadres);

                ICadeauKaartUi cadeauKaart = new CadeauKaart(ckinfoDal.Bestemd, ckinfoDal.Bedrag, klant);
                cadeaukaarten.Add(cadeauKaart);
            }
            return cadeaukaarten; 
        }
    }
}
  