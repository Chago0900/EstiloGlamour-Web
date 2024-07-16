using System;
using System.Collections.Generic;

namespace EstiloGlamourApi.Models
{
    public class Campeonato
    {
        public string Id { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public DateTime Fecha_inicio { get; set; }
        public DateTime Fecha_fin { get; set; }
        public string? Descripcion_reglas { get; set; }
    }
}
