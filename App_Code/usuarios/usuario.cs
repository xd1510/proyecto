using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

/// <summary>
/// Descripción breve de tarea
/// </summary>


[BsonIgnoreExtraElements]
public class usuario
{
		  
    [BsonId]
    public Double Id { get; set; }
    public List<Dato> datos { get; set; }
    public List<construccion> instalaciones { get; set; }
    public List<construccion> defensas { get; set; }
    public List<territorio> territorios { get; set; }


}