using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercice6.Models;

namespace Exercice6.Interface
{
    public interface IStudentServices
    {
        public List<Student> GetAll();
        public Student AddStudent(Student student);

        public Student UpdateStudent(int id);

        public Student DeleteStudent(int id);
    }
}
