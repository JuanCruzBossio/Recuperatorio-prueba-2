﻿using Recuperatorio_prueba_2.Data;
using Recuperatorio_prueba_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Recuperatorio_prueba_2.Controllers
{
    public class AfiliadoController : Controller
    {
        BaseDataService<Afiliado> db;
        public AfiliadoController()
        {
            db = new BaseDataService<Afiliado>();
        }

        [HttpGet]
        public ActionResult Index()
        {
            var list = db.Get();
            return View(list);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Afiliado model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Create(model);
                    return RedirectToAction("Index");
                }
                catch
                {
                }

            }
            return View(model);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = db.GetById(id);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(Afiliado model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Update(model);
                    return RedirectToAction("Index");
                }
                catch
                {

                }

            }
            return View(model);
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var model = db.GetById(id);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(Afiliado model)
        {
            try
            {
                db.Delete(model.Id);
                return RedirectToAction("Index");
            }
            catch
            {
            }
            return View(model);
        }
    }
}