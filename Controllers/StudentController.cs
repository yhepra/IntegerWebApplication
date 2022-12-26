using IntegerWebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace IntegerWebApplication.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            var student = new Student()
            {
                Id = 1,
                Name = "Dede",
                Address = "Banjarsari City",
                PhoneNumber = "1234567890"
            };

            return View(student);
        }
    }
}
