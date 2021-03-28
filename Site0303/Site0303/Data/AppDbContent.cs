using Microsoft.EntityFrameworkCore;
using Site0303.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site0303.Data
{
    public class AppDbContent: DbContext
    {

        public AppDbContent(DbContextOptions<AppDbContent> options) : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }
        public DbSet<Category1> Category1 { get; set; }

    }
}
