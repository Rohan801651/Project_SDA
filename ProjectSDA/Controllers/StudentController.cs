using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectSDA.Data;
using ProjectSDA.Models;

namespace ProjectSDA.Controllers
{
    
    public class StudentController : Controller
    {
     
        private readonly AppRepo context;

        public StudentController(AppRepo context)
        {
            this.context = context;
        }


        public IActionResult AllStudents()
        {
            var students = context.Students.Include(s => s.StudentAccount).ToList();
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

        [HttpPost, ActionName("Delete")] // ActionName is used to specify the name of the action method that will be called when the form is submitted
        public IActionResult DeleteConfirmed(int id)
        {
            var Student = context.Students.Find(id);

            if (Student == null)
            {
                return NotFound();
            }
            
            context.Students.Remove(Student);
            context.SaveChanges();
            return View(Student);
        }

        //// details
        //public IActionResult Details(int id)
        //{
        //    var student = context.Students.Find(id);
        //    if (student == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(student);
        //}







    }
}
