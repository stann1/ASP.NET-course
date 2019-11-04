using MvcBasics.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcBasics.Helpers
{
    public class LoggingTool
    {
        public void LogToFile(string file)
        {
            Console.WriteLine("Logger writing to file");
        }

        public void HandleItemCreated(object sender, EventArgs args)
        {
            this.LogToFile("logfile.log");
        }
    }
}
