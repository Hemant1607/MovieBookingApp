using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBookingApp.DataAccess
{
    interface IMovieRepository
    {
        void AddMovie(Movie movie);
        void UpdateMovie(int movieId, Movie movie);
        void DeleteMovie(int movieId);
    }
}
