using MvcBasics.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcBasics.Helpers
{
    public class ReportingTool
    {
        public void SendMail(string recipient, string body)
        {
            Console.WriteLine("Sending mail to: " + recipient);
            Console.WriteLine("Content: " + body);
        }

        public void HandleItemCreated(object sender, EventArgs args)
        {
            var eventArgs = (StudentEventArgs)args;
            this.SendMail("admin@myapp.com", $"New student created: {eventArgs.LogFormat}");
        }
    }
}
