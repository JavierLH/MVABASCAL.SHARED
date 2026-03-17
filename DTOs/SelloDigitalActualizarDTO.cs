using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAduanero.Shared.DTOs
{
    public class SelloDigitalActualizarDTO
    {
        [Required]
        public int ClienteId { get; set; }

        // Todo esto es opcional (?) porque el usuario podría solo querer cambiar la fecha de vencimiento
        public IFormFile? ArchivoCer { get; set; }
        public IFormFile? ArchivoKey { get; set; }
        public string? PasswordKey { get; set; }
        public string? PasswordVucem { get; set; }

        [Required]
        public DateTime? FechaVencimiento { get; set; }

        [Required]
        public bool Activo { get; set; }
    }
}
