using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;
using TicketNow.Movies.Core.Dao.MongoDB;
using TicketNow.Movies.Core.Dao.MongoDB.Mappers;

namespace TicketNow.Movies.Core.Dao
{
    public class MovieDao : IMovieDao
    {
        private readonly IMongoCollection<MovieCollection> _collection;
        private readonly IMovieCollectionMapper _movieCollectionMapper;

        public MovieDao(IMovieCollectionMapper movieCollectionMapper)
        {
            var conventionPack = new ConventionPack { new CamelCaseElementNameConvention() };
            ConventionRegistry.Register("camelCase", conventionPack, t => true);

            //ToDo: move to DI
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("MoviesDB");

            _collection = database.GetCollection<MovieCollection>("Movie");

            _movieCollectionMapper = movieCollectionMapper;
        }

        public async Task<MovieDto> AddAsync(MovieDto movieDto)
        {
            var movieCollection = _movieCollectionMapper.ToMovieCollection(movieDto);

            await _collection.InsertOneAsync(movieCollection);

            return movieDto;
        }

        public async Task DeleteAsync(string id)
        {
            await _collection.DeleteOneAsync(movie => movie.Id == id);
        }

        public async Task<MovieDto> FindAsync(string id)
        {
            var movieCollection = await (await _collection.FindAsync(movie => movie.Id == id)).FirstOrDefaultAsync();

            return _movieCollectionMapper.ToDto(movieCollection);
        }

        public async Task<IReadOnlyList<MovieDto>> FindAllAsync()
        {
            var movieCollections = await (await _collection.FindAsync(x => true)).ToListAsync();

            return movieCollections.ConvertAll(_movieCollectionMapper.ToDto);
        }

        public async Task<MovieDto> UpdateAsync(MovieDto movie)
        {
            var movieCollection = _movieCollectionMapper.ToMovieCollection(movie);
            await _collection.ReplaceOneAsync(book => book.Id == movieCollection.Id, movieCollection);

            return movie;
        }
    }
}
