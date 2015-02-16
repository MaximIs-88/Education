using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Web.Mvc;

namespace AspNETMVCTest.Controllers
{
    public class Test1Controller : Controller
    {
        //
        // GET: /Test1/
        public ActionResult Index()
        {
            ViewBag.VisitorNumber = new Random().Next(1, 100);
            return View();
        }

        public ActionResult TestIndex()
        {
            return this.RedirectToAction<AccountController>(c => c.Register());
        }
	}
}