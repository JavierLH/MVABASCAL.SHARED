using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAduanero.Shared.DTOs
{
    public class PeticionVucemLoteFrontDto
    {
        public int ClienteId { get; set; }
        public string? RfcConsulta { get; set; }
        public string? Usuario { get; set; }
        public List<DocumentoProcesarLoteDto> Documentos { get; set; } = new();
    }
}
