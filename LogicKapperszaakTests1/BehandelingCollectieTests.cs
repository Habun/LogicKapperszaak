using FactoryDAL;
using FactoryUI;
using InterfaceUI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LogicKapperszaak.Tests
{
    [TestClass()]
    public class BehandelingCollectieTests
    {
        private Categorie categorie;
        private Behandeling behandeling;
        private BehandelingCollectie behandelingCollectie;
        private IBehandelingUi behandelingUi;
        private ICategorieUI categorieUi;

        [TestInitialize]
        public void Initialize()
        {
            DatabaseFactory.UnitTesting = false;
            behandeling = new Behandeling();
            behandelingCollectie = new BehandelingCollectie();
            categorie = new Categorie();
            behandelingUi = UIFactory.Behandeling();
            categorieUi = UIFactory.Categorie();
        }
        [TestMethod()]
        public void BehandelingEnCategorieToevoegenTest()
        {
            // Assign 
            categorie = new Categorie(1, "Mannen");
            behandeling = new Behandeling(10, "Knippen", 12, categorieUi);

            categorieUi = new Categorie(categorie.CategorieId, categorie.Categorienaam);
            behandelingUi = new Behandeling(behandeling.Id, behandeling.Omschrijving, behandeling.Bedrag, categorieUi);

            // Act
            behandelingCollectie.BehandelingToevoegen(behandelingUi, categorieUi);

            // Assert
            Assert.AreEqual(categorieUi.CategorieId, behandelingCollectie.BehandelingCollectieDAL.HaalBehandelingenOp()[0].categorieinfoDal.CategorieId);
        }

        [TestMethod()]
        public void AlleBehandelingenOphalenTest()
        {
            // Assign
            categorie = new Categorie(6, "Epileren");
            behandeling = new Behandeling(6, "Wenkbrauwen", 7, categorieUi);

            categorieUi = new Categorie(categorie.CategorieId, categorie.Categorienaam);
            behandelingUi = new Behandeling(behandeling.Id, behandeling.Omschrijving, behandeling.Bedrag, categorieUi);

            behandelingCollectie.BehandelingToevoegen(behandelingUi, categorieUi);

            //Act
            behandelingCollectie.AlleBehandelingenOphalen();

            //Assert
            Assert.AreEqual(2, behandelingCollectie.Lijstbehandeling.Count);
        }

        [TestMethod()]
        public void AlleBehandelingenVoorCategorieTest()
        {
            behandelingCollectie.AlleBehandelingenVoorCategorie("Mannen");

         //   Assert.Fail();
        }
    }
}