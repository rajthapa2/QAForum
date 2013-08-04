using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QAForum.Models;

namespace QAForum.Controllers
{
    public class PostController : Controller
    {
        //
        // GET: /Post/

        public ActionResult Index()
        {
            IForumRepository tmpRep = new SQLForumRepository();

            var result = tmpRep.GetAllPosts();

            ViewBag.Message = "QA Forums list [posts]";

            return View(result);
        }

        //
        // GET: /Post/Details/5

        public ActionResult Details(int id)
        {
            IForumRepository tmpRep = new SQLForumRepository();

            var result = tmpRep.GetPostByID(id);

            ViewBag.Message = "Post detail";

            return View(result);
        }

        //
        // GET: /Post/Create

        public ActionResult Create()
        {
            Post post = new Post();

            return View(post);
        } 

        //
        // POST: /Post/Create

        [HttpPost]
        public ActionResult Create(Post post)
        {
            try
            {
                // TODO: Add insert logic here

                IForumRepository tmpRep = new SQLForumRepository();

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
            IForumRepository tmpRep = new SQLForumRepository();

            var result = tmpRep.GetPostByID(id);

            return View(result);
        }

        //
        // POST: /Post/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, Post post)
        {
            try
            {
                // TODO: Add update logic here

                IForumRepository tmpRep = new SQLForumRepository();

                tmpRep.UpdatePost(post);

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
            IForumRepository tmpRep = new SQLForumRepository();

            var result = tmpRep.GetPostByID(id);

            return View(result);
        }

        //
        // POST: /Post/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                IForumRepository tmpRep = new SQLForumRepository();

                var post = tmpRep.GetPostByID(id);

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
