using MvcBasics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcBasics.Helpers
{
    public static class Extensions
    {
        public static string LogData(this Student student)
        {
            return $"{student.Age} --> {student.Name}";
        }
    }
}
