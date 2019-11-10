namespace TicketNow.Movies.Core.Dao.MongoDB.Mappers
{
    public class MovieCollectionMapper : IMovieCollectionMapper
    {
        public MovieCollection ToMovieCollection(MovieDto movieDto)
        {
            return new MovieCollection
            {
                Id = movieDto.Id,
                Name = movieDto.Name,
                Description = movieDto.Description,
                CreatedDateTime = movieDto.CreatedDateTime,
                ModifiedDateTime = movieDto.ModifiedDateTime
            };
        }

        public MovieDto ToDto(MovieCollection movieDto)
        {
            return new MovieDto
            {
                Id = movieDto.Id,
                Name = movieDto.Name,
                Description = movieDto.Description,
                CreatedDateTime = movieDto.CreatedDateTime,
                ModifiedDateTime = movieDto.ModifiedDateTime
            };
        }
    }
}
