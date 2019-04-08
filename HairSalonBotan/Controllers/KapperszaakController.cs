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
            try
            {
                AdminInfoUI adminUI = new AdminInfoUI(adminVM.Emailadres, adminVM.Wachtwoord);
                kapperszaakUI.Inloggen(adminUI);

                return RedirectToAction("ProductenPagina", "Kapperszaak");
            }
            catch
            {
                return View("Inloggen");
            }
        }

        // GET: Kapperszaak/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Kapperszaak/Create
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

        // GET: Kapperszaak/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Kapperszaak/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
