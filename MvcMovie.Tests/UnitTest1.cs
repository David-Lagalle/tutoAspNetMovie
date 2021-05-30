using Moq;
using MvcMovie.Controllers;
using MvcMovie.Data;
using MvcMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace MvcMovie.Tests
{
    public class UnitTest1
    {
        private readonly MvcMovieContext _context;

        private MoviesController _MoviesController;

        public UnitTest1()
        {
            _MoviesController = new MoviesController(_context);
        }

        [Fact]
        public void simpleTest()
        {
            Assert.True(_MoviesController.IsTestWorking());
        }

        //[Fact]
        //public async Task Index_ReturnsAViewResult_WithAListOfMovies()
        //{
        //    var result = await _MoviesController.Index("", "");

        //    Assert.Equal(4, _context.Movie.ToList().Count);
        //}


        private List<Movie> GetTestMovies()
        {
            var movies = new List<Movie>();
            movies.Add(new Movie()
            {
                Title = "When Harry Met Sally",
                ReleaseDate = DateTime.Parse("1989-2-12"),
                Genre = "Romantic Comedy",
                Rating = "R",
                Price = 7.99M
            });
            movies.Add(new Movie()
            {
                Title = "Ghostbusters ",
                ReleaseDate = DateTime.Parse("1984-3-13"),
                Genre = "Comedy",
                Rating = "R",
                Price = 8.99M
            });
            movies.Add(new Movie()
            {
                Title = "Ghostbusters 2",
                ReleaseDate = DateTime.Parse("1986-2-23"),
                Genre = "Comedy",
                Rating = "R",
                Price = 9.99M
            });
            movies.Add(new Movie()
            {
                Title = "Rio Bravo",
                ReleaseDate = DateTime.Parse("1959-4-15"),
                Genre = "Western",
                Rating = "R",
                Price = 3.99M
            });

            return movies;
        }
    }
}
