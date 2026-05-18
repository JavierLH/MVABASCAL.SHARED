using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAduanero.Shared.Constants
{
   
       public static class EstadoVucem
       {
           public const string Pendiente = "PENDIENTE";             // Fase 1: Solo guardado localmente
           public const string Enviado = "ENVIADO";                 // Fase 2: Expediente de valor transmitido (Tiene No. Operación)
           public const string Sincronizado = "SINCRONIZADO";       // Fase 3: E-documents vinculados local y externamente
           public const string Completo = "COMPLETO";               // Fase 4: VUCEM asignó el número definitivo de MV
           public const string EnCorreccion = "EN_CORRECCION";       // Estado comodín para cuando se rehabilita
       }
    
}


