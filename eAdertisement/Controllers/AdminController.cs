using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using eAdertisement.Models;

namespace eAdertisement.Controllers
{
    public class AdminController : Controller
    {
        private eAdvertisementContext db = new eAdvertisementContext();

        // GET: Admin
        public ActionResult Index()
        {
            var vacancies = db.Vacancies.Include(v => v.Department).Include(v => v.ExpiredVacancy).Include(v => v.PendingVacancy).Include(v => v.PublishedVacancy).Include(v => v.UnpublishedVacancy);
            return View(vacancies.ToList());
        }

        // GET: Admin/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vacancy vacancy = db.Vacancies.Find(id);
            if (vacancy == null)
            {
                return HttpNotFound();
            }
            return View(vacancy);
        }

        // GET: Admin/Create
        public ActionResult Create()
        {
            ViewBag.DepartmentId = new SelectList(db.Departments, "DepartmentId", "Name");
            ViewBag.ExpiredVacancyId = new SelectList(db.ExpiredVacancies, "ExpiredVacancyId", "Post");
            ViewBag.PendingVacancyId = new SelectList(db.PendingVacancies, "PendingVacancyId", "Post");
            ViewBag.PublishedVacancyId = new SelectList(db.PublishedVacancies, "PublishedVacancyId", "Post");
            ViewBag.UnpublishedVacancyId = new SelectList(db.UnpublishedVacancies, "UnpublishedVacancyId", "Post");
            return View();
        }

        // POST: Admin/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "VacancyId,ExpiredVacancyId,DepartmentId,PendingVacancyId,PublishedVacancyId,UnpublishedVacancyId,Post,Attention,ClosingDate,Telephone,Salary,Centre,Application,Requirements,Note,Duties,ReferenceNo,Level")] Vacancy vacancy)
        {
            if (ModelState.IsValid)
            {
                db.Vacancies.Add(vacancy);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DepartmentId = new SelectList(db.Departments, "DepartmentId", "Name", vacancy.DepartmentId);
            ViewBag.ExpiredVacancyId = new SelectList(db.ExpiredVacancies, "ExpiredVacancyId", "Post", vacancy.ExpiredVacancyId);
            ViewBag.PendingVacancyId = new SelectList(db.PendingVacancies, "PendingVacancyId", "Post", vacancy.PendingVacancyId);
            ViewBag.PublishedVacancyId = new SelectList(db.PublishedVacancies, "PublishedVacancyId", "Post", vacancy.PublishedVacancyId);
            ViewBag.UnpublishedVacancyId = new SelectList(db.UnpublishedVacancies, "UnpublishedVacancyId", "Post", vacancy.UnpublishedVacancyId);
            return View(vacancy);
        }

        // GET: Admin/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vacancy vacancy = db.Vacancies.Find(id);
            if (vacancy == null)
            {
                return HttpNotFound();
            }
            ViewBag.DepartmentId = new SelectList(db.Departments, "DepartmentId", "Name", vacancy.DepartmentId);
            ViewBag.ExpiredVacancyId = new SelectList(db.ExpiredVacancies, "ExpiredVacancyId", "Post", vacancy.ExpiredVacancyId);
            ViewBag.PendingVacancyId = new SelectList(db.PendingVacancies, "PendingVacancyId", "Post", vacancy.PendingVacancyId);
            ViewBag.PublishedVacancyId = new SelectList(db.PublishedVacancies, "PublishedVacancyId", "Post", vacancy.PublishedVacancyId);
            ViewBag.UnpublishedVacancyId = new SelectList(db.UnpublishedVacancies, "UnpublishedVacancyId", "Post", vacancy.UnpublishedVacancyId);
            return View(vacancy);
        }

        // POST: Admin/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VacancyId,ExpiredVacancyId,DepartmentId,PendingVacancyId,PublishedVacancyId,UnpublishedVacancyId,Post,Attention,ClosingDate,Telephone,Salary,Centre,Application,Requirements,Note,Duties,ReferenceNo,Level")] Vacancy vacancy)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vacancy).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DepartmentId = new SelectList(db.Departments, "DepartmentId", "Name", vacancy.DepartmentId);
            ViewBag.ExpiredVacancyId = new SelectList(db.ExpiredVacancies, "ExpiredVacancyId", "Post", vacancy.ExpiredVacancyId);
            ViewBag.PendingVacancyId = new SelectList(db.PendingVacancies, "PendingVacancyId", "Post", vacancy.PendingVacancyId);
            ViewBag.PublishedVacancyId = new SelectList(db.PublishedVacancies, "PublishedVacancyId", "Post", vacancy.PublishedVacancyId);
            ViewBag.UnpublishedVacancyId = new SelectList(db.UnpublishedVacancies, "UnpublishedVacancyId", "Post", vacancy.UnpublishedVacancyId);
            return View(vacancy);
        }

        // GET: Admin/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vacancy vacancy = db.Vacancies.Find(id);
            if (vacancy == null)
            {
                return HttpNotFound();
            }
            return View(vacancy);
        }

        // POST: Admin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Vacancy vacancy = db.Vacancies.Find(id);
            db.Vacancies.Remove(vacancy);
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
