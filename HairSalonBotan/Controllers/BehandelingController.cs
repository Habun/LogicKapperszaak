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
    public class BehandelingController : Controller
    {
        IBehandelingCollectieUI behandelingCollectie = UIFactory.behandelingCollectie();
        IBehandelingUI behandelingUI = UIFactory.behandeling();
        ICategorieCollectieUI categorieCollectie = UIFactory.categorieCollectie();

        BehandelingVM bhmodel = new BehandelingVM();
        BehandelingsInfoUI behandelingsinfo = new BehandelingsInfoUI();

        [HttpGet]
        public ActionResult Index()
        {
            BehandelingVM bhmodel = new BehandelingVM
            {
                behandelingUI = behandelingCollectie.AlleBehandelingenOphalen()
            };
            return View(bhmodel);
        }
        public ActionResult BehandelingDoorGevenAanCategorie(int id)
        {
            bhmodel = new BehandelingVM();
            bhmodel.geefAlleBehandelingVoorCategorie = behandelingCollectie.AlleBehandelingenVoorCategorie(id);

            return View(bhmodel);
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        [HttpGet]
        public ActionResult CreateBehandeling(BehandelingVM behandelingVM)
        {
            behandelingVM.categorieVM.categorieInfoUI = categorieCollectie.AlleCategorieenOphalen();
            return View(behandelingVM);
        }

        [HttpPost]
        public ActionResult CreateBehandeling(BehandelingVM behandelingVM, CategorieVM categorieVM)
        {
            try
            {
                CategorieInfoUI categorieInfo = new CategorieInfoUI(categorieVM.categorieId, categorieVM.categorienaam);

                behandelingsinfo = new BehandelingsInfoUI(behandelingVM.behandelingsId, behandelingVM.omschrijving, behandelingVM.bedrag, categorieInfo);
                behandelingCollectie.BehandelingToevoegen(behandelingsinfo, categorieInfo);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Behandeling/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Behandeling/Edit/5
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
        public ActionResult VerwijderBehandeling()
        {
            return View();
        }
        [HttpPost]
        public ActionResult VerwijderBehandeling(int behandelingId)
        {
            behandelingsinfo = new BehandelingsInfoUI(bhmodel.behandelingsId);
            behandelingsinfo = behandelingCollectie.HaalBehandelingIdOp(behandelingId);
            behandelingCollectie.BehandelingVerwijderen(behandelingId);

            return RedirectToAction("Index");
        }
    }
}
