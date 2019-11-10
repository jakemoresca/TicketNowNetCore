using TicketNow.Movies.Api.Dtos;
using TicketNow.Movies.Core.Models;

namespace TicketNow.Movies.Api.Mappers
{
    public interface IMovieMapper
    {
        MovieDto ToDto(Movie movie);
        Movie ToModel(MovieDto movieDto);
    }
}