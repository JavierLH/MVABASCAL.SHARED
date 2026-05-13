using System.ComponentModel.DataAnnotations;

namespace SistemaAduanero.Shared.DTOs;

public class UsuarioCorreo
{
    [Key]
    public int Id { get; set; }

    public int UsuarioId { get; set; }

    [Required]
    public string Email { get; set; } = "";
}
