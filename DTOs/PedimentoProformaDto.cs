namespace SistemaAduanero.Shared.DTOs
{
    /// <summary>
    /// DTO de resultado del parseo del PDF de Proforma Pedimento.
    /// Las propiedades son planas para simplificar el bindeo en el frontend Blazor.
    /// </summary>
    public class PedimentoProformaDto
    {
        // --- TEXTO COMPLETO (uso interno para depuración) ---
        public string? TextoCompleto { get; set; }

        // --- IDENTIFICACIÓN GENERAL ---
        public string? Referencia { get; set; }
        public string? NumeroPedimento { get; set; }
        public string? TipoOperacion { get; set; }
        public string? ClavePedimento { get; set; }
        public string? Regimen { get; set; }

        // --- ADUANA Y VALORES ---
        public string? Aduana { get; set; }
        public string? TipoCambio { get; set; }
        public string? PesoBruto { get; set; }
        public string? ValorDolares { get; set; }
        public string? ValorAduana { get; set; }
        public string? PrecioPagado { get; set; }

        // --- IMPORTADOR ---
        public string? RfcImportador { get; set; }
        public string? NombreImportador { get; set; }
        public string? CurpImportador { get; set; }

        // --- PROVEEDOR / FACTURA ---
        public string? IdFiscalProveedor { get; set; }
        public string? NumeroFactura { get; set; }
        public string? FechaFactura { get; set; }
        public string? Incoterm { get; set; }
        public string? Moneda { get; set; }
        public string? ValorMonedaFactura { get; set; }

        // --- TRANSPORTE ---
        public string? Identificacion { get; set; }
        public string? NumeroGuia { get; set; }

        // --- AGENTE ADUANAL ---
        public string? Patente { get; set; }
        public string? NombreAgenteAduanal { get; set; }
        public string? RfcAgenteAduanal { get; set; }
        public string? CurpAgenteAduanal { get; set; }

        public string? Complemento1 { get; set; }
        public string? Complemento2 { get; set; }
        public string? Complemento3 { get; set; }

        public List<string>? ListaClaveCoves { get; set; } = new List<string>();
        public List<string>? ListaFactura {  get; set; }

    }

    public class AnexoPedimento
    {

        public string NumeroFactura { get; set; }
        public string COVE {  get; set; }

        public List<Partidas> Partidas { get; set; }

    }

    public class Partidas
    {
        public string Fraccion {  get; set; }
        public string IdentificacionComercial { get; set; }
        public string Vinculacion {  get; set; }
        public string MetodoValoracion  { get; set; } 

        public double VALADUUSD { get; set; }

    }

}