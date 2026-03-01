using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAduanero.Shared.DTOs
{
    public class CambiarPasswordDto
    {
        public int UsuarioId { get; set; } 
        public string PasswordActual { get; set; } = string.Empty;
        public string NuevoPassword { get; set; } = string.Empty;
        public string ConfirmarPassword { get; set; } = string.Empty;
    }
}