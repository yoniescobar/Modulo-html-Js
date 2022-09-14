using System;

namespace Tarea3C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AgregarAlumnos();

        }
        public static void AgregarAlumnos()
        {
            Alumno a = new Alumno();

            if (a.CrearContrasena("123456789"))
            {
                Console.WriteLine("Exito");
            }
            else
            {
                Console.WriteLine("Mala contraseña");
            }



            Grado grado = new Grado();
        
            grado.Registro(new Alumno("Yoni Edilzar 1", "Escobar Bautista", "12003901", DateTime.Parse("1988-09-01")));
            grado.Registro(new Alumno("Yoni Edilzar 2", "Escobar Bautista", "12003902", DateTime.Parse("1988-09-01")));
            grado.Registro(new Alumno("Yoni Edilzar 3", "Escobar Bautista", "12003903", DateTime.Parse("1988-09-01")));
            grado.Registro(new Alumno("Yoni Edilzar 4", "Escobar Bautista", "12003904", DateTime.Parse("1988-09-01")));
            grado.Registro(new Alumno("Yoni Edilzar 5", "Escobar Bautista", "12003905", DateTime.Parse("1988-09-01")));
            grado.Registro(new Alumno("Yoni Edilzar 6", "Escobar Bautista", "12003906", DateTime.Parse("1988-09-01")));
            grado.Registro(new Alumno("Yoni Edilzar 7", "Escobar Bautista", "12003906", DateTime.Parse("1988-09-01")));
            grado.Registro(new Alumno("Yoni Edilzar 8", "Escobar Bautista", "12003906", DateTime.Parse("1988-09-01")));
            grado.Registro(new Alumno("Yoni Edilzar 9", "Escobar Bautista", "12003906", DateTime.Parse("1988-09-01")));
            grado.Registro(new Alumno("Yoni Edilzar 10", "Escobar Bautista", "12003906", DateTime.Parse("1988-09-01")));

           //Exception grado.Registro(new Alumno("Yoni Edilzar 11", "Escobar Bautista", "12003906", DateTime.Parse("1988-09-01")));

        }
    }
}
