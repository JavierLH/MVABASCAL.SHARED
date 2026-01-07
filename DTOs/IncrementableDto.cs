using System;

namespace SistemaAduanero.Shared.DTOs
{
    public class IncrementableDto
    {
        public string TipoIncrementable { get; set; }
        public DateTime? FechaErogacion { get; set; } = DateTime.Now;
        public decimal Importe { get; set; }
        public string TipoMoneda { get; set; } 
        public decimal TipoCambio { get; set; }
        public bool ACargoImportador { get; set; } = true;
    }
}