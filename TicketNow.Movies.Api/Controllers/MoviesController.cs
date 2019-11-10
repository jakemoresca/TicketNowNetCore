using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TicketNow.Movies.Api.Mappers;
using TicketNow.Movies.Core.Services;
using TicketNow.Common;
using System.Threading.Tasks;

namespace TicketNow.Movies.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly ILogger<MoviesController> _logger;
        private readonly IMovieService _movieService;
        private readonly IMovieMapper _movieMapper;

        public MoviesController(ILogger<MoviesController> logger, IMovieService movieService, IMovieMapper movieMapper)
        {
            _logger = logger;
            _movieService = movieService;
            _movieMapper = movieMapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var movies = await _movieService.FindAllAsync();
            return Ok(movies.ConvertAll(_movieMapper.ToDto));
        }
    }
}
