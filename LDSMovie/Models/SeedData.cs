using LDSMovie.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LDSMovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<LDSMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                     new Movie
                     {
                         Title = "The RM",
                         ReleaseDate = DateTime.Parse("2003-1-31"),
                         Genre = "Romantic Comedy",
                         Rating = "PG",
                         Price = 7.99M
                     },

                     new Movie
                     {
                         Title = "The Singles Ward",
                         ReleaseDate = DateTime.Parse("2002-2-01"),
                         Genre = "Comedy",
                         Rating = "PG",
                         Price = 8.99M
                     },

                     new Movie
                     {
                         Title = "Saints and Soldiers",
                         ReleaseDate = DateTime.Parse("2003-9-11"),
                         Genre = "War",
                         Rating = "PG-13",
                         Price = 9.99M
                     },

                   new Movie
                   {
                       Title = "The Saratov Approach",
                       ReleaseDate = DateTime.Parse("2013-10-12"),
                       Genre = "Drama",
                       Rating = "PG-13",
                       Price = 3.99M
                   }
                );
                context.SaveChanges();
            }
        }
    }
}