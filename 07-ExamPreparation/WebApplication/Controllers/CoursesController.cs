using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication.Data;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CoursesController(ApplicationDbContext context)
        {
            this._context = context;
        }

        public IActionResult Index()
        {
            var courses = _context.Courses.Include("Students").ToList();
            return View(courses);
        }

        public IActionResult Details(int id)
        {
            var course = _context.Courses.Include("Students").FirstOrDefault(c => c.Id == id);
            return View(course);
        }
    }
}