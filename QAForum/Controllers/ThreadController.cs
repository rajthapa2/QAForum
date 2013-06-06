using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QAForum.Models;

namespace QAForum.Controllers
{
    public class ThreadController : Controller
    {
        //
        // GET: /Thread/

        public ActionResult Index()
        {
            IForumRepository tmpRep = new SQLForumRepository();
            var result = tmpRep.GetAllThreads();
            ViewBag.Message = "QA Forums list [threads]";
            return View(result);
        }

        //
        // GET: /Thread/Details/5

        public ActionResult Details(int id)
        {
            IForumRepository tmpRep = new SQLForumRepository();
            var result= tmpRep.GetThreadByID(id);
            ViewBag.Message = "Thread Detail";
            return View(result);
        }

        //
        // GET: /Thread/Create

        public ActionResult Create()
        {
            Thread thread = new Thread();
            return View(thread);
        } 

        //
        // POST: /Thread/Create

        [HttpPost]
        public ActionResult Create(Thread thread)
        {
            try
            {
                // TODO: Add insert logic here

                IForumRepository tmpRep = new SQLForumRepository();
                tmpRep.AddThread(thread);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Thread/Edit/5
 
        public ActionResult Edit(int id)
        {

            IForumRepository tmpRep = new SQLForumRepository();
            var thread = tmpRep.GetThreadByID(id);
            return View(thread);
        }

        //
        // POST: /Thread/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, Thread thread)
        {
            try
            {
                // TODO: Add update logic here

                IForumRepository tmpRep = new SQLForumRepository();
                tmpRep.UpdateThread(thread);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Thread/Delete/5
 
        public ActionResult Delete(int id)
        {
            IForumRepository tmpRep = new SQLForumRepository();
            var thread = tmpRep.GetThreadByID(id);
            tmpRep.DeleteThread(thread);
            return View(thread);
        }

        //
        // POST: /Thread/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, Thread thread)
        {
            try
            {
                // TODO: Add delete logic here

                IForumRepository tmpRep = new SQLForumRepository();
                tmpRep.DeleteThread(thread);
                return RedirectToAction("Index");

                //IForumRepository tmpRep = new SQLForumRepository();

                //var thread = tmpRep.GetThreadByID(id);

                //tmpRep.DeleteThread(thread);

                //return RedirectToAction("Index");


            }
            catch
            {
                return View();
            }
        }
    }
}
