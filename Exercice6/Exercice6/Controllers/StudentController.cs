using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercice6.Interface;
using Exercice6.Models;
using Exercice6.Services;
using Microsoft.AspNetCore.Mvc;

namespace Exercice6.Controllers
{
    [Route("Accueil")]
    public class StudentController : Controller
    {
        private readonly IStudentServices _studentServices;

        public StudentController(IStudentServices studentServices)
        {
            _studentServices = studentServices;
        }

        public IActionResult GetAllStudent()
        {
            List<Student> students = _studentServices.GetAll();
            return View(students);
        }

        [HttpGet("Student")]
        public IActionResult AfficherStudent()
        {
            Student s = new Student();
            return View(s);
        }

        [HttpPost("Student")]
        public IActionResult AjouterStudent(Student student)
        {
            if (!ModelState.IsValid)
            {
                return View("AfficherStudent", student);
            }
            _studentServices.AddStudent(student);
            return RedirectToAction("GetAllStudent");
        }
        [HttpPost("IdDelete")]
        public IActionResult Delete(int id)
        {
            Student student = _studentServices.DeleteStudent(id);
            if (student != null)
            {
                return NotFound();
            }
            return View(student);
        }
        [HttpGet("IdDelete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _studentServices.DeleteStudent(id);
            return RedirectToAction("GetAllStudent");
        }
        [HttpPost("IdUpdate")]
        public IActionResult Update(int id)
        {
            Student student = _studentServices.UpdateStudent(id);
            if (student != null)
            {
                return NotFound();
            }
            return View(student);
        }

        [HttpGet("IdUpdate")]
        public IActionResult UpdateConfirmed(int id)
        {
            _studentServices.UpdateStudent(id);
            return RedirectToAction("GetAllStudent");
        }
    }
}
