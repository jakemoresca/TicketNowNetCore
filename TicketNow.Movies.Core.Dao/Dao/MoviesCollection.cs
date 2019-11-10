using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace TicketNow.Movies.Core.Dao.MongoDB
{
    public class MovieCollection
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
    }
}
