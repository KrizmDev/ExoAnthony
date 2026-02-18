using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercice6.DbManager;
using Exercice6.Interface;
using Exercice6.Models;

namespace Exercice6.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentDbContext _context;
        public StudentRepository(StudentDbContext context)
        {
            _context = context;
        }
        public Student AddStudent (Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return student;
        }
        public List<Student> GetAll() 
        {
            return _context.Students.ToList();
        }

        public Student RemoveStudent (int id)
        {
            Student sTudent =_context.Students.Where(x => x.Id == id).FirstOrDefault();
            _context.Students.Remove(sTudent);
            _context.SaveChanges ();
            return sTudent;
        }
        public Student Update (int id)
        {
            Student sTudent = _context.Students.Where(x=>x.Id == id).FirstOrDefault();
            _context.Students.Update(sTudent);
            _context.SaveChanges();
            return sTudent;
        }
    }
}
