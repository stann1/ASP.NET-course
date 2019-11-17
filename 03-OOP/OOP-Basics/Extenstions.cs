using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Basics
{
    public static class Extenstions
    {
        public static int GetStudentsCount(this School school)
        {
            return school.Students.Count;
        }
    }
}
