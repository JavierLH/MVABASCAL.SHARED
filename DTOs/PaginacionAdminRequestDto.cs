using System;

namespace SistemaAduanero.Shared.DTOs
{
    public class PaginacionAdminRequestDto : PaginacionRequestDto
    {
        // Filtro adicional para panel de administración
        // null = Todos, true = Activos, false = Inactivos
        public bool? Activo { get; set; }
    }
}
