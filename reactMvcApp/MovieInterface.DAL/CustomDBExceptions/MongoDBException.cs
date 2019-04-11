using System;
using System.Net;

namespace MovieInterface.DAL.CustomDBExceptions
{
    public class MongoDbException : Exception
    {
        public MongoDbException(string message) : base(message)
        {
        }

        public MongoDbException(string message, Exception ex, HttpStatusCode statusCode = HttpStatusCode.InternalServerError) : base(message)
        {
            StatusCode = statusCode;
        }
        public HttpStatusCode StatusCode { get; set; }
    }
}
