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
public class investigacion
{
		  
    [BsonId]
    public Double Id { get; set; }

    public string nombre { get; set; }
    public string descripcion { get; set; }
    public IList<Recurso> recursos { get; set; }
    public IList<Recompensa> recompensas { get; set; }
    public IList<dependencia> dependencias { get; set; }
}