using Microsoft.EntityFrameworkCore;
using System;

namespace DataLayer
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {

        }
    }
}
