using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAduanero.Shared.DTOs
{
    // DTO para enviar la información al frontend
    public class CorreoPerfilDto
    {
        public int Id { get; set; } // Opcional, dependiendo de si actualizas por ID o haces borrado/inserción
        public string Email { get; set; } = string.Empty;
    }

    // DTO para recibir la actualización desde el frontend
    public class ActualizarCorreosPerfilDto
    {
        public List<CorreoPerfilDto> Correos { get; set; } = new List<CorreoPerfilDto>();
    }
}
