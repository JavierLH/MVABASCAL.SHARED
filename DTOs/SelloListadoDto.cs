using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAduanero.Shared.DTOs
{
    public class SelloListadoDto
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public string RFC { get; set; }
        public string RazonSocial { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public bool Activo { get; set; }
    }
}