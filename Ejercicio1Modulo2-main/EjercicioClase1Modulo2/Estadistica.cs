using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EjercicioClase1Modulo2
{
    public class Estadistica
    {
        [JsonPropertyName("estadistica")]
        public List<Equipo> Equipos { get; set; }
       
    }
    public class Equipo
    {
        [JsonPropertyName("equipo")]
        public string? grupo { get; set; }
        [JsonPropertyName("jugadores")]
        public List<jugador>? Jugadores { get; set; }
        [JsonPropertyName("campeon")]
        public bool Campeon {  get; set; }
    }

    public class jugador {
        [JsonPropertyName("nombre")]
        public string? Nombre { get; set; }
        [JsonPropertyName("kills")]
        public int? Kills { get; set;}
        [JsonPropertyName("death")]
        public int nise{ get; set; }


    }
}
