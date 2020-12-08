using Microsoft.AspNetCore.Mvc;
using StudentManagement.Models;
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
        public string Index()
        {
            return _studentRepository.GetStudent(1).Name;
        }
        public IActionResult Details()
        {
            Student model = _studentRepository.GetStudent(1);                   
            return View(model);
        }
    }
}
