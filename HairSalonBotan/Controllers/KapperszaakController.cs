using System.Web.Mvc;
using InterfaceUI;
using FactoryUI;
using HairSalonBotan.Models;

namespace HairSalonBotan.Controllers
{
    public class KapperszaakController : Controller
    {
        IKapperszaakUI kapperszaakUI = UIFactory.Kapperszaak();
        private IProductUI productUi = UIFactory.Product();
        KapperszaakinfoUI kapperszaakInfoUI;
        ProductInfoUI productInfoUI;

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
            AdminInfoUI adminUI = new AdminInfoUI(adminVM.Emailadres, adminVM.Wachtwoord);
            try
            {
                kapperszaakUI.Inloggen(adminUI);

                return RedirectToAction("ProductenPagina", "Kapperszaak");
            }
            catch
            {
                return View("Inloggen");
            }
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
                kapperszaakInfoUI = new KapperszaakinfoUI(kapperszaakVM.kapperszaakId, kapperszaakVM.naam);
                productInfoUI = new ProductInfoUI(kapperszaakInfoUI, productvm.productId, productvm.titel, productvm.omschrijving, productvm.image);

                kapperszaakUI.VoegProductToe(productInfoUI, kapperszaakInfoUI);

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
            var productId = productUi.ProductIdDoorGeven();
            kapperszaakUI.ProductVerwijderen(productId);

            return RedirectToAction("LijstProducten");
        }
    }
}
