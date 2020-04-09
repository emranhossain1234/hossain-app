using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ToDoListSample.Controllers
{
    public class TasksController : Controller
    {

        TasksListContext db = new TasksListContext();
        // GET: Tasks
        public ActionResult Index()
        {
            return View(db.taskLists.ToList());
        }

        public ActionResult Create ()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create (taskList task)
        {

            if(ModelState.IsValid)
            {
                db.taskLists.Add(task);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(task);
        }
    }
}