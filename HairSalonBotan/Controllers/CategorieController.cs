﻿using FactoryUI;
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
        public ActionResult Categorieën()
        {
            CategorieVM categorieVM = new CategorieVM
            {
                categorieInfoUI = categorieCollectieUI.AlleCategorieenOphalen()
            };
            return View(categorieVM); 
        }
    }
}