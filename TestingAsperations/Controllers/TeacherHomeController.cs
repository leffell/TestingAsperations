////////////////////////////////////////////////////////////////////////////////
/// Change History
/// Developer   Date    Description
/// Laurie      2/10    Added dependency injection method to the controller.
///

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestingAsperations.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestingAsperations.Controllers
{
    public class TeacherHomeController : Controller
    {
        private readonly ITeacherHomeRepo _teacherHomeRepo;
        // dependency injection for creating a new instance for the interface if one doesn't already exist.
        public TeacherHomeController(ITeacherHomeRepo teacherHome)
        {
            _teacherHomeRepo = teacherHome;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var courses = _teacherHomeRepo.GetAllCourses().OrderBy(c => c.CourseId);

            return View(courses);
        }
    }
}
