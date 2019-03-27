﻿using System;
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

        // GET: Behandeling/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()        
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection collection, BehandelingVM behandelingVM)
        {
            try
            {
                behandelingsinfo = new BehandelingsInfoUI(behandelingVM.omschrijving, behandelingVM.bedrag);
                behandelingCollectie.BehandelingToevoegen(behandelingsinfo);
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

        // GET: Behandeling/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Behandeling/Delete/5
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
