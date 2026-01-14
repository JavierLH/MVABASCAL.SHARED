using System;
using System.Collections.Generic;

namespace SistemaAduanero.Shared.DTOs
{
    // DTO PRINCIPAL (ABUELO)
    namespace SistemaAduanero.Shared.DTOs
    {
        public class ManifestacionDto
        {
            public int ManifestacionId { get; set; }
            public int ClienteId { get; set; }
            public string NumeroPedimento { get; set; }

            // Propiedad de lectura que vendrá del Cliente.Rfc en el backend
            public string? RfcImportador { get; set; }

            public decimal? TotalPrecioPagado { get; set; }
            public decimal? TotalPrecioPorPagar { get; set; }
            public decimal? TotalIncrementables { get; set; }
            public decimal? TotalDecrementables { get; set; }
            public decimal? TotalValorAduana { get; set; }
            public string EstadoEnvio { get; set; }
            public DateTime? FechaRegistro { get; set; }
            public List<ManifestacionCoveDto> ManifestacionCoves { get; set; } = new();
            public List<ConsultaRfcDto> Consultas { get; set; } = new();
        }
    }

    // DTO HIJO (PADRE)
    public class ManifestacionCoveDto
    {
        public int CoveId { get; set; }
        public string NumeroCove { get; set; }
        public string? NumeroPedimento { get; set; }
        public string? Incoterm { get; set; }
        public bool? ExisteVinculacion { get; set; }
        public int? Patente { get; set; }
        public int? Aduana { get; set; }
        public string? MetodoValoracion { get; set; }

        // === LISTAS 1:N (NUEVAS) ===
        // Usamos los mismos DTOs auxiliares que definimos en CoveDetalleDto.cs
        // Asegúrate de que esas clases sean public en ese archivo.
        public List<PrecioPagadoDto> PreciosPagados { get; set; } = new List<PrecioPagadoDto>();
        public List<PrecioPorPagarDto> PreciosPorPagar { get; set; } = new List<PrecioPorPagarDto>();
        public List<CompensacionDto> Compensaciones { get; set; } = new List<CompensacionDto>();

        // TOTALES
        public decimal? TotalPrecioPagado { get; set; }
        public decimal? TotalPrecioPorPagar { get; set; }
        public decimal? TotalIncrementables { get; set; }
        public decimal? TotalDecrementables { get; set; }
        public decimal? TotalValorAduana { get; set; }

        // DTO NIETO (Lista de Conceptos: Incrementables y Decrementables)
        // Nota: En la vista los separamos filtrando por TipoConcepto
        public List<ManifestacionConceptoDto> ConceptosValor { get; set; } = new List<ManifestacionConceptoDto>();
    }

    // DTO NIETO (CONCEPTO)
    public class ManifestacionConceptoDto
    {
        public string ClaveConcepto { get; set; }
        public DateTime? FechaErogacion { get; set; }
        public decimal Importe { get; set; }
        public string? TipoMoneda { get; set; }
        public decimal? TipoCambio { get; set; }
        public bool? ACargoImportador { get; set; }
        public string TipoConcepto { get; set; } // "INCREMENTABLE" o "DECREMENTABLE"
    }
}