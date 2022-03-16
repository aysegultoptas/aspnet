using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Odev3.Models;

namespace Odev3.Controllers
{
    
    public class CalisanController : Controller
    {

        private calisanlarEntities db = new calisanlarEntities();
        
        // GET: Calisan
        [Authorize(Users ="admin@ays.com")]
        public ActionResult Index()
        {
            return View(db.Table.ToList());
        }

        // GET: Calisan/Details/5
        [Authorize(Users = "admin@ays.com")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Table.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // GET: Calisan/Create
        [Authorize(Users = "admin@ays.com")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Calisan/Create
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Users = "admin@ays.com")]
        public ActionResult Create([Bind(Include = "Id,Ad,Soyad,Alan")] Table table)
        {
            if (ModelState.IsValid)
            {
                db.Table.Add(table);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(table);
        }

        // GET: Calisan/Edit/5
        [Authorize(Users = "admin@ays.com")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Table.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // POST: Calisan/Edit/5
        

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Users = "admin@ays.com")]
        public ActionResult Edit([Bind(Include = "Id,Ad,Soyad,Alan")] Table table)
        {
            if (ModelState.IsValid)
            {
                db.Entry(table).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(table);
        }

        // GET: Calisan/Delete/5
        [Authorize(Users = "admin@ays.com")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Table.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // POST: Calisan/Delete/5
        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Users = "admin@ays.com")]
        public ActionResult DeleteConfirmed(int id)
        {
            Table table = db.Table.Find(id);
            db.Table.Remove(table);
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
