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
public class rol
{
		  
    [BsonId]
    public Double Id { get; set; }

    public string Rol { get; set; }
    public string descripcion { get; set; }
}