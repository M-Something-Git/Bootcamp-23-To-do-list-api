using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace Bootcamp_23_todo_list_api.Models
{
    public class ToDoList
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;
        [BsonElement("UserId")]
        public string UserId { get; set; }
        [BsonElement("Task")]
        public string Task { get; set; }
        [BsonElement("Status")]
        public string Status { get; set; }
    }
}
