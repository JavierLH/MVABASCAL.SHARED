using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAduanero.Shared.DTOs
{
    public class DocumentoProcesarLoteDto
    {
        public int DocumentoId { get; set; }
        // Opcional, por si cada documento del lote tiene un tipo distinto
        public int? IdTipoDocumento { get; set; }
    }

    
}
