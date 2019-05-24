using System.Web.Mvc;
using InterfaceUI;
using FactoryUI;
using HairSalonBotan.Models;

namespace HairSalonBotan.Controllers
{
    public class BehandelingController : Controller
    {
        IBehandelingCollectieUi behandelingCollectie = UIFactory.BehandelingCollectie();
        IBehandelingUi behandelingUI = UIFactory.Behandeling();
        ICategorieCollectieUi categorieCollectie = UIFactory.CategorieCollectie();

        BehandelingVM bhmodel = new BehandelingVM();

        [HttpGet]
        public ActionResult Behandelingen()
        {
            BehandelingVM bhmodel = new BehandelingVM
            {
                behandelingUI = behandelingCollectie.AlleBehandelingenOphalen()
            };
            return View(bhmodel);
        }
        public ActionResult BehandelingDoorGevenAanCategorie(string categorieNaam)
        {
            bhmodel.geefAlleBehandelingVoorCategorie = behandelingCollectie.AlleBehandelingenVoorCategorie(categorieNaam);
            Session["categorieNaam"] = categorieNaam;

            return View(bhmodel);
        }

        public ActionResult BehandelingReserveren(BehandelingVM behandelingVM)
        {
            var categorienaam = Session["categorieNaam"] as string;

            Session["behandelingVM"] = behandelingVM;

            var behandeling = Session["behandelingVM"] as BehandelingVM;

            return View(behandelingVM);
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
                categorieInfo = new CategorieInfoUI(categorieVM.categorieId, categorieVM.categorienaam);

                behandelingsinfo = new BehandelingsInfoUI(behandelingVM.behandelingsId, behandelingVM.omschrijving, behandelingVM.bedrag, categorieInfo);
                behandelingCollectie.BehandelingToevoegen(behandelingsinfo, categorieInfo);

                return RedirectToAction("Behandelingen");
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult Edit(int behandelingId)
        {
            behandelingUI.BehandelingIDdoorGeven();
            bhmodel.behandelingsId = behandelingId; 

            return View(bhmodel);
        }

        [HttpPost]
        public ActionResult Edit(int behandelingId, CategorieVM categorieVM, BehandelingVM behandelingVM)
        {
            categorieInfo = new CategorieInfoUI(categorieVM.categorieId, categorieVM.categorienaam);

            behandelingsinfo = new BehandelingsInfoUI(behandelingVM.behandelingsId, behandelingVM.omschrijving, behandelingVM.bedrag, categorieInfo);
            behandelingUI.UpdateBehandeling(behandelingId, behandelingsinfo, categorieInfo);

            return RedirectToAction("Behandelingen");
        }

        [HttpGet]
        public ActionResult VerwijderBehandeling()
        {
            return View();
        }

        [HttpPost]
        public ActionResult VerwijderBehandeling(BehandelingsInfoUI behandelingsinfo)
        {
            int behandelingId = behandelingUI.BehandelingsId;
            behandelingCollectie.BehandelingVerwijderen(behandelingId);

            return RedirectToAction("Behandelingen");
        }
    }
}