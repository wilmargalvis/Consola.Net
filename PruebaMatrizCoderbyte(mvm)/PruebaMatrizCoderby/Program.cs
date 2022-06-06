using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaMatrizCoderby
{
    class Program
    {
        public static int[,] mat;
        public static int[] vector= { 10, 4, 5, 6, 8 };
        public static int AsientosGlobal = 0; //Declaramos un vector de tipo entero
        public static string AsientosDiponibles = "";
        public static List<string> lista = new List<string>();
        static void Main(string[] args)
        {

            //Solución Wilmar
            //AsientosDiponiblesWIlmar();

            //Solución Wilmar
            SeatingStudents();

            Console.ReadKey();


            /* SQL CONSULTA:  
             * 
             * SELECT ReportsTo,count(ID) as Members, round(avg(Age),0) as 'Average Age' FROM maintable_CKYJA
            where ReportsTo is not null Group By ReportsTo order by ReportsTo asc
            */

        }

        private static void AsientosDiponiblesWIlmar()
        {
            Console.WriteLine("Cual es el número de asiento");
            string asientos = Console.ReadLine();
            if (int.Parse(asientos) == 2)
            {
                Console.WriteLine("Debe ingresar mínimo 2 asientos");
            }
            int modulo = int.Parse(asientos) % 2;

            if (int.Parse(asientos) % 2 != 0)
            {
                Console.WriteLine("Debe ser un número par");
            }
            int AsientosPares = int.Parse((asientos));
            int[] vector = { (AsientosPares / 2), 2, 5, 9 };

            int[,] escritorios = new int[vector[0], 2];
            SeatingStudents(escritorios);
        }

        private static void SeatingStudents(int[,] escritorios)
        {
            int NumMatriz = 0;
            for (int i = 0; i < escritorios.GetLength(0); i++)
            {

                for (int j = 0; j < 2; j++)
                {
                    NumMatriz = NumMatriz + 1;
                    escritorios[i, j] = NumMatriz;
                    Console.Write(escritorios[i, j] + ", ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
            //Console.ReadKey();
        }

        //public static void LlenarVector()
        //{
        //    int n = 0;
        //    Console.WriteLine("Cantidad de asientos a cupar");
        //    string k = Console.ReadLine();
        //    vector = new int[int.Parse(k.ToString())];
        //    int contadorVector = 1;
        //    Random rand = new Random();
        //    for (int i = 0; i < int.Parse(k.ToString()); i++)
        //    {
        //        int number = rand.Next(1, 10);

        //        if (i == 0)
        //        {
        //            number = AsientosGlobal;
        //        }

        //        vector[i] = number;
        //        contadorVector++;
        //    }
        //}


        //public static void ImprimerVector()
        //{

        //    for (int f = 0; f < vector.Length; f++) Console.WriteLine("El valor deel vector  de la posicion " + (f + 1) + ": " + vector[f]);
        //}

        //public static void ImprimirDisponibles()
        //{

        //    for (int f = 0; f < mat.GetLength(0); f++)
        //    {

        //        for (int c = 0; c < mat.GetLength(1); c++)
        //        {
        //            int valor = mat[f, c];
        //        }


        //    }
        //}


        public static void ImprimirMatriz()
        {

            for (int f = 0; f < mat.GetLength(0); f++)
            {

                for (int c = 0; c < mat.GetLength(1); c++)
                {

                    Console.Write(mat[f, c] + " ");

                }
                Console.WriteLine();
            }

        }


        public static void SeatingStudents()
        {


            int columnas = 0;
            Console.WriteLine("Ingrese el numero de asientos");
            string k = Console.ReadLine();
            int asientos = int.Parse(k.ToString());
            AsientosGlobal = asientos;

            //LlenarVector();

            //int fila = 2;
            columnas = asientos / 2;

            if (asientos <= 24)
            {
                if (asientos % 2 == 0)
                {
                    Console.WriteLine("Correcto :" + k + " Columnas  " + columnas);

                    mat = new int[columnas, 2];
                    // string linea;
                    // linea = Console.ReadLine();

                    int contador = 1;
                    int valorContador = 0;
                    for (int f = 0; f < mat.GetLength(0); f++)
                    {
                        for (int c = 0; c < mat.GetLength(1); c++)
                        {
                            //Console.Write("Ingrese componente:");
                            //linea = Console.ReadLine();                          

                            for (int i = 0; i < vector.Length; i++)
                            {
                                int valorVector = vector[i];
                                if (valorVector == contador)
                                {
                                    valorContador = 0;
                                    i = vector.Length;

                                }
                                else
                                {
                                    valorContador = contador;

                                }

                            }



                            mat[f, c] = valorContador;
                            contador++;
                        }
                    }

                    /**/

                    ImprimirMatriz();
                    ImprimirDisponiblesHorinzontal();
                    ImprimirDisponiblesVertical();
                    //ImprimerVector();
                    //ImprimirDisponibles();

                }
                else
                {
                    Console.WriteLine("Incorrecto Correcto :" + k);
                }

            }
            else
            {
                Console.WriteLine("El numero de asientos no es correcto");
            }



        }


        public static void ImprimirDisponiblesVertical()
        {
            string disponiblesVertical = "";
            for (int f = 0; f < mat.GetLength(0); f++)
            {

                for (int c = 0; c < mat.GetLength(1); c++)
                {

                    if ((f + 1) < mat.GetLength(0))
                    {
                        int valor = mat[f, c];


                        int valorSiguiente = mat[f + 1, c];

                        disponiblesVertical = valor + ";" + valorSiguiente.ToString();

                        if (!disponiblesVertical.Contains("0"))
                        {
                            lista.Add(disponiblesVertical);
                        }

                    }


                }





            }
            Listar();
        }
        public static void ImprimirDisponiblesHorinzontal()
        {

            int sumatoria = 0;
            string disponiblesPar = "";
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                disponiblesPar = "";
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    int valor = mat[f, c];
                    sumatoria = sumatoria + valor;


                    disponiblesPar = disponiblesPar + ";" + valor.ToString();

                }

                if (!disponiblesPar.Contains("0"))
                {
                    lista.Add(disponiblesPar);
                }



            }
            //Listar();
        }


        public static void Listar()
        {
            if (lista.Count > 0)
            {

                Console.Write("Asientos pares disponibles Horizontal  y Vertical" + " ");
                foreach (string valor in lista)
                {
                    Console.Write(valor + " ");
                }
            }
        }


    }
}
