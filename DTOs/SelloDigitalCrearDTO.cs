using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace SistemaAduanero.API.DTOs // O la carpeta donde lo pusiste
{
    public class SelloDigitalCrearDTO
    {
        [Required]
        public int ClienteId { get; set; }

        [Required]
        public IFormFile ArchivoCer { get; set; }

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