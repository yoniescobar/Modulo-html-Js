using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea2C_Sharp.Intefaces;

namespace Tarea2C_Sharp.Clases
{
    public class Maestro : Persona // y hacemos publico la clase Maestro: que apunta a persona
    {
         public DateTime FechaContratacion { get; set; }  //propiedad Extra
        public string ID { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string ApellidoCasada { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
