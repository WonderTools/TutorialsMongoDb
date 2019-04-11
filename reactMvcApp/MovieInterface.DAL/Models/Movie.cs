using System;
using MovieInterface.DAL.Models;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;

namespace MovieInterface.DAL.Models
{
    public class Movie
    {
        [BsonId(IdGenerator = typeof(StringObjectIdGenerator))]
        public String Id { get; set; }
        public String InteractionId { get; set; }
        public String Text { get; set; }
        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime? NotifiedOn { get; set; }
        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime? ReadOn { get; set; }
        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime CreateDate { get; set; }
    }
}
