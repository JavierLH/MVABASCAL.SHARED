using System.ComponentModel.DataAnnotations;

namespace SistemaAduanero.Shared.DTOs
{
    public class EliminarManifestacionVucemDto
    {
        [Required(ErrorMessage = "La contraseña de autorización es obligatoria.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Debes ingresar un motivo para la rehabilitación.")]
        [MaxLength(500)]
        public string Motivo { get; set; }
    }
}