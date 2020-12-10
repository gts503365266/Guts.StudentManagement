using Microsoft.AspNetCore.Mvc;
using StudentManagement.Models;
using StudentManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        //使用构造函数注入的方式注入IStudentRepository
        public HomeController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;

        }

        public IActionResult Index()
        {
            var students = _studentRepository.GetAllStudent();
            return View(students);
        }

        public ViewResult Details(int? id, string name)
        {
            Student model = _studentRepository.GetStudent(id ?? 1);
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                PageTitle = "学生详细信息",
                Student = model
            };
            return View(homeDetailsViewModel);
            //return $"id=={id},name=={name}";
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                Student newStudent = _studentRepository.Add(student);
                return RedirectToAction("Details", new { id = newStudent.Id });
            }
            else
            {
                return View();
            }

        }
    }
}
