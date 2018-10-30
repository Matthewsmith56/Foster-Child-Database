using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FosterSite.Models;

namespace FosterSite.Controllers
{
    public class FosterTablesController : Controller
    {
        private FosterDataEntities db = new FosterDataEntities();

        // GET: FosterTables
        public ActionResult Index()
        {
            return View(db.FosterTables.ToList());
        }

        // GET: FosterTables/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FosterTable fosterTable = db.FosterTables.Find(id);
            if (fosterTable == null)
            {
                return HttpNotFound();
            }
            return View(fosterTable);
        }

        // GET: FosterTables/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FosterTables/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Family_ID,Foster_Family,Type_of_Home,Licensed_Beds,Occupied_Beds,Available_Beds,Min_Age,Max_Age,Preferred_Gender,Agency,P_O_C,Comments")] FosterTable fosterTable)
        {
            if (ModelState.IsValid)
            {
                db.FosterTables.Add(fosterTable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fosterTable);
        }

        // GET: FosterTables/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FosterTable fosterTable = db.FosterTables.Find(id);
            if (fosterTable == null)
            {
                return HttpNotFound();
            }
            return View(fosterTable);
        }

        // POST: FosterTables/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Family_ID,Foster_Family,Type_of_Home,Licensed_Beds,Occupied_Beds,Available_Beds,Min_Age,Max_Age,Preferred_Gender,Agency,P_O_C,Comments")] FosterTable fosterTable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fosterTable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fosterTable);
        }

        // GET: FosterTables/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FosterTable fosterTable = db.FosterTables.Find(id);
            if (fosterTable == null)
            {
                return HttpNotFound();
            }
            return View(fosterTable);
        }

        // POST: FosterTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FosterTable fosterTable = db.FosterTables.Find(id);
            db.FosterTables.Remove(fosterTable);
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
