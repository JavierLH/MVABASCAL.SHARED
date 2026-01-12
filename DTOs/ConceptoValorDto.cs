using System;

namespace SistemaAduanero.Shared.DTOs
{
    public class ConceptoValorDto
    {
        // Puede servir para guardar "INCRE.CG" o "DECRE.GT"
        public string TipoIncrementable { get; set; } = null!;

        public DateTime? FechaErogacion { get; set; }

        public decimal Importe { get; set; }

        public string? TipoMoneda { get; set; } // XML: <tipoMoneda>

        public decimal? TipoCambio { get; set; } // XML: <tipoCambio>

        public bool? ACargoImportador { get; set; } // XML: <aCargoImportador>
    }
}