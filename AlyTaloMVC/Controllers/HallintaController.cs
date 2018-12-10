using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlyTaloMVC.Controllers
{
    public class HallintaController : Controller
    {
        // GET: Hallinta
        public ActionResult Index()
        {
            return View();
        }

        // GET: Hallinta/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Hallinta/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hallinta/Create
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

        // GET: Hallinta/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Hallinta/Edit/5
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

        // GET: Hallinta/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Hallinta/Delete/5
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
