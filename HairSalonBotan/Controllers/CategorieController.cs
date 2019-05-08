using FactoryUI;
using HairSalonBotan.Models;
using InterfaceUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace HairSalonBotan.Controllers
{
    public class CategorieController : Controller
    {
        ICategorieCollectieUI categorieCollectieUI = UIFactory.categorieCollectie();
        CategorieVM categorieVM = new CategorieVM();


         // er wordt geen id meegegeven, daardoor haalt die de lijst niet op 
        [HttpGet]
        public ActionResult Categorieën()
        {
            categorieVM.categorieInfoUI = categorieCollectieUI.AlleCategorieenOphalen();
            return View(categorieVM);
        }
    }
}
