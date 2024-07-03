using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NhmK22CNT3Lesson10Db.Models;

namespace NhmK22CNT3Lesson10Db.Controllers
{
    public class NhmAccountsController : Controller
    {
        private NhmK22CNT3LS10dbEntities db = new NhmK22CNT3LS10dbEntities();

        // GET: NhmAccounts
        public ActionResult Index()
        {
            return View(db.NhmAccounts.ToList());
        }

        // GET: NhmAccounts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhmAccount nhmAccount = db.NhmAccounts.Find(id);
            if (nhmAccount == null)
            {
                return HttpNotFound();
            }
            return View(nhmAccount);
        }

        // GET: NhmAccounts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NhmAccounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NhmID,NhmUserName,NhmPassword,NhmFullName,NhmEmail,NhmPhone,NhmActive")] NhmAccount nhmAccount)
        {
            if (ModelState.IsValid)
            {
                db.NhmAccounts.Add(nhmAccount);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nhmAccount);
        }

        // GET: NhmAccounts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhmAccount nhmAccount = db.NhmAccounts.Find(id);
            if (nhmAccount == null)
            {
                return HttpNotFound();
            }
            return View(nhmAccount);
        }

        // POST: NhmAccounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NhmID,NhmUserName,NhmPassword,NhmFullName,NhmEmail,NhmPhone,NhmActive")] NhmAccount nhmAccount)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nhmAccount).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nhmAccount);
        }

        // GET: NhmAccounts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhmAccount nhmAccount = db.NhmAccounts.Find(id);
            if (nhmAccount == null)
            {
                return HttpNotFound();
            }
            return View(nhmAccount);
        }

        // POST: NhmAccounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NhmAccount nhmAccount = db.NhmAccounts.Find(id);
            db.NhmAccounts.Remove(nhmAccount);
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
        [HttpPost]
        public ActionResult NhmLogin()
        {
            var nhmModel = new NhmAccount();

            return View(nhmModel);
        }
        public ActionResult NhmLogin(NhmAccount nhmAccount)
        {
            var nhmCheck = db.NhmAccounts.Where(x => x.NhmUserName.Equals(nhmAccount.NhmUserName) && x.NhmPassword.Equals(nhmAccount.NhmUserName)).FirstOrDefault();
            if(nhmCheck != null)
            {
                //Luu session
                Session["NhmAccount"] = nhmCheck;
                return Redirect("/");
            }
            return View(nhmAccount);
        }
    }
}
