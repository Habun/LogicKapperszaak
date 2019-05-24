using System.Web.Mvc;
using InterfaceUI;
using FactoryUI;
using HairSalonBotan.Models;

namespace HairSalonBotan.Controllers
{
    public class KapperszaakController : Controller
    {
        IKapperszaakUi kapperszaakUI = UIFactory.Kapperszaak();
        IProductUi productUi = UIFactory.Product();


        public ActionResult LijstProducten()
        {
            KapperszaakVM kpmodel = new KapperszaakVM()
            {
                producten = kapperszaakUI.AlleProductenOphalen()
            };
            return View(kpmodel);
        }
        public ActionResult ProductenPagina()
        {
            KapperszaakVM kpmodel = new KapperszaakVM()
            {
                producten = kapperszaakUI.AlleProductenOphalen()
            };
            return View(kpmodel);
        }
        public ActionResult Inloggen(AdminVM adminVM)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create(KapperszaakVM kapperszaakVM)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ProductVM productvm, KapperszaakVM kapperszaakVM)
        {
            try
            {
                //kapperszaakInfoUI = new KapperszaakinfoUI(kapperszaakVM.kapperszaakId, kapperszaakVM.naam);
                //productInfoUI = new ProductInfoUI(kapperszaakInfoUI, productvm.productId, productvm.titel, productvm.omschrijving, productvm.image);

                //kapperszaakUI.VoegProductToe(productInfoUI, kapperszaakInfoUI);

                return RedirectToAction("LijstProducten");
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult ProductVerwijderen()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ProductVerwijderen(KapperszaakVM kapperszaakVm)
        {
            return RedirectToAction("LijstProducten");
        }
    }
}
