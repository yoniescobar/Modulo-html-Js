using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

namespace Tarea4C_Serializar
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Alumno> alumnos = listadoAlumnos();

            SerializarDatosXml(alumnos);
            SerializarDatosJson(alumnos);
            DeserializeDatosXml(alumnos);
        }
        public static List<Alumno> listadoAlumnos()
        {
            List<Alumno> alumnos = new()  //lista  de Alumnos
            {

                new("12003901", "Ederson Alexander", "Alvarado Chan", DateTime.Parse("1988/07/04"), 1),
                new("12003902", "Henry Ismael", "Alvarado Chan", DateTime.Parse("1988/07/04"), 2),
                new("12003903", "Rudy David", "Caniz Calel", DateTime.Parse("1988/07/04"), 2),
                new("12003904", "Estefany Liliana", "de León Pérez", DateTime.Parse("1988/07/04"), 1),
                new("12003905", "Katerin Melysa", "García Ramírez", DateTime.Parse("1988/07/04"), 1),
                new("12003906", "Meyli Isabel", "Lux Ichel", DateTime.Parse("1988/07/04"), 3),
                new("12003906", "Dairy Yolanda", "Ventura Guox", DateTime.Parse("1988/07/04"), 3),
                new("12003907", "Bryan René", "Zavala Coyoy", DateTime.Parse("1988/07/04"), 3),
                new("12003908", "Lesly Michelle", "Salalanic Pablo ", DateTime.Parse("1988/07/04"), 3),
                new("12003909", "Dairy Yolanda", "Zacarias Coyoy", DateTime.Parse("1988/07/04"), 3),
                new( nombre:"Rosario del Milagro", apellido:"López Pastor",fechaNac:DateTime.Parse("1988/07/04"), claseAsignada:3),
            };
            Alumno Alum = new();
            alumnos.Add(Alum);

            return alumnos;
        }
        public static void SerializarDatosXml(List<Alumno> alumnos)
        {
            string directorio = @"C:\DatosAlumnos";


            if (!Directory.Exists(directorio))
            {

                Directory.CreateDirectory(directorio);
            }
            string archivoXML = @$"{directorio}\Alumnos.xml"; //Creamos caperta DatosAlumnos para la Ruta en donde grabaremos el archivo
            XmlSerializer escritor = new(alumnos.GetType());  //le enviamos la lista y el detecta el tipo de objeto que pertenece iene diferentes formato y lee el que corresponde xml o Json



            using (FileStream fs = File.Create(archivoXML)) //Serializar Datos y Guardar en un block de notas
            {
                escritor.Serialize(fs, alumnos); //lo guardardo en un block de notas el archivo ya  serializados
            }


            string xmlSerializado = string.Empty; //Empty coloca vacio el texto.   Serializar Datos y mostrarlo en consola con un String
            using (StringWriter sw = new StringWriter())
            {
                escritor.Serialize(sw, alumnos); //serilizar listado de alumnos a XML
                xmlSerializado = sw.ToString(); // para visualizar los datos serializados lo pasamos a cadena
            }
            Console.WriteLine(xmlSerializado); //muestra datos serializado en la cadena convertida

        }

        public static void SerializarDatosJson(List<Alumno> alumnos)
        {


            Console.WriteLine("\n\n------------Serializar Datos Json String-------------------");
            string json = JsonSerializer.Serialize(alumnos); //datos convertidos Json
            Console.WriteLine(json);
        }

        public static void DeserializeDatosXml(List<Alumno> alumnos)
        {
            string archivoXML = @"C:\DatosAlumnos\Alumnos.xml"; //ubicacion de archivo
            using (FileStream cargarXML = File.Open(archivoXML,FileMode.Open))
            {
                XmlSerializer lector = new(typeof(List<Alumno>)); //especificar de que tipo archivo que es una lista de persona
                List<Alumno> Alumnos = lector.Deserialize(cargarXML) as List<Alumno>;
            }

            int cont = 1;

            Console.WriteLine("\n\n------------------Muestra los datos de la lista Alumnos ---------------------");

            foreach (Alumno alumno in alumnos)
            {
                Console.WriteLine($"Alumno Numero {cont++}: {alumno.Carne}, {alumno.Nombre}, {alumno.Apellido},{alumno.FechaNac}, {alumno.ClaseAsignada}");
            }

        }
    }
}
