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
public class Dato
{

    public string dato { get; set; }

    public string valor { get; set; }
}