using Microsoft.AspNetCore.Mvc;
using ProjectSDA.Models;

namespace ProjectSDA.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Teachers()
        {
            Teacher teacher = new Teacher(
                1,
                "Sir Fawad",
                "fawad@zab.pk",
                "HCI"
                );
            return View(teacher);
        }

        





    }
}
