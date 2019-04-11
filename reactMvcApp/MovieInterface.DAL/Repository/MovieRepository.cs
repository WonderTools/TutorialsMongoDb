using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using MovieInterface.DAL.Context;
using MovieInterface.DAL.CustomDBExceptions;
using MovieInterface.DAL.Models;
using MovieInterface.DAL.Repository.Interface;

namespace MovieInterface.DAL.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private readonly IMovieContext _context = null;
        public MovieRepository(IMovieContext context)
        {
            _context = context;
            
        }

         public Task<Movie> GetMovie(string movieId)
        {
            try
            {
                var filter = Builders<Movie>.Filter.Eq(movie => movie.Id, movieId);
                return _context.Movies.Find(filter).FirstOrDefaultAsync(); ;
            }
            catch(Exception ex)
            {
                throw new MongoDbException("Unable to fetch Movie details", ex);
            }
            
        }

        public bool checkConnection()
        {
            return _context.CheckConnection();
        }

        //    public Task<List<Message>> GetMessages(long patientId,int pageNumber, int pageSize)
    //    {
    //        try
    //        {
    //            var filter = Builders<Message>.Filter.Eq(message => message.Recipient.Id, patientId)
    //                | Builders<Message>.Filter.Eq(message => message.Sender.Id, patientId);

    //            if (pageSize == 0)
    //            {
    //                return _context.Messages
    //                    .Find(filter).Sort(Builders<Message>.Sort.Descending(x => x.CreateDate))
    //                    .ToListAsync();
    //            }
    //            else
    //            {
    //                return _context.Messages
    //                    .Find(filter).Sort(Builders<Message>.Sort.Descending(x => x.CreateDate))
    //                    .Skip(pageNumber * pageSize)
    //                    .Limit(pageSize)
    //                    .ToListAsync();
    //            }
    //        }
    //        catch(Exception ex)
    //        {
    //            throw new MongoDbException("Unable to fetch Messages", ex);
    //        }
    //    }


    //    public async Task<Message> SaveMessage(Message message)
    //    {
    //        try
    //        {
    //            await _context.Messages.InsertOneAsync(message);
    //            return message;
    //        }
    //        catch(Exception ex)
    //        {
    //            throw new MongoDbException("Unable to save Message", ex);
    //        }
    //    }

    //    public async Task UpdateMessageReadOnDate(IEnumerable<string> messageIds)
    //    {
    //        try
    //        {
    //            var filter = Builders<Message>.Filter.In(message => message.InteractionId, messageIds) &
    //                         Builders<Message>.Filter.Where(message => !message.ReadOn.HasValue);
    //            var updateDefinition = Builders<Message>.Update.Set(r => r.ReadOn, DateTime.Now)
    //                .Set(r => r.UpdateDate, DateTime.Now);
    //            var options = new FindOneAndUpdateOptions<Message> { ReturnDocument = ReturnDocument.After };
    //            await _context.Messages.UpdateManyAsync(filter, updateDefinition);
    //        }
    //        catch(Exception ex)
    //        {
    //            throw new MongoDbException("Unable to update Message as read", ex);
    //        }
    //    }

    //    public Task DeleteMessages(FilterDefinition<Message> filter)
    //    {
    //        try
    //        {
    //            return _context.Messages.DeleteManyAsync(filter);
    //        }
    //        catch (Exception ex)
    //        {
    //            throw new MongoDbException("Unable to Delete Messages", ex);
    //        }
    //    }

    }
}
