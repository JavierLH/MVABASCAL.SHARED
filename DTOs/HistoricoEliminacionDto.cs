using System;

namespace SistemaAduanero.Shared.DTOs
{
    public class HistoricoEliminacionDto
    {
        public int Id { get; set; }
        public int ManifestacionId { get; set; }
        public string? NumeroPedimento { get; set; }
        public int UsuarioId { get; set; }
        public DateTime FechaEliminacion { get; set; }
        public string TipoEliminacion { get; set; } = string.Empty;
        public int? ClienteId { get; set; }
        public int? UsuarioCreadorId { get; set; }
        public string? TipoOperacion { get; set; }
        public bool? ExisteVinculacion { get; set; }
        public string? Referencia { get; set; }
        public decimal? TotalValorAduana { get; set; }
        public string? NumeroOperacionVucem { get; set; }
        public string? EstadoEnvio { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string? FolioManifestacion { get; set; }
        public string? CovesAsociados { get; set; }
        public string NombreUsuario { get; set; } = string.Empty;
        public string NombreCliente { get; set; } = string.Empty;
    }
}
