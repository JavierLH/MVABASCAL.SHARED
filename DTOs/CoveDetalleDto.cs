namespace SistemaAduanero.Shared.DTOs
{
    public class CoveDetalleDto
    {
        // <cove>
        public string NumeroCove { get; set; }

        // <incoterm>
        public string? Incoterm { get; set; }

        // <existeVinculacion> (XML usa 0/1, aquí usamos bool para facilitar)
        public bool ExisteVinculacion { get; set; }

        // <pedimento>
        public string? NumeroPedimento { get; set; }
        public int Patente { get; set; }
        public int Aduana { get; set; }

        // <precioPagado>
        public DateTime FechaPago { get; set; } = DateTime.Now;
        public decimal TotalPago { get; set; }
        public string? TipoPago { get; set; } = "FORPAG.TE"; // Valor por defecto del XML
        public string? MonedaPago { get; set; } = "USD";
        public decimal TipoCambioPago { get; set; }

        // <metodoValoracion>
        public string? MetodoValoracion { get; set; } = "VALADU.VTM";

        // <valorEnAduana> (Totales calculados)
        public decimal TotalPrecioPagado { get; set; }
        public decimal TotalPrecioPorPagar { get; set; }
        public decimal TotalIncrementables { get; set; }
        public decimal TotalDecrementables { get; set; }
        public decimal TotalValorAduana { get; set; }
        public List<IncrementableDto> Incrementables { get; set; } = new List<IncrementableDto>();

        // NOTA: Los <incrementables> individuales (la lista) 
        // los manejaremos en la tabla de conceptos que ya creamos, 
        // vinculándolos a este COVE en el futuro.
    }
}