using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Driver;
using MovieInterface.DAL.Models;

namespace MovieInterface.DAL.Repository.Interface
{
    public interface IMovieRepository
    {
        Task<Movie> GetMovie(string movieId);

        Boolean checkConnection();
    }
}
