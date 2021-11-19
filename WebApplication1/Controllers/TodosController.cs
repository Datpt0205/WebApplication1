using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class TodosController : Controller
    {
        // GET: Todos
        public ActionResult Index()
        {
            Todo todo = new Todo() 
            {
                Id = 1,
                Description = "Buy food",
                DueDate = new DateTime(2021,12,20)
            };
            var todos = new List<Todo>()
            {
                new Todo()
                {
                Id = 1,
                Description = "Buy food",
                DueDate = new DateTime(2021,12,20)
                },
                new Todo()
                {
                Id = 2,
                Description = "Buy drink",
                DueDate = new DateTime(2021,12,20)
                },
                new Todo()
                {
                Id = 3,
                Description = "Do exercise",
                DueDate = new DateTime(2021,12,20)
                }
            };
            return View(todos);
        }
    }
}

