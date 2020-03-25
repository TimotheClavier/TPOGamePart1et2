using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TPOgame.BO;
using TPOgame.Data;

namespace TPOgame.Controllers
{
    public class ResourceGeneratorsController : Controller
    {
        private TPOgameContext db = new TPOgameContext();

        // GET: ResourceGenerators
        public ActionResult Index()
        {
            return View(db.ResourceGenerators.ToList());
        }

        // GET: ResourceGenerators/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ResourceGenerator resourceGenerator = db.ResourceGenerators.Find(id);
            if (resourceGenerator == null)
            {
                return HttpNotFound();
            }
            return View(resourceGenerator);
        }

        // GET: ResourceGenerators/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ResourceGenerators/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,name,level")] ResourceGenerator resourceGenerator)
        {
            if (ModelState.IsValid)
            {
                db.ResourceGenerators.Add(resourceGenerator);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(resourceGenerator);
        }

        // GET: ResourceGenerators/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ResourceGenerator resourceGenerator = db.ResourceGenerators.Find(id);
            if (resourceGenerator == null)
            {
                return HttpNotFound();
            }
            return View(resourceGenerator);
        }

        // POST: ResourceGenerators/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,name,level")] ResourceGenerator resourceGenerator)
        {
            if (ModelState.IsValid)
            {
                db.Entry(resourceGenerator).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(resourceGenerator);
        }

        // GET: ResourceGenerators/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ResourceGenerator resourceGenerator = db.ResourceGenerators.Find(id);
            if (resourceGenerator == null)
            {
                return HttpNotFound();
            }
            return View(resourceGenerator);
        }

        // POST: ResourceGenerators/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            ResourceGenerator resourceGenerator = db.ResourceGenerators.Find(id);
            db.ResourceGenerators.Remove(resourceGenerator);
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
