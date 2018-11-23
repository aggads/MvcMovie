using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedSeries
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcSerieContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcSerieContext>>()))
            {
                // Look for any Serie.
                if (context.Serie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Serie.AddRange(
                     new Serie
                     {
                         Title = "How I meet your mother",
                         ReleaseDate = DateTime.Parse("1989-1-11"),
                         Genre = "Romantic Comedy",
                         Rating = "R",
                         Price = 7.99M
                     },

                     new Serie
                     {
                         Title = "Dragon Ball",
                         ReleaseDate = DateTime.Parse("1984-3-13"),
                         Genre = "Comedy",
                         Price = 8.99M
                     },

                     new Serie
                     {
                         Title = "Dragon Ball Super",
                         ReleaseDate = DateTime.Parse("1986-2-23"),
                         Genre = "Comedy",
                         Price = 9.99M
                     },

                   new Serie
                   {
                       Title = "Rio De Janero",
                       ReleaseDate = DateTime.Parse("1959-4-15"),
                       Genre = "Western",
                       Price = 3.99M
                   }
                );
                context.SaveChanges();
            }
        }
    }
}