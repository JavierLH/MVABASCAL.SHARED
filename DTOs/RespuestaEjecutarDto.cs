using System.Text.Json.Serialization;

namespace SistemaAduanero.API.Dto
{
    // --- DTO para la PRIMERA IMAGEN (Ejecutar / Registro) ---
    public class RespuestaEjecutarDto
    {
        public RespuestaBaseVucem respuestaBaseField { get; set; }
        public AcuseField acuseField { get; set; }
    }

    public class AcuseField
    {
        public long numeroOperacionField { get; set; }
        public DateTime horaRecepcionField { get; set; }
        public string mensajeField { get; set; }
    }

    // --- DTO para la SEGUNDA IMAGEN (Consultar Ejecutar) ---
    public class RespuestaConsultaContainerDto
    {
        public ConsultaResponse consultaDigitalizarDocumentoServiceResponse { get; set; }
    }

    public class ConsultaResponse
    {
        public string numeroDeTramiteField { get; set; }
        public string eDocumentField { get; set; }
        public string cadenaOriginalField { get; set; }
        public RespuestaBaseVucem respuestaBaseField { get; set; }
    }

    // --- COMÚN PARA AMBOS ---
    public class RespuestaBaseVucem
    {
        public bool tieneErrorField { get; set; }
        public string errorField { get; set; }
    }
}