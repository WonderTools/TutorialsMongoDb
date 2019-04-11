using System;
using System.Collections.Generic;
using System.Text;
using MovieInterface.DAL.Repository.Interface;
using MovieInterface.Service.Interface;

namespace MovieInterface.Service
{
    public class MongoConnectionsService: IMongoConnections
    {

        private readonly IMovieRepository _movierepository;

        public MongoConnectionsService(IMovieRepository movierepository)
        {
            _movierepository = movierepository;
        }
        public bool checkMongoConnections()
        {
            return _movierepository.checkConnection();
        }
    }
}
