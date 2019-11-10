using TicketNow.Movies.Core.Dao;
using TicketNow.Movies.Core.Models;

namespace TicketNow.Movies.Core.Factories
{
    public class MovieFactory : IMovieFactory
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
