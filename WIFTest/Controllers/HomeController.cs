using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace WIFTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IIdentity identity;
            IPrincipal principal;
            var currentUser = this.HttpContext.User;
            currentUser = Thread.CurrentPrincipal;

            ViewBag.ClaimsIdentity = Thread.CurrentPrincipal.Identity;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}