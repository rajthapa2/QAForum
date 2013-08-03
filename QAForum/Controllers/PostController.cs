using System.Web.Mvc;
using QAForum.Models;

namespace QAForum.Controllers
{
    public class PostController : Controller
    {
        private IForumRepository tmpRep = new SQLForumRepository();
        
        
        //
        // GET: /Post/

        public ActionResult Index()
        {
            ViewBag.Message = "Posts";

            var result = tmpRep.GetAllPosts();
            return View(result);
        }

        //
        // GET: /Post/Details/5

        public ActionResult Details(int id)
        {
            ViewBag.Message = "Detail";
            var result = tmpRep.GetPostByID(id);
            return View(result);
        }

        //
        // GET: /Post/Create

        public ActionResult Create()
        {
            ViewBag.Message = "Create";
            return View(new Post());               
        } 

        //
        // POST: /Post/Create

        [HttpPost]
        public ActionResult Create(Post post)
        {
            try
            {
                // TODO: Add insert logic here

                tmpRep.AddPost(post);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Post/Edit/5
 
        public ActionResult Edit(int id)
        {
            ViewBag.Message = "Edit";
            var result=tmpRep.GetPostByID(id);
            return View(result);
        }

        //
        // POST: /Post/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, Post post)
        {
            try
            {
                tmpRep.UpdatePost(post);
                // TODO: Add update logic here);
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Post/Delete/5
 
        public ActionResult Delete(int id)
        {
            ViewBag.Message = "Delete";
            var result = tmpRep.GetPostByID(id);
            return View(result);
        }

        //
        // POST: /Post/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, Post post)
        {
            try
            {
                // TODO: Add delete logic here
                tmpRep.DeletePost(post);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
