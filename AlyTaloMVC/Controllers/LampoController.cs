using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlyTaloMVC.Controllers
{
    public class LampoController : Controller
    {
        // GET: Lampo
        public ActionResult Index()
        {
            return View();
        }

        // GET: Lampo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Lampo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Lampo/Create
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

        // GET: Lampo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Lampo/Edit/5
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

        // GET: Lampo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Lampo/Delete/5
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
