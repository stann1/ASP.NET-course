using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Basics
{
    public class Student
    {
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }

        public int Id { get; }

        public Student(int id, string firstName,
            string lastName, int age)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.Lastname = lastName;
            this.Age = age;
        }

        public Student(int id)
        {
            this.Id = id;
        }

        public void PrintFullName()
        {
            string fullName = this.GetFullName();
            Console.WriteLine(fullName);
        }

        private string GetFullName()
        {
            return $"{this.FirstName} {Lastname}";
        }
    }
}
