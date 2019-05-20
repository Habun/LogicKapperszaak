using FactoryUI;
using HairSalonBotan.Models;
using InterfaceUI;
using System.Web.Mvc;

namespace HairSalonBotan.Controllers
{
    public class CategorieController : Controller
    {
        ICategorieCollectieUI categorieCollectieUI = UIFactory.CategorieCollectie();
        CategorieVM categorieVM = new CategorieVM();

        [HttpGet]
        public ActionResult Categorieën()
        {
            categorieVM.categorieInfoUI = categorieCollectieUI.AlleCategorieenOphalen();

            return View(categorieVM);
        }
    }
}
