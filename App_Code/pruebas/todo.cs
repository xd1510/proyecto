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
public class todo
{

    public string tarea { get; set; }

    public string user { get; set; }
}