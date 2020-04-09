using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ToDoListSample.Controllers
{
    public class TaskController : ApiController
    {

        TasksListContext db = new TasksListContext();
        public IEnumerable<taskList> getAllTask()
        {
            return db.taskLists.ToList();
        }
    }
}
