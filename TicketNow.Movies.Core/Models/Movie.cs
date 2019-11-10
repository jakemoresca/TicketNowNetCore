using System;

namespace TicketNow.Movies.Core.Models
{
    public class Movie
    {
        public Movie(string id, string name, string description, DateTime createdDateTime, DateTime? modifiedDateTime)
        {
            Id = id;
            Name = name;
            Description = description;
            CreatedDateTime = createdDateTime;
            ModifiedDateTime = modifiedDateTime;
        }

        public string Id { get; }
        public string Name { get; }
        public string Description { get; }
        public DateTime CreatedDateTime { get; }
        public DateTime? ModifiedDateTime { get; }
    }
}
