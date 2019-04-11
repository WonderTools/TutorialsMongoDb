
using MongoDB.Driver;
using MovieInterface.DAL.Models;

namespace MovieInterface.DAL.Context
{
    public interface IMovieContext
    {
        IMongoCollection<Movie> Movies { get; }
        void SetupIndex<TDocument>(string collectionName);
        bool IsInitialized<TDocument>(string collectionName);
        bool CheckConnection();
    }
}
