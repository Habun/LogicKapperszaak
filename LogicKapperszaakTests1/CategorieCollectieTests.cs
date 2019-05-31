using LogicKapperszaak;
using System.Collections.Generic;
using FactoryDAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FactoryUI;
using InterfaceUI;

namespace LogicKapperszaak.Tests
{


    [TestClass()]
    public class CategorieCollectieTests
    {
        private Categorie categorie;
        private ICategorieUI IcategorieUi;
        private CategorieCollectie categorieCollectie;

        [TestInitialize]
        public void Initialize()
        {
            DatabaseFactory.UnitTesting = true;
            categorieCollectie = new CategorieCollectie();
            IcategorieUi = UIFactory.Categorie();
        }

        [TestMethod()]
        public void CategorieToevoegenTest()
        {
            // Assign
            categorie = new Categorie(5, "Epileren");
            IcategorieUi = new Categorie(categorie.CategorieId, categorie.Categorienaam);

            //Act
            categorieCollectie.CategorieToevoegen(IcategorieUi);

            //Assert
            Assert.AreEqual("Epileren", categorieCollectie.CategorieCollectionDAL.HaalCategorieOp()[4].Categorienaam);
        }

        [TestMethod()]
        public void AlleCategorieenOphalenTest()
        {
            // Assign

            //Act
            categorieCollectie.AlleCategorieenOphalen();
            
            //Assert
            Assert.AreEqual(4, categorieCollectie.AlleCategorieenOphalen().Count);
        }
    }
}