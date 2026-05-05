using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAduanero.Shared.DTOs
{
    public class ResultadoItemVucemDto
    {
        public int DocumentoId { get; set; }
        public string NombreDocumento { get; set; } = string.Empty;
        public bool Exito { get; set; }
        public string Mensaje { get; set; } = string.Empty;
        public string NumeroOperacion { get; set; } = string.Empty;
    }
}
