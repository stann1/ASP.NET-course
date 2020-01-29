using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            // create DB if it does not exist
            context.Database.EnsureCreated();

            // insert data if it does not exist
            if (!context.Roles.Any())
            {
                context.Roles.Add(new IdentityRole { Name = "Admin", NormalizedName = "ADMIN" });
                context.Roles.Add(new IdentityRole { Name = "Clerk", NormalizedName = "CLERK" });
                context.Roles.Add(new IdentityRole { Name = "Student", NormalizedName = "STUDENT" });
            }

            // add others if needed

            context.SaveChanges();
        }
    }
}
