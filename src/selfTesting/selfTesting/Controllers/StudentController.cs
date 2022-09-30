using Microsoft.AspNetCore.Mvc;
using selfTesting.Models;

namespace selfTesting.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            Student student = new Student();
            student.Id = 1;
            student.Name = "Memo";
            student.Address = "Sweden";
            student.Age = 10;
            return View(student);
        }

        public IActionResult GetUsers()
        {
            ViewData["email"] = "eef@gamil.ocm";
            return View("index");
        }
    }
}
