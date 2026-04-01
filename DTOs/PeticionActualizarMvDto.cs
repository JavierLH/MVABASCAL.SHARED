using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAduanero.Shared.DTOs
{
    public class PeticionActualizarMvDto
    {
        public string UsuarioWcf { get; set; }
        public string PasswordWcf { get; set; }
        public string CertificadoBase64 { get; set; }
        public string LlavePrivadaBase64 { get; set; }
        public string PasswordLlave { get; set; }
        public string NumeroMV { get; set; }
        public List<string> Edocuments { get; set; }
        public List<PersonaConsultaActualizarDto> PersonasConsulta { get; set; }
    }

    public class PersonaConsultaActualizarDto
    {
        public string RfcConsulta { get; set; }
        public string TipoFigura { get; set; }
    }
}