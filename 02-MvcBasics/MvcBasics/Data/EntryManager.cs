using MvcBasics.Helpers;
using MvcBasics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcBasics.Data
{
    public class EntryManager : IEntryManager
    {
        public event EventHandler<StudentEventArgs> OnStudentCreated;

        public void FinishCreatingStudent(Student student)
        {
            StudentEventArgs args = new StudentEventArgs() {LogFormat = $"{student.Id} --> {student.Name}" };
            OnStudentCreated?.Invoke(this, args);
        }
    }
}
