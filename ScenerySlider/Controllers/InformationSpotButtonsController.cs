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
using EntityState = System.Data.Entity.EntityState;

namespace ScenerySlider
{
    public class InformationSpotButtonsController : Controller
    {
        private InformationSpotButtonContext db = new InformationSpotButtonContext();

        // GET: InformationSpotButtons
        public ActionResult Index()
        {
            var informationSpotButtons = db.InformationSpotButtons.Include(i => i.InformationSpot).Include(i => i.Scene);
            return View(informationSpotButtons.ToList());
        }

        // GET: InformationSpotButtons/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InformationSpotButton informationSpotButton = db.InformationSpotButtons.Find(id);
            if (informationSpotButton == null)
            {
                return HttpNotFound();
            }
            return View(informationSpotButton);
        }

        // GET: InformationSpotButtons/Create
        public ActionResult Create()
        {
            ViewBag.InformationSpotId = new SelectList(db.InformationSpots, "Id", "Name");
            ViewBag.SceneId = new SelectList(db.Scenes, "SceneId", "Name");
            return View();
        }

        // POST: InformationSpotButtons/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,SceneId,InformationSpotId,PositionX,PositionY,Rotation")] InformationSpotButton informationSpotButton)
        {
            if (ModelState.IsValid)
            {
                db.InformationSpotButtons.Add(informationSpotButton);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.InformationSpotId = new SelectList(db.InformationSpots, "Id", "Name", informationSpotButton.InformationSpotId);
            ViewBag.SceneId = new SelectList(db.Scenes, "SceneId", "Name", informationSpotButton.SceneId);
            return View(informationSpotButton);
        }

        // GET: InformationSpotButtons/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InformationSpotButton informationSpotButton = db.InformationSpotButtons.Find(id);
            if (informationSpotButton == null)
            {
                return HttpNotFound();
            }
            ViewBag.InformationSpotId = new SelectList(db.InformationSpots, "Id", "Name", informationSpotButton.InformationSpotId);
            ViewBag.SceneId = new SelectList(db.Scenes, "SceneId", "Name", informationSpotButton.SceneId);
            return View(informationSpotButton);
        }

        // POST: InformationSpotButtons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,SceneId,InformationSpotId,PositionX,PositionY,Rotation")] InformationSpotButton informationSpotButton)
        {
            if (ModelState.IsValid)
            {
                db.Entry(informationSpotButton).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.InformationSpotId = new SelectList(db.InformationSpots, "Id", "Name", informationSpotButton.InformationSpotId);
            ViewBag.SceneId = new SelectList(db.Scenes, "SceneId", "Name", informationSpotButton.SceneId);
            return View(informationSpotButton);
        }

        // GET: InformationSpotButtons/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InformationSpotButton informationSpotButton = db.InformationSpotButtons.Find(id);
            if (informationSpotButton == null)
            {
                return HttpNotFound();
            }
            return View(informationSpotButton);
        }

        // POST: InformationSpotButtons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            InformationSpotButton informationSpotButton = db.InformationSpotButtons.Find(id);
            db.InformationSpotButtons.Remove(informationSpotButton);
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
