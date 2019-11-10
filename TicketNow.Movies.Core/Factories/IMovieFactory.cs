using TicketNow.Movies.Core.Dao;
using TicketNow.Movies.Core.Models;

namespace TicketNow.Movies.Core.Factories
{
    public interface IMovieFactory
    {
        MovieDto ToDto(Movie movie);
        Movie ToModel(MovieDto movieDto);
    }
}