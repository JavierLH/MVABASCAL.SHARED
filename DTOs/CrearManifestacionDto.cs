using System.ComponentModel.DataAnnotations;

namespace SistemaAduanero.Shared.DTOs
{
    public class CrearManifestacionDto
    {
        // DATOS DE LA CARPETA (Mínimos)
        public string ReferenciaAdmin { get; set; } // Ej: "Expediente-001"
        public string TipoOperacion { get; set; } = "I";

        // LISTA DE COVES (Aquí viaja tu XML)
        public List<CoveDetalleDto> Coves { get; set; } = new List<CoveDetalleDto>();
    }
}
