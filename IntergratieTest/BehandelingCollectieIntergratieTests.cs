using FactoryDAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FactoryUI;
using InterfaceUI;
using LogicKapperszaak;

namespace IntergratieTest
{
    [TestClass()]
    public class BehandelingCollectieIntergratieTests
    {
        private Categorie categorie;
        private Behandeling behandeling;
        private BehandelingCollectie behandelingCollectie;
        private IBehandelingUi behandelingUi;
        private ICategorieUI categorieUi;

        [TestInitialize]
        public void Initialize()
        {
            DatabaseFactory.IntergratieTest = true;
            behandeling = new Behandeling();
            behandelingCollectie = new BehandelingCollectie();
            categorie = new Categorie();
            behandelingUi = UIFactory.Behandeling();
            categorieUi = UIFactory.Categorie();
        }
        [TestMethod()]
        public void BehandelingToevoegenTest()
        {
            // Assign
            categorie = new Categorie(4, "Epileren");
            behandeling = new Behandeling(33, "Hele gezicht", 12, categorie);

            categorieUi = new Categorie(categorie.CategorieId, categorie.Categorienaam);
            behandelingUi = new Behandeling(behandeling.Id, behandeling.Omschrijving, behandeling.Bedrag, categorieUi);

            //Act
            behandelingCollectie.BehandelingToevoegen(behandelingUi, categorieUi);

            //Assert
            Assert.AreEqual(categorieUi.CategorieId, behandelingCollectie.BehandelingCollectieDAL.HaalBehandelingenOp()[3].categorieinfoDal.CategorieId);
            Assert.AreEqual(4, behandelingCollectie.BehandelingCollectieDAL.HaalBehandelingenOp().Count);
        }

        [TestMethod()]
        public void BehandelingVerwijderenTest()//Verwijderd een bestaande behandeling uit de database
         {
            // Assign
            categorie = new Categorie(2, "Vrouwen");
            behandeling = new Behandeling(33, "Pony knippen", 3, categorie);

            categorieUi = new Categorie(categorie.CategorieId, categorie.Categorienaam);
            behandelingUi = new Behandeling(behandeling.Id, behandeling.Omschrijving, behandeling.Bedrag, categorieUi);

            //Act
            behandelingCollectie.BehandelingVerwijderen(behandeling.Id);

            //Assert
           Assert.AreEqual(3, behandelingCollectie.BehandelingCollectieDAL.HaalBehandelingenOp().Count);
         }

        [TestMethod()]
        public void UpdateBehandeling()
        {
            // Assign
            categorie = new Categorie(2, "Vrouwen");
            behandeling = new Behandeling(5, "Knippen", 9, categorie);

            categorieUi = new Categorie(categorie.CategorieId, categorie.Categorienaam);
            behandelingUi = new Behandeling(behandeling.Id, behandeling.Omschrijving, behandeling.Bedrag, categorieUi);

            //Act
            int behandelingid = behandeling.Id;
            behandeling.UpdateBehandeling(behandelingid, behandelingUi, categorieUi);

            //Assert
            Assert.AreEqual(categorie.Categorienaam, behandelingCollectie.BehandelingCollectieDAL.HaalBehandelingenOp()[2].categorieinfoDal.Categorienaam);
            Assert.AreEqual(categorie.CategorieId, behandelingCollectie.BehandelingCollectieDAL.HaalBehandelingenOp()[2].categorieinfoDal.CategorieId);

        }

        [TestMethod()]
        public void AlleBehandelingenOphalenTest() 
        {
            //Assign

            //Act

            //Assert
     //       Assert.AreEqual(3, behandelingCollectie.BehandelingCollectieDAL.HaalBehandelingenOp().Count);
        }

        [TestMethod()]
        public void AlleBehandelingenVoorCategorieTest()
        {
            //Assign 

            //Act

            //Assert
            Assert.AreEqual(2, behandelingCollectie.BehandelingCollectieDAL.GeefAlleBehandelingVoorCategorie("Mannen").Count);
        }
    }
}