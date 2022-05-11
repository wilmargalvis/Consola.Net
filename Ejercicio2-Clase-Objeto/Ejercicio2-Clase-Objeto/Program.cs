using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_Clase_Objeto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Acceso a propiedades de la clase padre
            Alumno Alumno = new Alumno();

            Console.WriteLine("Datos del estudiante:");
            Console.WriteLine();
            Console.WriteLine(Alumno.Nombre = "Sebastian Agudelo");
            Console.Write("Edad: ");
            Console.WriteLine(Alumno.Edad = "35");
            Console.Write("Dirección: ");
            Console.WriteLine(Alumno.Direccion = "Mirasol");
            Console.Write("Cedula: ");
            Console.WriteLine(Alumno.Cedula = "123456789");

            //Acceso a propiedades de la clase hija
            Console.Write("Carrera: ");
            Console.WriteLine(Alumno.Carrera = "Desarrollo de Software");
            Console.WriteLine("-------");

            //Acceso a un método de la clase hija, y ver una propiedad de la clase padre
            string Materia = "Estructura de datos";
            Alumno.MatricularMateria(Materia, Alumno.Creditos = 25);

            //Acceso a un método de la clase padre
            string Costo = "3000";
            string Semestres = "10";
            Alumno.consultaPensum(Costo, Semestres);


            Console.WriteLine("");
            Console.WriteLine("Presione una tecla para salir");
            Console.ReadLine();

        }
    }

    public class Persona {
        public string Nombre { get; set; }
        public string Edad { get; set; }
        public string Direccion { get; set; }
        public string Cedula { get; set; }
        public void consultaPensum( string costo, string semestres)
        {
            Console.WriteLine("El costo del semestre es: " + costo);
            Console.WriteLine("La cantidad de semestres es: " + semestres);
        }
    }

    public class Alumno:Persona {
        public string Carrera { get; set; }
        public int Creditos { get; set; }

        public void MatricularMateria(string materia, int creditos) {
            Console.WriteLine(Nombre + ", ha matriculado la asignatura: " + materia + ", con unos creditos iguales a: " + creditos);
        }

    }

}
