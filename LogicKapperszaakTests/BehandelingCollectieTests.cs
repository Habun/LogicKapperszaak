using DAL;
using InterfaceDAL;
using InterfaceUI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LogicKapperszaak.Tests
{
    [TestClass()]
    public class BehandelingCollectieTests
    {
        IBehandelingCollectieUI behandelingCollectieUi = new BehandelingCollectie();
        
        IBehandelingCollectieDAL behandelingCollectieDal = new BehandelingDatabase();
        IBehandelingDAL behandelingDal = new BehandelingDatabase();

        BehandelingCollectie behandeling = new BehandelingCollectie();


        [TestMethod()]
        public void BehandelingEnCategorieToevoegenTest()
        {
            // Assign
            CategorieInfoDal categorieInfoDal = new CategorieInfoDal(1,"Mannen");
            BehandelingInfoDal behandelingInfoDal = new BehandelingInfoDal(1, "", 12, categorieInfoDal);


            //Act
            behandeling.BehandelingToevoegen(behandelingInfoDal, categorieInfoDal);
            //Assert
            Assert.Fail();
        }

        [TestMethod()]
        public void BehandelingVerwijderenTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AlleBehandelingenOphalenTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AlleBehandelingenVoorCategorieTest()
        {
            Assert.Fail();
        }
    }
}