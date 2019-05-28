using InterfaceDAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterfaceUI;

namespace LogicKapperszaak.Tests
{
    [TestClass()]
    public class KapperszaakTests
    {
        Kapperszaak kapperszaak = new Kapperszaak();
        IKapperszaakUi kpUi = new Kapperszaak();

        IProductUi product = new Product();

        [TestMethod()]
        public void InloggenTest()
        {
            string emailadres = "habun@live.nl";
            string wachtwoord = "test12";

            kapperszaak.Inloggen(emailadres, wachtwoord);
        }

        [TestMethod()]
        public void VoegProductToeTest()
        {
            //Assign
            int kapperszaakid = 10;
            Product producten = new Product(1, "Wax", "Rood", "wax.jpg");
            product = new Product(producten.Id, producten.Titel, producten.Omschrijving, producten.Image);

            //Act
            kapperszaak.VoegProductToe(product, kapperszaakid);

            //Assert
            Assert.AreEqual(kapperszaakid, kapperszaak.kapperszaakDAL.HaalProductenOp()[1].Id);
            Assert.AreEqual("Wax", kapperszaak.kapperszaakDAL.HaalProductenOp()[1].Titel);
        }

        [TestMethod()]
        public void ProductVerwijderenTest()
        {
        }

        [TestMethod()]
        public void VoegWerknemerToeTest()
        {
        }

        [TestMethod()]
        public void AlleWerknemersOphalenTest()
        {
        }
    }
}