using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3C_Sharp
{
    internal class Persona
    {
        public string Nombre { get; set; } //atributos
        public string Apellidos { get; set; }
        public string Carnet { get; set; }
        public DateTime FechaNacimiento { get; set; }
        
        //protected para usar con los hijos
        protected string contrasena; // uso de class protected, public virtual,  class this.    profundizar...


        //contructor
        public Persona() : this("", "", "", DateTime.Parse("1000-01-01"))
        {

        }
        public Persona(string nombre, String apellidos, string carnet, DateTime fechaNac)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Carnet = carnet;
            this.FechaNacimiento = fechaNac;
        }


        public virtual bool CrearContrasena(string contrasena)
        {    //ese metodo se va heredar para que los demas puedan sobre escribir(virtual)

            this.contrasena = contrasena;
            return true;
        }
    }
}
