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

                //kapperszaakUI.VoegProductToe(productInfoUI, kapperszaakInfoUI);

                return RedirectToAction("LijstProducten");
            }
            catch
            {
                return View();
            }
        }


        [HttpPost]
        public ActionResult ProductVerwijderen()
        {
            kapperszaakUI.ProductVerwijderen(productUi.Id);
            return RedirectToAction("LijstProducten");
        }
    }
}
