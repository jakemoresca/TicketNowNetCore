using System.Collections.Generic;
using TicketNow.Movies.Core.Dao;
using TicketNow.Movies.Core.Factories;
using TicketNow.Movies.Core.Models;
using TicketNow.Common;
using System.Threading.Tasks;

namespace TicketNow.Movies.Core.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly IMovieDao _movieDao;
        private readonly IMovieFactory _movieFactory;

        public MovieRepository(IMovieDao movieDao, IMovieFactory movieFactory)
        {
            _movieDao = movieDao;
            _movieFactory = movieFactory;
        }

        public async Task<Movie> AddAsync(Movie movie)
        {
            var movieDto = _movieFactory.ToDto(movie);
            movieDto = await _movieDao.AddAsync(movieDto);

            return _movieFactory.ToModel(movieDto);
        }

        public async Task DeleteAsync(string id) => await _movieDao.DeleteAsync(id);

        public async Task<Movie> FindAsync(string id)
        {
            var movieDto = await _movieDao.FindAsync(id);
            return _movieFactory.ToModel(movieDto);
        }

        public async Task<IReadOnlyList<Movie>> FindAllAsync()
        {
            var movieDtos = await _movieDao.FindAllAsync();
            return movieDtos.ConvertAll(_movieFactory.ToModel);
        }

        public async Task<Movie> UpdateAsync(Movie movie)
        {
            var movieDto = _movieFactory.ToDto(movie);
            movieDto = await _movieDao.UpdateAsync(movieDto);

            return _movieFactory.ToModel(movieDto);
        }
    }
}
