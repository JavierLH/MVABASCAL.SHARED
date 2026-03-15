using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace SistemaAduanero.Shared.DTOs
{
    public class SelloDigitalCrearDTO
    {
        [Required]
        public string RFC { get; set; }

        public string RazonSocial { get; set; }

        [Required]
        public IFormFile ArchivoCer { get; set; } // Representa el archivo físico que sube el usuario

        [Required]
        public IFormFile ArchivoKey { get; set; }

        [Required]
        public string PasswordKey { get; set; }

        [Required]
        public string PasswordVucem { get; set; }

        [Required]
        public DateTime FechaVencimiento { get; set; }
    }
}
