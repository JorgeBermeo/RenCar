using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GurpoII.Controllers
{
    public class TipocombustibleController : Controller
    {
        tipocombustible tipo = new tipocombustible();
        // GET: Tipocombustible
        public ActionResult Index()
        {

            DataTable data = new DataTable();
            //SET_DATATABLE(data);
            data = tipo.QueryTipocombustible();
            return View(data);
        }

        // GET: Tipocombustible/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Tipocombustible/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tipocombustible/Create
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

        // GET: Tipocombustible/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Tipocombustible/Edit/5
        [HttpPost]
        public ActionResult Edit(int id,  tipocombustible tipe)
        {
            try
            {
                // TODO: Add update logic here
                tipo.UpdateTipocombustible(tipe);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Tipocombustible/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Tipocombustible/Delete/5
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


        private void SET_DATATABLE(DataTable datatable)
        {
            datatable.Columns["TIPC_ID"].ColumnName = "ID";
            datatable.Columns["TIPC_NOMBRE"].ColumnName = "NOMBRE COMBUSTIBLE";
        

            //datatable.Columns.Remove("TREA_IDTAREA");
            //datatable.Columns.Remove("TREA_IDTAREA1");
            //datatable.Columns.Remove("TREA_ESTADO");
        }

    }
}
