using SistemaAduanero.Shared.DTOs;
namespace SistemaAduanero.Shared.DTOs
{
    public class CoveDetalleDto
    {
        // Identificadores Generales
        public int CoveId { get; set; }
        public string IdTemporal { get; set; } = Guid.NewGuid().ToString();
        public string? NumeroCove { get; set; }
        public string? Incoterm { get; set; }
        public bool ExisteVinculacion { get; set; }
        public string? MetodoValoracion { get; set; }
        public string? NumeroPedimento { get; set; }
        public int? Patente { get; set; }
        public int? Aduana { get; set; }

        // Listas 1:N
        public List<PrecioPagadoDto> PreciosPagados { get; set; } = new();
        public List<PrecioPorPagarDto> PreciosPorPagar { get; set; } = new();
        public List<CompensacionDto> Compensaciones { get; set; } = new();

        // Incrementables y Decrementables
        public List<ConceptoValorDto> Incrementables { get; set; } = new();
        public List<ConceptoValorDto> Decrementables { get; set; } = new();
    }




    // DTOs auxiliares basados en tu XML
    public class PrecioPagadoDto
    {
        public DateTime? FechaPago { get; set; }
        public decimal Total { get; set; }
        public string TipoPago { get; set; }
        public string TipoMoneda { get; set; }
        public decimal TipoCambio { get; set; }
    }

    public class PrecioPorPagarDto
    {
        public DateTime? FechaPago { get; set; }
        public decimal Total { get; set; }
        public string SituacionNoFechaPago { get; set; }
        public string TipoPago { get; set; }
        public string TipoMoneda { get; set; }
        public decimal TipoCambio { get; set; }
    }

    public class CompensacionDto
    {
        public DateTime? Fecha { get; set; }
        public string Motivo { get; set; }
        public string PrestacionMercancia { get; set; }
        public string TipoPago { get; set; }
    }
}