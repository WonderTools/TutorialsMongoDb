
using Microsoft.Extensions.Options;
using MovieInterface.DAL.Context;
using MovieInterface.DAL.Context.Interface;

namespace MovieInterface.DAL
{
    public class DbInitializer
    {
        private readonly IMovieContext _movieContext;
        public DbInitializer(IOptions<Settings> settings)
        {
            _movieContext = new MovieContext(settings);
        }
    }
}
