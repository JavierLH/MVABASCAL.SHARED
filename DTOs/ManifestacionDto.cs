using System;
using System.Collections.Generic;

namespace SistemaAduanero.Shared.DTOs
{
    // DTO PRINCIPAL (ABUELO)
    public class ManifestacionDto
    {
        public int ManifestacionId { get; set; }
        public string NumeroPedimento { get; set; } // Referencia
        public string TipoOperacion { get; set; }
        public List<ManifestacionCoveDto> ManifestacionCoves { get; set; } = new List<ManifestacionCoveDto>();
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

        public DateTime? FechaPago { get; set; }
        public decimal? TotalPago { get; set; }
        public string? TipoPago { get; set; }
        public string? MonedaPago { get; set; }
        public decimal? TipoCambioPago { get; set; }
        public string? MetodoValoracion { get; set; }

        public decimal? TotalPrecioPagado { get; set; }
        public decimal? TotalPrecioPorPagar { get; set; }
        public decimal? TotalIncrementables { get; set; }
        public decimal? TotalDecrementables { get; set; }
        public decimal? TotalValorAduana { get; set; }

        // DTO NIETO (Lista de Conceptos/Incrementables)
        public List<ManifestacionConceptoDto> ManifestacionConceptosValor { get; set; } = new List<ManifestacionConceptoDto>();
    }

    // DTO NIETO (CONCEPTO)
    public class ManifestacionConceptoDto
    {
        public string ClaveConcepto { get; set; } // Tipo (INCRE.GS)
        public DateTime? FechaErogacion { get; set; }
        public decimal Importe { get; set; }
        public string? TipoMoneda { get; set; }
        public decimal? TipoCambio { get; set; }
        public bool? ACargoImportador { get; set; }
        public string TipoConcepto { get; set; } // "INCREMENTABLE"
    }
}