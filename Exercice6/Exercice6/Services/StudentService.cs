using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercice6.Interface;
using Exercice6.Models;

namespace Exercice6.Services
{
    public class StudentService : IStudentServices
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public Student AddStudent(Student student)
        {
            return _studentRepository.AddStudent(student);
        }

        public List<Student> GetAll()
        {
            return _studentRepository.GetAll();
        }
        public Student DeleteStudent(int id)
        {
            return _studentRepository.DeleteStudent(id);
        }

        public Student UpdateStudent(int id)
        {
             return _studentRepository.UpdateStudent(id);
        }

       
    }
}
