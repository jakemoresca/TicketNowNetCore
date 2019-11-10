namespace TicketNow.Movies.Core.Dao.MongoDB.Mappers
{
    public interface IMovieCollectionMapper
    {
        MovieDto ToDto(MovieCollection movieDto);
        MovieCollection ToMovieCollection(MovieDto movieDto);
    }
}