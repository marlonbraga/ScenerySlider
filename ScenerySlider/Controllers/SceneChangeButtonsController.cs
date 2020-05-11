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
    public class SceneChangeButtonsController : Controller
    {
        private SceneChangeButtonContext db = new SceneChangeButtonContext();

        // GET: SceneChangeButtons
        public ActionResult Index()
        {
            var sceneChangeButtons = db.SceneChangeButtons.Include(s => s.Scene);
            return View(sceneChangeButtons.ToList());
        }

        // GET: SceneChangeButtons/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SceneChangeButton sceneChangeButton = db.SceneChangeButtons.Find(id);
            if (sceneChangeButton == null)
            {
                return HttpNotFound();
            }
            return View(sceneChangeButton);
        }

        // GET: SceneChangeButtons/Create
        public ActionResult Create()
        {
            ViewBag.SceneId = new SelectList(db.Scenes, "SceneId", "Name");
            return View();
        }

        // POST: SceneChangeButtons/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,SceneId,PositionX,PositionY,Rotation")] SceneChangeButton sceneChangeButton)
        {
            if (ModelState.IsValid)
            {
                db.SceneChangeButtons.Add(sceneChangeButton);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SceneId = new SelectList(db.Scenes, "SceneId", "Name", sceneChangeButton.SceneId);
            return View(sceneChangeButton);
        }

        // GET: SceneChangeButtons/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SceneChangeButton sceneChangeButton = db.SceneChangeButtons.Find(id);
            if (sceneChangeButton == null)
            {
                return HttpNotFound();
            }
            ViewBag.SceneId = new SelectList(db.Scenes, "SceneId", "Name", sceneChangeButton.SceneId);
            return View(sceneChangeButton);
        }

        // POST: SceneChangeButtons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,SceneId,PositionX,PositionY,Rotation")] SceneChangeButton sceneChangeButton)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sceneChangeButton).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SceneId = new SelectList(db.Scenes, "SceneId", "Name", sceneChangeButton.SceneId);
            return View(sceneChangeButton);
        }

        // GET: SceneChangeButtons/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SceneChangeButton sceneChangeButton = db.SceneChangeButtons.Find(id);
            if (sceneChangeButton == null)
            {
                return HttpNotFound();
            }
            return View(sceneChangeButton);
        }

        // POST: SceneChangeButtons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SceneChangeButton sceneChangeButton = db.SceneChangeButtons.Find(id);
            db.SceneChangeButtons.Remove(sceneChangeButton);
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
