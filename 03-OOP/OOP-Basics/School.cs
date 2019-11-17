using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Basics
{
    public class School
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Student> Students { get; set; }

        public School(string name, string address, List<Student> students)
        {
            Name = name;
            Address = address;
            Students = students;
        }
    }
}
