using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjectMVC.Models;

namespace ProjectMVC.Controllers
{
    public class UserProjectsController : Controller
    {
        private ChallengeModel db = new ChallengeModel();

        // GET: UserProjects
        public ActionResult Index()
        {
            var userProject = db.UserProject.Include(u => u.Project).Include(u => u.User);
            return View(userProject.ToList());
        }

        // GET: UserProjects/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserProject userProject = db.UserProject.Find(id);
            if (userProject == null)
            {
                return HttpNotFound();
            }
            return View(userProject);
        }

        // GET: UserProjects/Create
        public ActionResult Create()
        {
            ViewBag.ProjectId = new SelectList(db.Project, "Id", "Id");
            ViewBag.UserId = new SelectList(db.User, "Id", "FirstName");
            return View();
        }

        // POST: UserProjects/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserId,ProjectId,IsActive,AsignedDate")] UserProject userProject)
        {
            if (ModelState.IsValid)
            {
                db.UserProject.Add(userProject);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ProjectId = new SelectList(db.Project, "Id", "Id", userProject.ProjectId);
            ViewBag.UserId = new SelectList(db.User, "Id", "FirstName", userProject.UserId);
            return View(userProject);
        }

        // GET: UserProjects/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserProject userProject = db.UserProject.Find(id);
            if (userProject == null)
            {
                return HttpNotFound();
            }
            ViewBag.ProjectId = new SelectList(db.Project, "Id", "Id", userProject.ProjectId);
            ViewBag.UserId = new SelectList(db.User, "Id", "FirstName", userProject.UserId);
            return View(userProject);
        }

        // POST: UserProjects/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserId,ProjectId,IsActive,AsignedDate")] UserProject userProject)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userProject).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ProjectId = new SelectList(db.Project, "Id", "Id", userProject.ProjectId);
            ViewBag.UserId = new SelectList(db.User, "Id", "FirstName", userProject.UserId);
            return View(userProject);
        }

        // GET: UserProjects/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserProject userProject = db.UserProject.Find(id);
            if (userProject == null)
            {
                return HttpNotFound();
            }
            return View(userProject);
        }

        // POST: UserProjects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UserProject userProject = db.UserProject.Find(id);
            db.UserProject.Remove(userProject);
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
