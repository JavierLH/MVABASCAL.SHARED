using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAduanero.Shared.DTOs
{
    public class PeticionEjecutarDigitalizacionDto
    {
        // Credenciales WCF para la cabecera de seguridad
        public string UsuarioWcf { get; set; }
        public string PasswordWcf { get; set; }

        // Datos de negocio para el trámite
        public string RfcSolicitante { get; set; }
        public string Correo { get; set; }
        public int IdTipoDocumento { get; set; }
        public string NombreDocumento { get; set; } // Sin extensión .pdf
        public string RfcConsulta { get; set; }

        // Credenciales y archivos de la e.firma (Sellos) y Documento
        public string PasswordLlave { get; set; }
        public string CertificadoBase64 { get; set; } // Archivo .cer
        public string LlavePrivadaBase64 { get; set; } // Archivo .key
        public string ArchivoPdfBase64 { get; set; } // El documento a digitalizar
    }
}