using Microsoft.AspNetCore.Mvc;
using ModelsInASPCore.Models;
using ModelsInASPCore.Repository;
using System.Diagnostics;

namespace ModelsInASPCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StudentRepository _studentRepository = null;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _studentRepository = new StudentRepository();
        }

        public List<StudentModel> GetAllStudents()
        {
            return _studentRepository.getAllStudents();
        }

        public StudentModel getByID(int id)
        {
            return _studentRepository.getStudentById(id);
        }


        public IActionResult Index()
        {
            //var students = new List<StudentModel>
            //{
            //    new StudentModel { rollNo = 1,Name = "Kumar",Gender="Male", Standard = 10 },
            //    new StudentModel { rollNo = 2, Name = "Adil",Gender="Male", Standard = 10 },
            //    new StudentModel { rollNo = 3, Name = "Natasha",Gender="Female", Standard = 11 }
            //};

            //ViewData["myStudents"] = students;

            return View();
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
