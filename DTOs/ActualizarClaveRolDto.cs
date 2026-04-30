using System.ComponentModel.DataAnnotations;

namespace SistemaAduanero.Shared.DTOs
{
    public class ActualizarClaveRolDto
    {
        [Required(ErrorMessage = "La contraseña es obligatoria.")]
        public string NuevaContraseña { get; set; } = string.Empty;
    }
}
