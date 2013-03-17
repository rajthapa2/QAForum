using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
            return View();
        } 

        //
        // POST: /Forum/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

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
            return View();
        }

        //
        // POST: /Forum/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
 
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
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
