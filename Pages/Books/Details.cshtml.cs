﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Pop_Stefana_Lab8.Data;
using Pop_Stefana_Lab8.Models;

namespace Pop_Stefana_Lab8.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly Pop_Stefana_Lab8.Data.Pop_Stefana_Lab8Context _context;

        public DetailsModel(Pop_Stefana_Lab8.Data.Pop_Stefana_Lab8Context context)
        {
            _context = context;
        }

        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book = await _context.Book
                .Include(b => b.Publisher)
                .Include(b => b.BookCategories)
                .ThenInclude(b => b.Category)
                .FirstOrDefaultAsync(m => m.ID == id);

            if (Book == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
