using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAduanero.Shared.DTOs
{
    public class NotaExpedienteDto
    {
       
        public int NotaId { get; set; }
        public string UsuarioNombre { get; set; } = string.Empty;
        public string Mensaje { get; set; } = string.Empty;
        public DateTime Fecha { get; set; }
        public bool EsMio { get; set; } // Para pintar a la derecha/izquierda
    }
}