using TicketNow.Movies.Api.Dtos;
using TicketNow.Movies.Core.Models;

namespace TicketNow.Movies.Api.Mappers
{
    public class MovieMapper : IMovieMapper
    {
        public Movie ToModel(MovieDto movieDto)
        {
            return new Movie(movieDto.Id, movieDto.Name, movieDto.Description, movieDto.CreatedDateTime, movieDto.ModifiedDateTime);
        }

        public MovieDto ToDto(Movie movie)
        {
            return new MovieDto
            {
                Id = movie.Id,
                Name = movie.Name,
                Description = movie.Description,
                CreatedDateTime = movie.CreatedDateTime,
                ModifiedDateTime = movie.ModifiedDateTime
            };
        }
    }
}