﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

/// <summary>
/// Descripción breve de todo
/// </summary>
public class territorio
{

    public Double _id_continente { get; set; }

    public Double _id_pais { get; set; }

    public string coordenadas { get; set; }
}