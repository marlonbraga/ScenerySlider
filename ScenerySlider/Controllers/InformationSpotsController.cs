using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ScenerySlider.Data;
using ScenerySlider.Models;

namespace ScenerySlider
{
    public class InformationSpotsController : Controller
    {
        private InformationSpotContext db = new InformationSpotContext();

        // GET: InformationSpots
        public ActionResult Index()
        {
            return View(db.InformationSpots.ToList());
        }

        // GET: InformationSpots/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InformationSpot informationSpot = db.InformationSpots.Find(id);
            if (informationSpot == null)
            {
                return HttpNotFound();
            }
            return View(informationSpot);
        }

        // GET: InformationSpots/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InformationSpots/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,FileLocate,Description")] InformationSpot informationSpot)
        {
            if (ModelState.IsValid)
            {
                db.InformationSpots.Add(informationSpot);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(informationSpot);
        }

        // GET: InformationSpots/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InformationSpot informationSpot = db.InformationSpots.Find(id);
            if (informationSpot == null)
            {
                return HttpNotFound();
            }
            return View(informationSpot);
        }

        // POST: InformationSpots/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,FileLocate,Description")] InformationSpot informationSpot)
        {
            if (ModelState.IsValid)
            {
                db.Entry(informationSpot).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(informationSpot);
        }

        // GET: InformationSpots/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InformationSpot informationSpot = db.InformationSpots.Find(id);
            if (informationSpot == null)
            {
                return HttpNotFound();
            }
            return View(informationSpot);
        }

        // POST: InformationSpots/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            InformationSpot informationSpot = db.InformationSpots.Find(id);
            db.InformationSpots.Remove(informationSpot);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
