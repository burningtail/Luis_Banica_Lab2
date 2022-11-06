using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Luis_Banica_Lab2.Models;

namespace Luis_Banica_Lab2.Data
{
    public class Luis_Banica_Lab2Context : DbContext
    {
        public Luis_Banica_Lab2Context (DbContextOptions<Luis_Banica_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Luis_Banica_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Luis_Banica_Lab2.Models.Publisher> Publisher { get; set; }
    }
}
