using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using QAForum.Models;


namespace QAForum.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            ViewBag.Message = "Welcome to the QA Forum!";

            return View();

        }

        public ActionResult About()
        {
            return View();
        }
    }
}
