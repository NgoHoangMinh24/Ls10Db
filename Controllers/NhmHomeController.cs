using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NhmK22CNT3Lesson10Db.Controllers
{
    public class NhmHomeController : Controller
    {
        public ActionResult NhmIndex()
        {
            //Kiem tra du lieu trong session
            if (Session["NhmAccount"] != null )
            {
                var nhmAccount = Session["NhmAccount"] as NhmAccount;
                ViewBag.FullName = nhmAccount.NhmFullName;  
            }
            return View();
        }

        public ActionResult NhmAbout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult NhmContact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}