using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAduanero.Shared.DTOs
{
    public class PeticionEjecutarConsultaDto
    {
        // Credenciales WCF
        public string UsuarioWcf { get; set; }
        public string PasswordWcf { get; set; }

        // Datos para consultar el Acuse
        public string RfcSolicitante { get; set; }
        public long NumeroOperacion { get; set; }

        // Credenciales y archivos de la e.firma (Sellos)
        public string PasswordLlave { get; set; }
        public string CertificadoBase64 { get; set; } // Archivo .cer
        public string LlavePrivadaBase64 { get; set; } // Archivo .key
    }
}