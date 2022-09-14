using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3C_Sharp
{
    internal class Maestro:Persona
    {
        public Maestro():base() //constructor default
        {

        }
        public Maestro(string nombres, string  apellidos, string carnet, DateTime fechaNac)
            : base(nombres, apellidos, carnet, fechaNac)
        {

        }

        //Ya heredado atributos y metodos (sobre escribo metodo CrearContraseña)
        public override bool CrearContrasena(string contrasena)
        {
            if (contrasena.Length>7)
            {
                this.contrasena = contrasena;
                return true;
            }
            return false;
        }


    }
}
