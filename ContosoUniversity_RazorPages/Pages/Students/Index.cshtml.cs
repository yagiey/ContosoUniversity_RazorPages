﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity_RazorPages.Data;
using ContosoUniversity_RazorPages.Models;

namespace ContosoUniversity_RazorPages.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly ContosoUniversity_RazorPages.Data.SchoolContext _context;

        public IndexModel(ContosoUniversity_RazorPages.Data.SchoolContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Students.ToListAsync();
        }
    }
}
