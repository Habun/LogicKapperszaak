using System;
using FactoryDAL;
using InterfaceUI;
using FactoryUI;
using LogicKapperszaak;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace IntergratieTest
{
    [TestClass()]
    public class AfspraakIntegratieTest
    {
        private IBehandelingUi behandelingUi;
        private Afspraak afspraak;
        private Kapperszaak kapperszaak;
        private IKlantUi klantUi;
        private IAfspraakUi afspraakUi;
        private IKapperszaakUi kapperszaakUi;

        [TestInitialize]
        public void Initialize()
        {
            DatabaseFactory.IntergratieTest = true;
            behandelingUi = new Behandeling();
            afspraak = new Afspraak();
            kapperszaak = new Kapperszaak();
            klantUi = UIFactory.Klant();
            afspraakUi = UIFactory.Afspraak();
            kapperszaakUi = UIFactory.Kapperszaak();
        }

        [TestMethod()]
        public void BehandelingToevoegenAanAfspraakTest()
        {
            // Assign
            klantUi = new Klant("Hans", 0648777227, "Hans@live.nl");
            afspraakUi = new Afspraak(3, "Test", DateTime.Now, klantUi);

            behandelingUi = new Behandeling(12, "Knippen", 12);

            //Act
            afspraak.BehandelingToevoegenAanAfspraak(behandelingUi, afspraakUi.AfspraakId);

            //Assert
            Assert.AreEqual(12, afspraak.AfspraakBehandelingenOphalen(afspraakUi.AfspraakId)[0].Id);
        }

        [TestMethod()]
        public void HaalGekozenBehandelingenVoorKlantOp()
        {
            //Assign 
            klantUi = new Klant("Hans", 0648777227, "Hans@live.nl");
            afspraakUi = new Afspraak(3, "Test", DateTime.Now, klantUi);

            //Act


            //Assert
            Assert.AreEqual(3, afspraak.AfspraakBehandelingenOphalen(afspraakUi.AfspraakId).Count);
        }
        [TestMethod()]
        public void DeKostenVanDeGekozenBehandelingenBerekenen()
        {
            //Assign 
            klantUi = new Klant("Hans", 0648777227, "Hans@live.nl");
            afspraakUi = new Afspraak(3, "Test", DateTime.Now, klantUi);

            afspraakUi.AfspraakBehandelingenOphalen(afspraak.AfspraakId);

            //Act
            decimal expect = 22;
            decimal actuel = afspraakUi.KostenVanBehandelingenOptellen();

            //Assert
            Assert.AreEqual(expect, actuel);
        }
    }
}
