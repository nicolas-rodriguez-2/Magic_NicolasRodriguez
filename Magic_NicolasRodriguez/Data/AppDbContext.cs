using Magic_NicolasRodriguez.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Magic_NicolasRodriguez.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Magic_NicolasRodriguez.Models.Suerte> Suerte { get; set; }

    }
}
