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

        public List<IProductUi> Producten { get; } = new List<IProductUi>();
        public List<IAfspraakUi> Afspraken { get; } = new List<IAfspraakUi>();
        public List<ICadeauKaartUi> Cadeaukaarten { get; } = new List<ICadeauKaartUi>();
        public List<IWerknemerUi> Werknemers { get; } = new List<IWerknemerUi>();

        public IKapperszaakDAL kapperszaakDAL = DatabaseFactory.KapperszaakDAL();

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

        public void VoegProductToe(IProductUi product, int kapperszaakId)
        {
           ProductInfoDal productinfo = new ProductInfoDal(kapperszaakId, product.Titel, product.Omschrijving,product.Image);

           kapperszaakDAL.VoegProductToe(productinfo);
        }
        public void ProductVerwijderen(int productId)
        {
            kapperszaakDAL.VerwijderProduct(productId);
        }
        public void VoegWerknemerToe(IWerknemerUi werknemer)
        {
            WerknemerInfoDal werknemerInfo = new WerknemerInfoDal(werknemer.Naam);
            kapperszaakDAL.VoegWerknemerToe(werknemerInfo);
        }

        public List<IWerknemerUi> AlleWerknemersOphalen()
        {
            return Werknemers;
        }
        public List<IProductUi> AlleProductenOphalen()
        {
            foreach (var pinfoDal in kapperszaakDAL.HaalProductenOp())
            {
                IProductUi product = new Product(pinfoDal.Id,pinfoDal.Titel, pinfoDal.Omschrijving, pinfoDal.Image);
                Producten.Add(product);
            }
            return Producten;
        }
        public List<IAfspraakUi> AlleAfsprakenOphalen()
        {
            foreach (var asinfoDal in kapperszaakDAL.HaalAfspraakOp())
            {
                IKlantUi klant = new Klant(asinfoDal.klantinfo.Naam, asinfoDal.klantinfo.Telefoonnummer, asinfoDal.klantinfo.Emailadres);

                IAfspraakUi afspraak = new Afspraak(asinfoDal.AfspraakId,asinfoDal.Opmerkingen, asinfoDal.datetime, klant);
                Afspraken.Add(afspraak);
            }
            return Afspraken;
        }
        public List<ICadeauKaartUi> AlleCadeauKaartenOphalen()
        {
            foreach (var ckinfoDal in kapperszaakDAL.HaalCadeauKaartOp())
            {
                IKlantUi klant = new Klant(ckinfoDal.klantDAL.Naam, ckinfoDal.klantDAL.Telefoonnummer, ckinfoDal.klantDAL.Emailadres);

                ICadeauKaartUi cadeauKaart = new CadeauKaart(ckinfoDal.Bestemd, ckinfoDal.Bedrag, klant);
                Cadeaukaarten.Add(cadeauKaart);
            }
            return Cadeaukaarten; 
        }
    }
}
  