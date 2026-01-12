using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAduanero.Shared.DTOs
{
    public class MonedaDto
    {
        public string Clave { get; set; } = string.Empty; // Ej: MXN
        public string Descripcion { get; set; } = string.Empty; // Ej: Peso mexicano

        // Propiedad calculada útil para los dropdowns
        public string Display => $"{Clave} - {Descripcion}";
    }
}
