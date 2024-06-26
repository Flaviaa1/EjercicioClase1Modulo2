﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EjercicioClase1Modulo2
{
    public class Usuario
    {
        [JsonPropertyName("usuario")]
        public string? Nombre { get; set; }
        [JsonPropertyName("amigos_usuario")]
        public List<string>? ListaDeAmigos { get; set; }
        [JsonPropertyName("notificaciones_usuario")]
        public bool   Notificaciones { get; set;}
    }
   
}
