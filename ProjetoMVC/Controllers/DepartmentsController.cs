using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoMVC.Models;

namespace ProjetoMVC.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Name = "Design" });
            list.Add(new Department { Id = 2, Name = "Web" });

            return View(list);
        }
    }
}
