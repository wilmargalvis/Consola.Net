using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos
{
    class Program
    {

        /*Realizar un programa para:
         
        1. Realizar el ingreso de la información mencionada.
        2. Generar un vector que contenga el ingreso acumulado en sueldos en los últimos 3 meses para cada operario.
        3. Mostrar por pantalla el total pagado en sueldos a todos los operarios en los últimos 3 meses
        4. Obtener el nombre del operario que tuvo el mayor ingreso acumulado */
        public class numeros {
            public int num1 { get; set; }
            public int num2 { get; set; }
            public int num3 { get; set; }
        }
        static void Main(string[] args)
        {
            CadenasString();

            AccesoLista();//Linq desde una lista previamente llena

            string [,] Empleados = LlenarMatrizEmpleadosSueldos();

            (string[,] IngresosxEmpleado, int sumaTodosSueldos) = SumaSueldos(Empleados);

            ImprimirSueldos(IngresosxEmpleado, sumaTodosSueldos);

        }

        private static void CadenasString()
        {
            string cadena = "   Hola, bienvenidos a programando en C#!";
            Console.WriteLine(cadena + "\n");
            int tamaño = cadena.Length;
            string subcadena = "venidos";
            if (subcadena.Contains(subcadena)) {
                Console.WriteLine("La subcadena {0} si se encuentra en la cadena",subcadena);
            }
            Console.WriteLine("{0} es la posicíon de 'do' en la cadena", cadena.IndexOf("do"));
            Console.WriteLine("{0} es la posicíon del último 'do' en la cadena", cadena.LastIndexOf("do"));
            Console.WriteLine("{0} es la mayúscula de la cadena ", cadena.ToUpper());
            Console.WriteLine("{0} es la minúscula de la cadena ", cadena.ToLower());
            Console.WriteLine("Hemos insertado 'amigos a la cadena: '{0}", cadena.Insert(6,"amigos "));
            Console.WriteLine("Hemos insertado 'amigos a la cadena: '{0}", cadena.Remove(6,13));
            Console.WriteLine("Hemos insertado 'amigos a la cadena: '{0}", cadena.Replace("bienvenidos a", "empecemos"));
            Console.WriteLine("La cadena inicia con Hola: '{0}", cadena.StartsWith("Hola"));
            Console.WriteLine("Se obtiene la cadena despues de la posición 15 hasta la 22: '{0}", cadena.Substring(15,22));
            Console.WriteLine("Se eliminan caracteres al inicio y al final de la cadena: {0}", cadena.Trim(' ', '!'));

        }

        private static void AccesoLista()
        {
            string cadena = "Maria Nelson Sebas Liliana Vero Nelson pedro,Maria";
            //string [] palabras = cadena.Split(' ');
            string[] palabras = cadena.Split(' ', ',');

            List<string> listaNombres = new List<string> {
                {"Maria"},
                { "Nelson"},
                {"Sebas"},
                {"Liliana"},
                {"Vero"},
                {"Nelson"},
                {"pedro"}
            };

            //https://docs.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1.indexof?view=net-6.0
            listaNombres.IndexOf("Nelson");
            listaNombres.IndexOf("Nelson",3); //A partir de la posición 3
            int prueba = listaNombres.LastIndexOf("Nelson"); // Posición de la última conincidencia encontrada

            var queryNombres = from nombre in listaNombres
                                           //where cust.num2 == 13
                                       where nombre == "Nelson" || nombre == "pedro"
                                       orderby nombre descending
                                       select nombre;
            foreach (var item in queryNombres)
            {
                int i = 0;
                Console.WriteLine("Item {0}. {1}",(i+1),item);
            }
            List<numeros> lista = new List<numeros> {

                new numeros(){num1=1,num2=3,num3=5 },
                new numeros(){num1=10,num2=2,num3=6 },
                new numeros(){num1=20,num2=13,num3=40 },
                new numeros(){num1=11,num2=15,num3=0 }
            };

            var queryNumeros = from numero in lista
                                       where numero.num1 == 11 && numero.num3 == 0
                                       group numero by numero.num3;
                                       //select cust;


        }

        private static string [,] LlenarMatrizEmpleadosSueldos()
        {
            string[,] Empleados = new string[4, 4];

            for (int i = 0; i < Empleados.GetLength(0); i++) // GetLength(0) es el número de filas = # Empleados
            {
                Console.WriteLine("Ingrese el nombre del empleado");
                Empleados[i, 0] = Console.ReadLine();

                for (int j = 0; j <= 2; j++)
                {

                    Console.WriteLine("Ingrese el sueldo del 1mer mes del empleado");
                    Empleados[i, j + 1] = Console.ReadLine();
                }

            }
            return Empleados;
        }

        private static (string [,], int) SumaSueldos(string[,] empleados)
        {
            int sumaSueldoxEmpleado = 0;
            string[,] IngresosxEmpleado = new string[4,2];
            int sumaTodosSueldos = 0;
            for (int i = 0; i <=3; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    if (j == 0)
                    {
                        IngresosxEmpleado[i, 0] = empleados[i, j]; // Agrega nombres empleados
                    }
                    else {
                        sumaTodosSueldos = sumaTodosSueldos + int.Parse(empleados[i, j]);
                        sumaSueldoxEmpleado = sumaSueldoxEmpleado + int.Parse(empleados[i, j]);

                    }
                }

                IngresosxEmpleado[i,1] = sumaSueldoxEmpleado.ToString(); // Agrega sueldos empleados
                sumaSueldoxEmpleado = 0;

            }

            return (IngresosxEmpleado, sumaTodosSueldos);

        }

        private static void ImprimirSueldos(string [,] IngresosxEmpleado,int sumaTodosSueldos)
        {
            int sueldoMayor = 0;
            string nombreEmpleado = "";
            for (int i = 0; i <= 3; i++)
            {
                if (sueldoMayor < int.Parse(IngresosxEmpleado[i, 1]))
                {
                    sueldoMayor = int.Parse(IngresosxEmpleado[i, 1]);
                    nombreEmpleado = IngresosxEmpleado[i, 0].ToString();
                }
            }

            Console.WriteLine("El total de sueldos es:" + sumaTodosSueldos);
            Console.WriteLine($"El sueldo mayor es: {sueldoMayor} y el nombre del empleado es {nombreEmpleado}");
            Console.ReadKey();
        }
    }
}
