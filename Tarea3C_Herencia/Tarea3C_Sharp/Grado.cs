using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3C_Sharp
{
    internal class Grado
    {
        List<Alumno> lstAlumnos = new List<Alumno>();

        public int limite { get; set; } = 10; //limite alumno

        public bool Registro(Alumno alum)
        {
            if (lstAlumnos.Count==this.limite) //verificamos el limite
            {
                 throw new GradoException("Ya se alcanzo el número máximo de alumnos");
            }
            lstAlumnos.Add(alum);
            return true;
            
        }


    }
}
