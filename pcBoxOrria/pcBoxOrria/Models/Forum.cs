namespace pcBoxOrria.Models
{
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

    namespace ForumModel
    {
        public class Forum
        {
            [BsonId]
            [BsonRepresentation(BsonType.ObjectId)]
            public string Id { get; set; }

            [BsonElement("topic")]
            public string Topic { get; set; }

            [BsonElement("posts")]
            public List<Post> Posts { get; set; }
        }
        public class Post
        {
            [BsonId]
            [BsonRepresentation(BsonType.ObjectId)]
            public string PostId { get; set; }

            [BsonElement("title")]
            public string Title { get; set; }

            [BsonElement("author")]
            public string Author { get; set; }

            [BsonElement("content")]
            public string Content { get; set; }

            [BsonElement("date_created")]
            [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
            public DateTime DateCreated { get; set; }

            [BsonElement("replies")]
            public List<Reply> Replies { get; set; }
        }
        public class Reply
        {
            [BsonId]
            [BsonRepresentation(BsonType.ObjectId)]
            public string ReplyId { get; set; }

            [BsonElement("author")]
            public string Author { get; set; }

            [BsonElement("content")]
            public string Content { get; set; }

            [BsonElement("date_created")]
            [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
            public DateTime DateCreated { get; set; }
        }
    }
}
