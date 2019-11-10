using System.Collections.Generic;
using System.Threading.Tasks;
using TicketNow.Movies.Core.Models;

namespace TicketNow.Movies.Core.Repositories
{
    public interface IMovieRepository
    {
        Task<Movie> AddAsync(Movie movie);
        Task DeleteAsync(string id);
        Task<Movie> FindAsync(string id);
        Task<IReadOnlyList<Movie>> FindAllAsync();
        Task<Movie> UpdateAsync(Movie movie);
    }
}
