namespace SistemaAduanero.Shared.DTOs
{
    // EL MEGA DTO PRINCIPAL
    public class PeticionManifestacionVucemDto
    {
        // 1. Credenciales SAT
        public string UsuarioWcf { get; set; }
        public string PasswordWcf { get; set; }
        public string CertificadoBase64 { get; set; }
        public string LlavePrivadaBase64 { get; set; }
        public string PasswordLlave { get; set; }

        // 2. Datos Generales de la Manifestación
        public string RfcImportador { get; set; }
        public string Referencia { get; set; }
        public string NumeroPedimento { get; set; }
        public string TipoOperacion { get; set; } // Ej: "1" (Importación)
        public bool ExisteVinculacion { get; set; }

        // 3. Totales
        public decimal TotalValorAduana { get; set; }
        public decimal TotalPrecioPagado { get; set; }
        public decimal TotalPrecioPorPagar { get; set; }
        public decimal TotalIncrementables { get; set; }
        public decimal TotalDecrementables { get; set; }
        public string CadenaOriginal { get; set; }
        // 4. Listas Relacionales
        public List<PersonaConsultaVucemDto> PersonasConsulta { get; set; } = new();
        public List<CoveVucemDto> Coves { get; set; } = new();
    }

    public class PersonaConsultaVucemDto
    {
        public string RfcConsulta { get; set; }
        public string TipoFigura { get; set; }
    }

    public class CoveVucemDto
    {
        public string NumeroCove { get; set; }
        public string Incoterm { get; set; }
        public bool ExisteVinculacion { get; set; }
        public string NumeroPedimento { get; set; }
        public string Aduana { get; set; }
        public string Patente { get; set; }
        public string MetodoValoracion { get; set; }

        public List<PagoVucemDto> PreciosPagados { get; set; } = new();
        public List<PagoVucemDto> PreciosPorPagar { get; set; } = new();
        public List<CompensacionVucemDto> Compensaciones { get; set; } = new();
        public List<ConceptoVucemDto> Incrementables { get; set; } = new();
        public List<ConceptoVucemDto> Decrementables { get; set; } = new();
    }

    // Usamos el mismo DTO para Pagado y Por Pagar para simplificar
    public class PagoVucemDto
    {
        public DateTime? FechaPago { get; set; }
        public decimal Total { get; set; }
        public string TipoPago { get; set; }
        public string TipoMoneda { get; set; }
        public decimal TipoCambio { get; set; }
        public string SituacionNoFechaPago { get; set; } // Solo para PorPagar
        public string DescripcionOtroPago { get; set; }
    }

    public class CompensacionVucemDto
    {
        public DateTime? Fecha { get; set; }
        public string Motivo { get; set; }
        public string PrestacionMercancia { get; set; }
        public string TipoPago { get; set; }
        public string DescripcionOtroPago { get; set; }
    }

    public class ConceptoVucemDto
    {
        public string ClaveConcepto { get; set; }
        public DateTime? FechaErogacion { get; set; }
        public decimal Importe { get; set; }
        public string TipoMoneda { get; set; }
        public decimal TipoCambio { get; set; }
        public bool AcargoImportador { get; set; }
    }
}