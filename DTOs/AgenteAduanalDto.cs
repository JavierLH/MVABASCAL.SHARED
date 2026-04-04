namespace SistemaAduanero.Shared.DTOs
{
    public class AgenteAduanalDto
    {
        public int Id { get; set; }
        public string Patente { get; set; } = null!;
        public string Aduana { get; set; } = null!;
        public string ClaveAduana { get; set; } = null!;
        public string AgenteAduanal { get; set; } = null!;
        public string RFC { get; set; } = null!;
        public string TipoFiguraClave { get; set; } = null!;
    }
}
