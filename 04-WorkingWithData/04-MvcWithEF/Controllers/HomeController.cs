using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _04_MvcWithEF.Models;
using Microsoft.EntityFrameworkCore;
using DataLayer;

namespace _04_MvcWithEF.Controllers
{
    public class HomeController : Controller
    {
        public SchoolDBContext Context { get; }

        public HomeController(SchoolDBContext context)
        {
            Context = context;
        }

        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult ListStudents()
        {
            var students = Context.Students.ToList();
            return View(students);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var result = Context.Students.FirstOrDefault(s => s.Id == id);
            return View(result);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
