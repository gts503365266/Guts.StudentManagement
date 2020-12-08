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
        public IActionResult Details(int id)
        {
            Student model = _studentRepository.GetStudent(id);
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                PageTitle = "学生详细信息",
                Student = model
            };
            return View(homeDetailsViewModel);
        }
    }
}
