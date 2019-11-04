using MvcBasics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcBasics.Data
{
    public interface IEntryManager
    {
        void FinishCreatingStudent(Student args);
    }
}
