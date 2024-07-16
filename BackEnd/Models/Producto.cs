using System;
using System.Collections.Generic;

namespace EstiloGlamourApi.Models
{
    public class Producto
    {
        public string Id { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Casa { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string? Tamanio { get; set; }
        public string? Genero { get; set; }
        public string Imagen { get; set; } = null!;
        public string Precio_mayor { get; set; } = null!;
        public string Tipo_perfume { get; set; } = null!;
        public string Precio_detalle { get; set; } = null!;
    }
}
