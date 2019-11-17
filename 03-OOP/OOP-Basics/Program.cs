using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(1, "Gosho", "Petrov", 22);
            Student student2 = new Student(2, "Ivan", "Ivanov", 33);
            Student student3 = new Student(3, "Petar", "Georgiev", 14);

            var studentsList = new List<Student>();
            studentsList.Add(student1);
            studentsList.Add(student2);
            studentsList.Add(student3);

            var school = new School("MySchool", "Fake address 1", studentsList);

            Console.WriteLine($"Name: {school.Name}, at: {school.Address}");
            Console.WriteLine("Number of students: " + school.GetStudentsCount());

            // option 1
            List<Student> filtered = studentsList.FindAll((student) => student.FirstName.CompareTo(student.Lastname) < 0);
            // option 2
            //List<Student> filtered = studentsList.FindAll(FilterStudents);

            foreach (var item in filtered)
            {
                Console.WriteLine("Student with id: " + item.Id);
            }
        }

        static bool FilterStudents(Student student)
        {
            return student.FirstName.CompareTo(student.Lastname) < 0;
        }
       
    }
}
