using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MvcMovie.Models
{
    public class MvcSerieContext : DbContext
    {
        public MvcSerieContext (DbContextOptions<MvcSerieContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Serie> Serie { get; set; }
    }
}
