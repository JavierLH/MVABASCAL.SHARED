namespace SistemaAduanero.Shared.DTOs
{
    public class ConceptoValorDto
    {
        public string TipoConcepto { get; set; } = "INCREMENTABLE"; // O DECREMENTABLE
        public string Descripcion { get; set; }
        public decimal Importe { get; set; }
        public string Moneda { get; set; } = "MXN";
    }
}