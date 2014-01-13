using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

/// <summary>
/// Descripción breve de Post
/// </summary>

[BsonIgnoreExtraElements]
public class Post
{
   
    [BsonId]
    public ObjectId PostId { get; set; }

    public DateTime Date { get; set; }

    public string Title { get; set; }

    public string Url { get; set; }
    public string Summary { get; set; }

   
    public string Details { get; set; }
    public string Author { get; set; }

    public int TotalComments { get; set; }
    public IList<Comment> Comments { get; set; }
}