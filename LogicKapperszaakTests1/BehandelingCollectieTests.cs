using FactoryUI;
using InterfaceUI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LogicKapperszaak.Tests
{
    [TestClass()]
    public class BehandelingCollectieTests
    {
        BehandelingCollectie behandelingCollectie = new BehandelingCollectie();
        IBehandelingUi iBehandeling = UIFactory.Behandeling();
        Behandeling behandeling = new Behandeling();
        ICategorieUI categorieUi = UIFactory.Categorie();
        Categorie categorie = new Categorie();

        [TestMethod()]
        public void BehandelingEnCategorieToevoegenTest()
        {
            // Assign 
            categorie = new Categorie(11, "Mannen");
            Behandeling behandeling = new Behandeling(10, "Knippen", 12, categorieUi);

            categorieUi = new Categorie(categorie.CategorieId, categorie.Categorienaam);
            iBehandeling = new Behandeling(behandeling.Id, behandeling.Omschrijving, behandeling.Bedrag, categorieUi);

            // Act
            behandelingCollectie.BehandelingToevoegen(iBehandeling, categorieUi);

            // Assert
            Assert.AreEqual(10, behandelingCollectie.BehandelingCollectieDAL.HaalBehandelingenOp()[1].Id);//BehandelingId
            Assert.AreEqual(11, behandelingCollectie.BehandelingCollectieDAL.HaalBehandelingenOp()[1].categorieinfoDal.CategorieId);//CategorieId
        }

        [TestMethod()]
        public void AlleBehandelingenOphalenTest()
        {
            // Assign
            categorie = new Categorie(6, "Epileren");
            behandeling = new Behandeling(6, "Wenkbrauwen", 7, categorieUi);

            categorieUi = new Categorie(categorie.CategorieId, categorie.Categorienaam);
            iBehandeling = new Behandeling(behandeling.Id, behandeling.Omschrijving, behandeling.Bedrag, categorieUi);
            behandelingCollectie.BehandelingToevoegen(iBehandeling, categorieUi);

            //Act
            behandelingCollectie.AlleBehandelingenOphalen();

            //Assert
            Assert.AreEqual(2, behandelingCollectie.lijstbehandeling.Count);
        }
    }
}