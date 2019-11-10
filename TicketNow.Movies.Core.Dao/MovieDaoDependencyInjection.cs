using Microsoft.Extensions.DependencyInjection;
using TicketNow.Movies.Core.Dao.MongoDB.Mappers;

namespace TicketNow.Movies.Core.Dao.MongoDB
{
    public static class MovieDaoDependencyInjection
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IMovieDao, MovieDao>();
            services.AddScoped<IMovieCollectionMapper, MovieCollectionMapper>();
        }
    }
}
