using System;

namespace EstiloGlamourApi.Dtos
{
    public class CreateProductoDto
    {
        public string Id { get; set; } 
        public string Nombre { get; set; } 
        public string Casa { get; set; } 
        public string Descripcion { get; set; } 
        public string? Tamanio { get; set; }
        public string? Genero { get; set; }
        public string? Imagen { get; set; } 
        public string Precio_mayor { get; set; } 
        public string Tipo_perfume { get; set; } 
        public string Precio_detalle { get; set; } 
    }
}