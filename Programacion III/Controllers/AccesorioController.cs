
using GrupoI.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Programacion_III.Controllers
{
    public class AccesorioController : Controller
    {
        Accesorios acce = new Accesorios();

        // GET: Accesorio
        public ActionResult Index()
        {
            DataTable data = acce.QueryAccesorios();

            return View(data);
        }

        // GET: Accesorio/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Accesorio/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Accesorio/Create
        [HttpPost]
        public ActionResult Create(Accesorios obj)
        {
         
            try
            {
                acce.InsertAccesorios(obj);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Accesorio/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Accesorio/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Accesorios obj)
        {
            try
            {
                // TODO: Add update logic here
                acce.UpdateAccesorios(obj);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Accesorio/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Accesorio/Delete/5
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
