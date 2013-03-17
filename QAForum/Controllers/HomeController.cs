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
            //ForumEntities forumDB = new ForumEntities();
            //var result = forumDB.Forums.ToList();

            IForumRepository tempRep = new SQLForumRepository();
            var result = tempRep.GetAllForums();
            ViewBag.Message = "Welcome to QA Forum!";

            return View(result);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
