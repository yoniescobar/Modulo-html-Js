using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3C_Sharp
{
    internal class Alumno:Persona //hago la herencia
    {
        public Alumno()
        {

        }
        public Alumno (string nombres, string apellidos, string carnet, DateTime fechaNac)
            : base(nombres, apellidos, carnet, fechaNac)
        {

        }

        //utilizo metodo heredado
        public override bool CrearContrasena(string contrasena)
        {
            if (contrasena.Length > 3 && contrasena.Length <= 8) //mayor a 7 caracteres
            {
                this.contrasena = contrasena;
                return true;
            }
            return false;
        }

    }
}
