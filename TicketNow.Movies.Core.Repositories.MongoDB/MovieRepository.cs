using System;
using System.Collections.Generic;
using TicketNow.Movies.Core.Models;
using TicketNow.Movies.Core.Repositories;

namespace TicketNow.Movies.Core.Repositories.MongoDB
{
    public class MovieRepository : IMovieRepository
    {
        public Movie Add(Movie movie)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Movie Find(Guid id)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<Movie> FindAll()
        {
            throw new NotImplementedException();
        }

        public Movie Update(Movie movie)
        {
            throw new NotImplementedException();
        }
    }
}
