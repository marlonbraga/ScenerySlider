﻿using System;
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
    public class ScenesController : Controller
    {
        private SceneContext db = new SceneContext();

        // GET: Scenes
        public ActionResult Index()
        {
            var scenes = db.Scenes.Include(s => s.InformationSpotButton).Include(s => s.Project);
            return View(scenes.ToList());
        }

        // GET: Scenes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Scene scene = db.Scenes.Find(id);
            if (scene == null)
            {
                return HttpNotFound();
            }
            return View(scene);
        }

        // GET: Scenes/Create
        public ActionResult Create()
        {
            ViewBag.InformationSpotButtonId = new SelectList(db.InformationSpotButtons, "Id", "Id");
            ViewBag.ProjectId = new SelectList(db.Projects, "Id", "Name");
            return View();
        }

        // POST: Scenes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ProjectId,InformationSpotButtonId")] Scene scene)
        {
            if (ModelState.IsValid)
            {
                db.Scenes.Add(scene);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.InformationSpotButtonId = new SelectList(db.InformationSpotButtons, "Id", "Id", scene.InformationSpotButtonId);
            ViewBag.ProjectId = new SelectList(db.Projects, "Id", "Name", scene.ProjectId);
            return View(scene);
        }

        // GET: Scenes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Scene scene = db.Scenes.Find(id);
            if (scene == null)
            {
                return HttpNotFound();
            }
            ViewBag.InformationSpotButtonId = new SelectList(db.InformationSpotButtons, "Id", "Id", scene.InformationSpotButtonId);
            ViewBag.ProjectId = new SelectList(db.Projects, "Id", "Name", scene.ProjectId);
            return View(scene);
        }

        // POST: Scenes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ProjectId,InformationSpotButtonId")] Scene scene)
        {
            if (ModelState.IsValid)
            {
                db.Entry(scene).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.InformationSpotButtonId = new SelectList(db.InformationSpotButtons, "Id", "Id", scene.InformationSpotButtonId);
            ViewBag.ProjectId = new SelectList(db.Projects, "Id", "Name", scene.ProjectId);
            return View(scene);
        }

        // GET: Scenes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Scene scene = db.Scenes.Find(id);
            if (scene == null)
            {
                return HttpNotFound();
            }
            return View(scene);
        }

        // POST: Scenes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Scene scene = db.Scenes.Find(id);
            db.Scenes.Remove(scene);
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