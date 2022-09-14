using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2C_Sharp.Intefaces
{
    internal interface Persona  //interaz persona
    {
        public string ID { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido{ get; set; }
        public string SegundoApellido { get; set; }
        public string ApellidoCasada { get; set; }
        public DateTime FechaNacimiento { get; set; }

    }
}
