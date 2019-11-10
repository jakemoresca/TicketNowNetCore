using Microsoft.Extensions.DependencyInjection;
using TicketNow.Movies.Core.Services;
using TicketNow.Movies.Core.Factories;
using TicketNow.Movies.Core.Repositories;

namespace TicketNow.Movies.Core
{
    public static class MoviesDependecyInjection
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IMovieService, MovieService>();
            services.AddScoped<IMovieRepository, MovieRepository>();
            services.AddScoped<IMovieFactory, MovieFactory>();
        }
    }
}
