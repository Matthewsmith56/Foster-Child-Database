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
        public ViewResult Index(string sortOrder, string searchString)
        {
            ViewBag.FamilySortParm = "Foster_Family_desc";
            ViewBag.TypeSortParm = "Type_of_Home_desc";
            ViewBag.GenderSortParm = "Preferred_Gender_desc";
            ViewBag.AgencySortParm = "Agency_desc";
            ViewBag.NumberSortParm = "Licensed_Beds_desc";

            ViewBag.SortParm       = String.IsNullOrEmpty(sortOrder) ? "Type_of_Home_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";
            var Data = from s in db.FosterTables
                select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                Data = Data.Where(s => s.Foster_Family.Contains(searchString) 
                       || s.Agency.Contains(searchString) || s.POC.Contains(searchString) || s.Comments.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "Foster_Family_desc":
                    ViewBag.FamilySortParm = "Foster_Family_asc";
                    Data = Data.OrderByDescending(s => s.Foster_Family);
                    break;
                case "Foster_Family_asc":
                    ViewBag.FamilySortParm = "Foster_Family_desc";
                    Data = Data.OrderBy(s => s.Foster_Family);
                    break;
                case "Type_of_Home_desc":
                    ViewBag.TypeSortParm = "Type_of_Home_asc";
                    Data = Data.OrderByDescending(s => s.Type_of_Home);
                    break;
                case "Type_of_Home_asc":
                    ViewBag.TypeSortParm = "Type_of_Home_desc";
                    Data = Data.OrderBy(s => s.Type_of_Home);
                    break;
                case "Preferred_Gender_desc":
                    ViewBag.GenderSortParm = "Preferred_Gender_asc";
                    Data = Data.OrderByDescending(s => s.Preferred_Gender);
                    break;
                case "Preferred_Gender_asc":
                    ViewBag.GenderSortParm = "Preferred_Gender_desc";
                    Data = Data.OrderBy(s => s.Preferred_Gender);
                    break;
                case "Agency_desc":
                    ViewBag.AgencySortParm = "Agency_asc";
                    Data = Data.OrderByDescending(s => s.Agency);
                    break;
                case "Agency_asc":
                    ViewBag.AgencySortParm = "Agency_desc";
                    Data = Data.OrderBy(s => s.Agency);
                    break;
                case "Licensed_Beds_desc":
                    ViewBag.NumberSortParm = "Licensed_Beds_asc";
                    Data = Data.OrderByDescending(s => s.Licensed_Beds);
                    break;
                case "Licensed_Beds_asc":
                    ViewBag.NumberSortParm = "Licensed_Beds_desc";
                    Data = Data.OrderBy(s => s.Licensed_Beds);
                    break;
            }
            return View(Data.ToList());
        }
        //public ActionResult Index()
        //{
        //    return View(db.FosterTables.ToList());
        //}

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
        public ActionResult Create([Bind(Include = "Family_ID,Foster_Family,Type_of_Home,Licensed_Beds,Occupied_Beds,Available_Beds,Min_Age,Max_Age,Preferred_Gender,Agency,POC,Comments")] FosterTable fosterTable)
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
        public ActionResult Edit([Bind(Include = "Family_ID,Foster_Family,Type_of_Home,Licensed_Beds,Occupied_Beds,Available_Beds,Min_Age,Max_Age,Preferred_Gender,Agency,POC,Comments")] FosterTable fosterTable)
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

        public ActionResult FosterIndex()
        {
            return View(db.FosterTables.ToList());
        }
    }
}
