using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcBasics.Data
{
    public class StudentEventArgs : EventArgs
    {
        public string LogFormat { get; set; }
    }
}
