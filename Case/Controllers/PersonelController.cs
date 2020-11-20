using Case.Models.DataModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Case.Controllers
{

    public class PersonelController : Controller
    {

        private CaseDb db = new CaseDb();

        // GET: Personel
        public ActionResult Index()
        {
            return View(db.Personels.ToList());
        }


        // GET: Personel/Create
        public ActionResult Create()
        {
            ViewBag.departmans = db.EnmDepartmen.ToList();
            ViewBag.unvan = db.EnmUnvans.ToList();

            return View();
        }

        // POST: Personel/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Personel personel)
        {
            try
            {

                db.Personels.Add(personel);
                db.SaveChanges();


                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Personel/Edit/5
        public ActionResult Edit(int id)
        {
            var model = db.Personels.Where(x => x.Id == id).SingleOrDefault();
            ViewBag.departmans = db.EnmDepartmen.ToList();
            ViewBag.unvan = db.EnmUnvans.ToList();
            return View(model);
        }

        // POST: Personel/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Personel personel)
        {
            try
            {
                // TODO: Add update logic here
                db.Entry(personel).State = EntityState.Modified;
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Personel/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var model = db.Personels.Find(id);
            if (model == null)
            {
                return HttpNotFound();
            }

            return View(model);
        }

        // POST: Personel/Delete/5
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                // TODO: Add delete logic here
                var model = db.Personels.Find(id);
                db.Personels.Remove(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
