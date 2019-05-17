using System.Web.Mvc;
using InterfaceUI;
using FactoryUI;
using HairSalonBotan.Models;

namespace HairSalonBotan.Controllers
{
    public class BehandelingController : Controller
    {
        IBehandelingCollectieUI behandelingCollectie = UIFactory.BehandelingCollectie();
        IBehandelingUi behandelingUI = UIFactory.Behandeling();
        ICategorieCollectieUI categorieCollectie = UIFactory.CategorieCollectie();

        BehandelingVM bhmodel = new BehandelingVM();
        BehandelingsInfoUI behandelingsinfo;
        CategorieInfoUI categorieInfo;

        [HttpGet]
        public ActionResult Index()
        {
            BehandelingVM bhmodel = new BehandelingVM
            {
                behandelingUI = behandelingCollectie.AlleBehandelingenOphalen()
            };
            return View(bhmodel);
        }
        public ActionResult BehandelingDoorGevenAanCategorie(int id, string naam)
        {
            bhmodel.geefAlleBehandelingVoorCategorie = behandelingCollectie.AlleBehandelingenVoorCategorie(id);
            return View(bhmodel);
        }
        public ActionResult Test(int id, BehandelingVM behandelingVM)
        {
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

                return RedirectToAction("Index");
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

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult VerwijderBehandeling()
        {
            return View();
        }

        [HttpPost]
        public ActionResult VerwijderBehandeling(BehandelingsInfoUI behandelingsinfo)
        {
            var behandelingId = behandelingUI.BehandelingIDdoorGeven();
            behandelingCollectie.BehandelingVerwijderen(behandelingId);

            return RedirectToAction("Index");
        }
    }
}