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
    public class SceneButtonsController : Controller
    {
        private InformationSpotButtonContext db = new InformationSpotButtonContext();

        // GET: SceneButtons
        public ActionResult Index()
        {
            var sceneButtons = db.SceneButtons.Include(s => s.OwnerScene).Include(s => s.TargetScene);
            return View(sceneButtons.ToList());
        }

        // GET: SceneButtons/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SceneButton sceneButton = db.SceneButtons.Find(id);
            if (sceneButton == null)
            {
                return HttpNotFound();
            }
            return View(sceneButton);
        }

        // GET: SceneButtons/Create
        public ActionResult Create()
        {
            ViewBag.OwnerSceneId = new SelectList(db.Scenes, "SceneId", "Name");
            ViewBag.TargetSceneId = new SelectList(db.Scenes, "SceneId", "Name");
            return View();
        }

        // POST: SceneButtons/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,TargetSceneId,OwnerSceneId,Icon,PositionX,PositionY,Rotation")] SceneButton sceneButton)
        {
            if (ModelState.IsValid)
            {
                db.SceneButtons.Add(sceneButton);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.OwnerSceneId = new SelectList(db.Scenes, "SceneId", "Name", sceneButton.OwnerSceneId);
            ViewBag.TargetSceneId = new SelectList(db.Scenes, "SceneId", "Name", sceneButton.TargetSceneId);
            return View(sceneButton);
        }

        // GET: SceneButtons/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SceneButton sceneButton = db.SceneButtons.Find(id);
            if (sceneButton == null)
            {
                return HttpNotFound();
            }
            ViewBag.OwnerSceneId = new SelectList(db.Scenes, "SceneId", "Name", sceneButton.OwnerSceneId);
            ViewBag.TargetSceneId = new SelectList(db.Scenes, "SceneId", "Name", sceneButton.TargetSceneId);
            return View(sceneButton);
        }

        // POST: SceneButtons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,TargetSceneId,OwnerSceneId,Icon,PositionX,PositionY,Rotation")] SceneButton sceneButton)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sceneButton).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.OwnerSceneId = new SelectList(db.Scenes, "SceneId", "Name", sceneButton.OwnerSceneId);
            ViewBag.TargetSceneId = new SelectList(db.Scenes, "SceneId", "Name", sceneButton.TargetSceneId);
            return View(sceneButton);
        }

        // GET: SceneButtons/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SceneButton sceneButton = db.SceneButtons.Find(id);
            if (sceneButton == null)
            {
                return HttpNotFound();
            }
            return View(sceneButton);
        }

        // POST: SceneButtons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SceneButton sceneButton = db.SceneButtons.Find(id);
            db.SceneButtons.Remove(sceneButton);
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
