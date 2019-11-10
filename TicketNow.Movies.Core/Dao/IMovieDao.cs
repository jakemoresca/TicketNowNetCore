using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TicketNow.Movies.Core.Dao
{
    public interface IMovieDao
    {
        Task<MovieDto> AddAsync(MovieDto movieDto);
        Task DeleteAsync(string id);
        Task<MovieDto> FindAsync(string id);
        Task<IReadOnlyList<MovieDto>> FindAllAsync();
        Task<MovieDto> UpdateAsync(MovieDto movie);
    }
}
