using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

/// <summary>
/// Descripción breve de todo
/// </summary>
public class miembroAli
{
 [BsonId]
    public double id { get; set; }
    public string nombre { get; set; }
    
}