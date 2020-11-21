using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pop_Stefana_Lab8.Models;

namespace Pop_Stefana_Lab8.Data
{
    public class Pop_Stefana_Lab8Context : DbContext
    {
        public Pop_Stefana_Lab8Context (DbContextOptions<Pop_Stefana_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Pop_Stefana_Lab8.Models.Book> Book { get; set; }
    }
}
