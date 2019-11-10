using Microsoft.Extensions.DependencyInjection;
using TicketNow.Movies.Api.Mappers;

namespace TicketNow.Movies.Api
{
    public static class MovieApiDependencyInjection
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IMovieMapper, MovieMapper>();
        }
    }
}
