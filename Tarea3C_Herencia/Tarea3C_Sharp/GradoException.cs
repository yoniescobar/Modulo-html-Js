using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3C_Sharp
{
    internal class GradoException : Exception
    {
        public GradoException():base()
        {
        
        }
        public GradoException(string mensaje): base(mensaje)
        {

        }
        public GradoException(string mensaje, Exception ex): base(mensaje, ex)
        {

        }
    }
}
