using Microsoft.AspNetCore.Mvc;
using ProjectSDA.Data;
using ProjectSDA.Models;

namespace ProjectSDA.Controllers
{
    
    public class StudentController : Controller
    {
     
        private readonly StudentRepo context;

        public StudentController(StudentRepo context)
        {
            this.context = context;
        }

        public IActionResult AllStudents()
        {
            var students = context.Students.ToList();
            return View(students);
        }

        public IActionResult StudentView()
        {
            var student = new Student() { Id = 246, name = "Rohan", age = 18};
            return View(student);
        }

        // CURD operations
        // create

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create (Student student)
        {
            if(ModelState.IsValid)
            {
                context.Students.Add(student);
                context.SaveChanges();
                return RedirectToAction("AllStudents");
            }
            return View(student);
        }

        // update
        public IActionResult Update(int id)
        {
            var student = context.Students.Find(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }
        [HttpPost]
        public IActionResult Update(Student student)
        {
            if (ModelState.IsValid)
            {
                context.Students.Update(student);
                context.SaveChanges();
                return RedirectToAction("AllStudents");
            }
            return View(student);
        }

        // delete

        public IActionResult Delete(int id)
        {
            var Student = context.Students.Find(id);
            if(Student == null)
            {
                return NotFound();
            }
            return View(Student);
        }

        // [HttpDelete]

        [HttpPost]
        public IActionResult Delete(Student student)
        {
            if (ModelState.IsValid)
            {
                context.Students.Remove(student);
                context.SaveChanges();
                return RedirectToAction("AllStudents");
            }
            return View(student);
        }
        // details
        public IActionResult Details(int id)
        {
            var student = context.Students.Find(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }





    }
}
