using MovieApp.BL;
using System;
using System.Collections.Generic;

namespace MovieApp.DataAccess
{
    public class MovieRepository:IMovieRepository
    {


        public IEnumerable<Movie> GetAll()
        {
            return _data;
        }
        public void Create (Movie movie)
        {

        }
    }
}
