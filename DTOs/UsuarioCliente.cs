using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SistemaAduanero.Shared.DTOs;

namespace SistemaAduanero.Shared.DTOs
{
    [Table("UsuarioClientes")]
    public class UsuarioCliente
    {
        [Key]
        public int Id { get; set; }

        public int UsuarioId { get; set; }
        public int ClienteId { get; set; }

        // Navegación (Puentes para llegar a los datos)
        [ForeignKey("UsuarioId")]
        public virtual Usuario? Usuario { get; set; }

        [ForeignKey("ClienteId")]
        public virtual ClienteDto? Cliente { get; set; }
    }

    public partial class Usuario
    {
        public int UsuarioId { get; set; }



        public int RolId { get; set; }

        public string NombreCompleto { get; set; } = null!;

        public string Username { get; set; } = null!;

        public string? PasswordHash { get; set; } 

        public DateTime? UltimoAcceso { get; set; }

        public bool? Activo { get; set; }

        public virtual Role? Rol { get; set; }
        public virtual ICollection<UsuarioCliente> UsuarioClientes { get; set; } = new List<UsuarioCliente>();

        // === NUEVO: AUXILIAR PARA EL FORMULARIO (No va a la BD) ===
        [NotMapped]
        public string PasswordSinEncriptar { get; set; } = "";
    }

    public partial class Role
    {
        public int RolId { get; set; }

        public string NombreRol { get; set; } = null!;

        public string? Descripcion { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();

        public virtual ICollection<Permiso> Permisos { get; set; } = new List<Permiso>();
    }

    public partial class Permiso
    {
        public int PermisoId { get; set; }

        public string CodigoPermiso { get; set; } = null!;

        public string? Descripcion { get; set; }

        public virtual ICollection<Role> Rols { get; set; } = new List<Role>();
    }


}
