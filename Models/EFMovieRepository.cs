using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment9.Models
{
    public class EFMovieRepository : IMovieRepository
    {
        private MovieDbContext _context; 
        //constructor
        public EFMovieRepository (MovieDbContext context)
        {
            _context = context;
        }
        public IQueryable<Movie> Movies => (_context.Movies);

        public void AddMovie(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
        }

        public void UpdateMovie(Movie movie)
        {
            Movie movie_object = _context.Movies.Where(m => m.MovieId == movie.MovieId).FirstOrDefault();
            //update values
            movie_object.Title = movie.Title;
            movie_object.Rating = movie.Rating;
            movie_object.Year = movie.Year;
            movie_object.Edited = movie.Edited;
            movie_object.Director = movie.Director;
            movie_object.LentTo = movie.LentTo;
            movie_object.Notes = movie.Notes;

            _context.SaveChanges();
        }

        public void DeleteMovie(Movie movie)
        {
            _context.Movies.Remove(movie);
            _context.SaveChanges();
        }

    }
}
