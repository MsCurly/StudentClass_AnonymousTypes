using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass_AnonymousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var pro2 = GetStudent();

            var list = new Class();
            list.Add(new Student { Id = 1, Name = "Züleyha Abazi" });
            list.Add(new Student { Id = 2, Name = "Esra Korkmaz" });
            list.Add(new Student { Id = 3, Name = "Duru Korkmaz" });
            list.Add(new Student { Id = 4, Name = "Enes Özlen" });
            list.Add(new Student { Id = 5, Name = "Ege Nesin" });
            list.Add(new Student { Id = 6, Name = "Esra Nesin" });
            list.Add(new Student { Id = 7, Name = "Poyraz Keskin" });
            list.Remove(new Student { Id = 8, Name = "Hülya Başar" });
            list.Add(new Student { Id = 9, Name = "Hasan Başar" });
            list.Add(new Student { Id = 5, Name = "Ege Nesin" });

            //girilen harf veya isme göre arama yapar
            var findings = list.GetStudentsByName("H");
            findings.ForEach(student => Console.WriteLine($"{student.Name} isimli Öğrenci"));

            //Id numarasına göre arama yapar
            var student2 = list.GetStudent(3);
            Console.WriteLine($"{student2.Id} numaralı öğrenci {student2.Name}");


            Console.ReadLine();

        }
        static Student GetStudent()
        {
            return new Student { Name = "X" };
        }
    }
}
