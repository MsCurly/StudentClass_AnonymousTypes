using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass_AnonymousTypes
{
    public class Class
    {
        private List<Student> students = new List<Student>();
        public void Add(Student student)
        {
            students.Add(student);
        }

        public void Remove(Student student)
        {
            students.Remove(student);
        }

        public List<Student> GetStudentsByName(string name)
        {
            return students.Where(p => p.Name.Contains(name)).ToList();
        }

        public Student GetStudent(int id)
        {
            return students.FirstOrDefault(p => p.Id == id);

        }
    }
}
