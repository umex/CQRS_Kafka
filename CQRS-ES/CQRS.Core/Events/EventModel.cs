using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CQRS.Core.Events
{
    /*
    The purpose of the event model is to represent the schema of the event store and each instance of the event model 
    will represent a record in the event store or more accurately. 
    */
    public class EventModel
    {
        // Documents in MongoDB must have an _id (ObjectId) member, which uniquely identifies the document within a collection. 
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public DateTime TimeStamp { get; set; }
        public Guid AggregateIdentifier { get; set; }
        public string AggregateType { get; set; }
        public int Version { get; set; }
        public string EventType { get; set; }
        public BaseEvent EventData { get; set; }
    }
}