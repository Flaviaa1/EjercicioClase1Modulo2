using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EjercicioClase1Modulo2
{
    public class Producto
    {
        [JsonPropertyName("productos")]
        public List<Mercaderia>? Productos { get; set; }
    }
    public class Mercaderia {
        [JsonPropertyName("nombre")]
        public string Nombre { get; set; }
        [JsonPropertyName("precio")]
        public double Precio { get; set; }
        [JsonPropertyName("existencias")]
        public int Existencias { get; set; }    
        [JsonPropertyName("descuento_disponible")]
        public bool Descuento { get; set; }
        [JsonPropertyName("etiquetas")]
        public List<string>Etiquetas { get; set; }
        [JsonPropertyName("detalles")]
        public Detalle Detalle { get; set; }
    }

    public class Detalle {
        [JsonPropertyName("peso")]
        public double peso { get; set; }
        [JsonPropertyName("dimensiones")]
        public Dimension Dimension { get; set; }

    }
    public class Dimension {
        [JsonPropertyName("alto")]
        public int Alto { get; set; }
        [JsonPropertyName("ancho")]
        public int Ancho { get; set; }
        [JsonPropertyName("profundidad")]
        public int  Profundidad { get; set;}
    }
   
}
