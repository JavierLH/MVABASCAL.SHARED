using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAduanero.Shared.DTOs
{
    [Table("Clientes")] // Mapea a tu tabla existente
    public class ClienteDto
    {
        [Key]
        public int ClienteId { get; set; }

        [Required]
        [MaxLength(13)]
        public string RFC { get; set; } = null!;

        [Required]
        [MaxLength(150)]
        public string RazonSocial { get; set; } = null!;

        [MaxLength(100)]
        public string? NombreContacto { get; set; }

        public DateTime? FechaRegistro { get; set; } = DateTime.Now;
        public bool? Activo { get; set; } = true;

        // === NUEVAS LISTAS ===
        // Inicializamos las listas para evitar errores de Null
        public List<ClienteEmail> Emails { get; set; } = new();
        public List<ClienteTelefono> Telefonos { get; set; } = new();
    }

    // Shared/Models/ClienteEmail.cs (NUEVO)
    [Table("ClienteEmails")]
    public class ClienteEmail
    {
        [Key]
        public int Id { get; set; }
        public int ClienteId { get; set; } // FK
        [Required]
        public string Email { get; set; } = "";
        public string? Etiqueta { get; set; } // "Facturación", etc.
    }

    // Shared/Models/ClienteTelefono.cs (NUEVO)
    [Table("ClienteTelefonos")]
    public class ClienteTelefono
    {
        [Key]
        public int Id { get; set; }
        public int ClienteId { get; set; } // FK
        [Required]
        public string Numero { get; set; } = "";
        public string? Etiqueta { get; set; } // "Móvil", etc.
    }
}

