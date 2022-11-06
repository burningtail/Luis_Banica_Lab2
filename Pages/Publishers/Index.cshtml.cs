﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Luis_Banica_Lab2.Data;
using Luis_Banica_Lab2.Models;

namespace Luis_Banica_Lab2.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Luis_Banica_Lab2.Data.Luis_Banica_Lab2Context _context;

        public IndexModel(Luis_Banica_Lab2.Data.Luis_Banica_Lab2Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;
        public IList<Book> Book { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Book = await _context.Book
                .Include(b => b.Publisher)
                .ToListAsync();
        }
    }
}
