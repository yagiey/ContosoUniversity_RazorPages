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
    public class DetailsModel : PageModel
    {
        private readonly ContosoUniversity_RazorPages.Data.SchoolContext _context;

        public DetailsModel(ContosoUniversity_RazorPages.Data.SchoolContext context)
        {
            _context = context;
        }

        public Student Student { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Student = await _context.Students.FirstOrDefaultAsync(m => m.ID == id);

            if (Student == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
