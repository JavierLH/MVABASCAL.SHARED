using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAduanero.Shared.DTOs
{
    public class PaginacionRequestDto
    {
        public int Pagina { get; set; } = 1;
        public int RegistrosPorPagina { get; set; } = 10;

        // Filtros opcionales
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public string? BusquedaTexto { get; set; } // Por si quieres buscar por pedimento
    }
}
