using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogicKapperszaak;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicKapperszaak.Tests
{
    [TestClass()]
    public class AfspraakTests
    {
        [TestMethod()]
        public void KostenVanBehandelingenOptellenTest()
        {
            Afspraak afspraak = new Afspraak();
            Behandeling bh = new Behandeling(1, "", 12);

            afspraak.KostenVanBehandelingenOptellen(bh);

            Behandeling bh1 = new Behandeling(1, "", 23);

            afspraak.KostenVanBehandelingenOptellen(bh1);

            //Assert.IsTrue(behandeling);
        }
    }
}