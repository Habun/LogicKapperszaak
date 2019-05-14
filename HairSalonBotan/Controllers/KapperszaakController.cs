using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InterfaceUI;
using FactoryUI;
using HairSalonBotan.Models;

namespace HairSalonBotan.Controllers
{
    public class KapperszaakController : Controller
    {
        IKapperszaakUI kapperszaakUI = UIFactory.kapperszaak();
        IProductUI productUI = UIFactory.product();

        ProductInfoUI productInfoUI;
        ProductVM pdVM = new ProductVM();
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

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Kapperszaak/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Kapperszaak/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
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
        public ActionResult ProductVerwijderen(int productId)
        {
            kapperszaakUI.VerwijderProduct(productId);
            return RedirectToAction("LijstProducten");
        }
    }
}
