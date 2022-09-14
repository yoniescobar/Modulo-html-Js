using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2C_Sharp.Clases
{
     public class Grado //se hace publico, no implementa nada
    {
        public string Nombre { get; set; }
        public Maestro MaestroAsignado { get; set; } ////agregar otra propiedad de tipo Maestro segun interfaz tipo de dato Maestro
    }
}
