using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAduanero.Shared.DTOs
{
    public class PeticionVucemFrontDto
    {
        public int ClienteId { get; set; }
        public int DocumentoId { get; set; }
        public string? RfcConsulta { get; set; }
        public int? IdTipoDocumento { get; set; }
        public string? Usuario { get; set; }
    }
}
