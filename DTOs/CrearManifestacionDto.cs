using System.Collections.Generic;

namespace SistemaAduanero.Shared.DTOs
{
    public class CrearManifestacionDto
    {

        public string ReferenciaAdmin { get; set; } // Pedimento
        public string Referencia { get; set; }
        public string EstadoEnvio { get; set; } = "BORRADOR";
        // Lo mantenemos en el DTO para la UI, aunque en BD se use el del Cliente.
        public string? RfcImportador { get; set; }

        // Totales Globales
        public decimal TotalPrecioPagado { get; set; }
        public decimal TotalPrecioPorPagar { get; set; }
        public decimal TotalIncrementables { get; set; }
        public decimal TotalDecrementables { get; set; }
        public decimal TotalValorAduana { get; set; }
        public int ClienteId { get; set; }
        public int? ClienteIdSeleccionado { get; set; }
        // Esta propiedad nos sirve para mostrar el RFC en el campo de solo lectura
        public ClienteDto? Cliente { get; set; }

        // Listas
        public List<CoveDetalleDto> Coves { get; set; } = new();

        // Nueva Lista 1:N (RFCs de Consulta)
        public List<ConsultaRfcDto> Consultas { get; set; } = new();

        public List<ManifestacionEdocumentDto> Edocuments { get; set; } = new();


        public List<DocumentoExpedienteDto> Documentos { get; set; } = new();
        public List<NotaExpedienteDto> HistorialNotas { get; set; } = new();
    }

    public class ConsultaRfcDto
    {
        public string RfcConsulta { get; set; }
        public string TipoFigura { get; set; }
    }
}