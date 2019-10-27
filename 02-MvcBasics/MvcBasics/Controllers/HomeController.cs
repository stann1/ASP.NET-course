using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcBasics.Models;

namespace MvcBasics.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Title"] = "About page";
            return View();
        }

        public IActionResult Students()
        {
            var students = new List<Student>() {
                new Student() { Id = 1, Name = "Pesho", Age = 25 },
                new Student() { Id = 2, Name = "Ivan", Age = 19 }
            };
            
            return View(students);
        }

        public IActionResult Any()
        {
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
