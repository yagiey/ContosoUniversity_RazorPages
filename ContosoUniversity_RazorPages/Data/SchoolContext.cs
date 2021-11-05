using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity_RazorPages.Models;

namespace ContosoUniversity_RazorPages.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext (DbContextOptions<SchoolContext> options)
            : base(options)
        {
        }

        public DbSet<ContosoUniversity_RazorPages.Models.Student> Student { get; set; }
    }
}
