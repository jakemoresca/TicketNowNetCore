using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TicketNow.Movies.Core.Models;
using TicketNow.Movies.Core.Repositories;

namespace TicketNow.Movies.Core.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public async Task<Movie> AddAsync(Movie movie) => await _movieRepository.AddAsync(movie);

        public async Task DeleteAsync(string id) => await _movieRepository.DeleteAsync(id);

        public async Task<Movie> FindAsync(string id) => await _movieRepository.FindAsync(id);

        public async Task<IReadOnlyList<Movie>> FindAllAsync() => await _movieRepository.FindAllAsync();

        public async Task<Movie> UpdateAsync(Movie movie) => await _movieRepository.UpdateAsync(movie);
    }
}
