using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment9.Models
{
    public interface IMovieRepository
    {
        IQueryable<Movie> Movies { get; }

        public void AddMovie(Movie movie);

        public void UpdateMovie(Movie movie);

        public void DeleteMovie(Movie movie);

    }
}
