using System.Web.Mvc;
using QAForum.Models;

namespace QAForum.Controllers
{
    public class ForumController : Controller
    {
        //
        // GET: /Forum/

        public ActionResult Index()
        {
            IForumRepository tmpRep = new SQLForumRepository();
            var result = tmpRep.GetAllForums();
            ViewBag.Message = "QA Forum List";
            return View(result);
        }

        //
        // GET: /Forum/Details/5

        public ActionResult Details(int id)
        {
            IForumRepository tmpRep = new SQLForumRepository();
            var result = tmpRep.GetForumByID(id);
            ViewBag.Message = "Forum detail";
            return View(result);
        }

        //
        // GET: /Forum/Create

        public ActionResult Create()
        {
            Forum forum = new Forum();
            return View(forum);
        } 

        //
        // POST: /Forum/Create

        [HttpPost]
        public ActionResult Create(Forum forum)
        {
            try
            {
                IForumRepository tmpRep = new SQLForumRepository();
                tmpRep.AddForum(forum);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Forum/Edit/5
 
        public ActionResult Edit(int id)
        {
            IForumRepository tmpRep = new SQLForumRepository();
            var result = tmpRep.GetForumByID(id);
            return View(result);
        }

        //
        // POST: /Forum/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, Forum forum)
        {
            try
            {
                // TODO: Add update logic here

                IForumRepository tmpRep = new SQLForumRepository();
                tmpRep.UpdateForum(forum);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Forum/Delete/5
 
        public ActionResult Delete(int id)
        {
            IForumRepository tmpRep = new SQLForumRepository();
            var result = tmpRep.GetForumByID(id);
            return View();
        }

        //
        // POST: /Forum/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                IForumRepository tmpRep = new SQLForumRepository();
                var forum= tmpRep.GetForumByID(id);
                tmpRep.DeleteForum(forum);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
