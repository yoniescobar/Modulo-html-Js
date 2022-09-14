using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4C_Serializar
{
    //gregar clase using y agregar los metodos (click en ISerializable e implemente la interfaz)
    public class Alumno
    {
        public string Carne { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNac { get; set; }
        public int ClaseAsignada { get; set; }
        public Alumno():this("N/A","N/A","N/A",DateTime.Parse("1/1/1"),1) //en caso no me envie los datos
        {
        }//constructor vacio por omision

        //contructor con parametros
        public Alumno(string carne="N/A", string nombre="N/A", string apellido="N/A", DateTime fechaNac=default(DateTime), int claseAsignada=1)
        {
            this.Carne = carne;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.FechaNac = fechaNac;
            this.ClaseAsignada = claseAsignada;

        }
        public override string ToString()
        {

            return $"Carne: {Carne}, Nombre: {Nombre}, Apellido{Apellido} Fecha Nacimiento: {FechaNac} Clase Asignada:{ClaseAsignada}";
        }

    }
}
