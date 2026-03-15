using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAduanero.Shared.DTOs
{
    public class DocumentoExpedienteDto
    {
        public int AnexoId { get; set; }
       
        public int IdDocumento { get; set; }
        public string NombreDocumento { get; set; } = string.Empty;
        public bool EsObligatorioCatalogo { get; set; } 

        public string? NombreArchivo { get; set; }
        public string? UrlDescarga { get; set; }
        public DateTime? FechaCarga { get; set; }

        // --- CONTROLES DE REVISIÓN ---
        public bool Revisado { get; set; }
        public bool Exento { get; set; }

        // --- CAMPOS PARA VUCEM ---
        public string? Edocument { get; set; }
        public string? NOperacion { get; set; }
        public bool EnviarVucem { get; set; }
    }
}