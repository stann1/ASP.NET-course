using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcBasics.Data;
using MvcBasics.Helpers;
using DataLayer.Models;

namespace MvcBasics.Controllers
{
    public class StudentsController : Controller
    {
        public static List<Student> Students = new List<Student>() {
            new Student() { Id = 1, Name = "Pesho", Age = 25 },
            new Student() { Id = 2, Name = "Ivan", Age = 19 }
        };

        private readonly IEntryManager _entryManager;

        public StudentsController(IEntryManager entrymanager)
        {
            _entryManager = entrymanager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<string> studentLogData = new List<string>();
            foreach (var student in Students)
            {
                string logitem = student.LogData();
                //Console.WriteLine(logitem);
            }
            Students.Sort((a, b) => { return a.Age - b.Age; });
            return View(Students);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateStudent(Student model)
        {
            if (ModelState.IsValid)
            {
                Student created = model;
                created.Id = Students.Count + 1;
                Students.Add(created);
                _entryManager.FinishCreatingStudent(created);
                return RedirectToAction("Index");
            }

            return View("Create", model);
            
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Student studentToEdit = Students.Find(s => s.Id == id);
            return View(studentToEdit);
        }
    }
}