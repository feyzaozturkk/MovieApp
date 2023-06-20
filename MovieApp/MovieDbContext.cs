using MovieApp.Categories;
using MovieApp.MovieComments;
using MovieApp.Movies;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MovieApp
{
    public class MovieDbContext : DbContext
    {
		
			public MovieDbContext() : base("Server=.;Database=MoviesApp;Trusted_Connection=True;")
			{

			}

			public DbSet<Movie> Movies { get; set; }
			public DbSet<MovieComment> MovieComments { get; set; }
			public DbSet<Category> Categories { get; set; }

		
	}
}