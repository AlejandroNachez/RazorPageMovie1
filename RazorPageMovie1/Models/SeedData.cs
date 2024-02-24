using Microsoft.EntityFrameworkCore;
using RazorPageMovie1.Data;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace RazorPageMovie1.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider) {

            using (var context = new RazorPageMovie1Context(
            serviceProvider.GetRequiredService<
                DbContextOptions<RazorPageMovie1Context>>()))
            {
                if (context == null || context.Movie == null) {
                    throw new ArgumentException("Null RazorPageMovie1Context");
                }   
                //Para mirar cualquier pelicula 
                if (context.Movie.Any())
                {
                    return; //Db muestra todo lo que contiene la clase
                }

                context.Movie.AddRange(
                    new Movie
                    { 
                        Title = "Spiderman",
                        ReleaseDate = DateTime.Parse("1989-02-01"),
                        Genre = "Action",
                        Price = 7.99M,
                        Rating = "R"
                    },
                     new Movie
                     {
                         Title = "Ghostbuster",
                         ReleaseDate = DateTime.Parse("1984-03-13"),
                         Genre = "Comedy",
                         Price = 8.99M,
                         Rating = "R"
                     },
                      new Movie
                      {
                          Title = "Iron Man",
                          ReleaseDate = DateTime.Parse("2008-03-10"),
                          Genre = "Best Movie",
                          Price = 8522.00M,
                          Rating = "R"
                      },
                       new Movie
                       {
                           Title = "Hulk",
                           ReleaseDate = DateTime.Parse("2005-05-04"),
                           Genre = "Action",
                           Price = 10.00M,
                           Rating = "R"
                       }
                    );

                context.SaveChanges();
            }
        }
        
    }
}
