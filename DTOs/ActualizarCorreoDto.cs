using System;
using System.Collections.Generic;

namespace SistemaAduanero.Shared.DTOs
{
    public class ActualizarCorreoDto
    {
        public string? Email { get; set; }
        public List<UsuarioCorreo> CorreosExtras { get; set; } = new List<UsuarioCorreo>();
    }
}
