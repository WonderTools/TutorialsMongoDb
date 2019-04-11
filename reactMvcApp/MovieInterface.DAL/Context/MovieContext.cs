using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MovieInterface.DAL.Models;
using MongoDB.Driver;

namespace MovieInterface.DAL.Context.Interface
{
    public class MovieContext : IMovieContext
    {
        private readonly IMongoDatabase _database;
        public MovieContext(IOptions<Settings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            _database = client.GetDatabase(settings.Value.Database);
        }
        public bool IsInitialized<TDocument>(string collectionName) => _database.GetCollection<TDocument>(collectionName).CountDocuments(FilterDefinition<TDocument>.Empty) != 0;
        public bool CheckConnection()
        {

            return _database.RunCommandAsync((Command<BsonDocument>) "{ping:1}").Wait(1000);
        }

        public void SetupIndex<TDocument>(string collectionName)
        {
            _database.GetCollection<TDocument>(collectionName);
        }
        public IMongoCollection<Movie> Movies => _database.GetCollection<Movie>("Movie");
    }
}
