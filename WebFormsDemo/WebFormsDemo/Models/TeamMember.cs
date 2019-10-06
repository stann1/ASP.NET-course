using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFormsDemo.Models
{
    public class TeamMember
    {
        public string FirstName { get => FirstName; set => FirstName = value; }
        public string LastName { get => LastName; set => LastName = value; }
        public string Email { get => Email; set => Email = value; }
    }
}