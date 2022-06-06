using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas_Evalart
{
    class Program
    {

        
        static int[] myArray = new int[] { 3, 1, 4, 2, 8, 0 };
        static void Main(string[] args)
        {
            Tablero_yX();

            TableroMovimientos();

            EncontrarSumaenVector();

        }

        private static void EncontrarSumaenVector()
        {
            int num1 = 0;
            int num2 = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                num1 = myArray[i];

                for (int j = 0; j < myArray.Length; j++)
                {
                    if (j < myArray.Length - 1)
                    {
                        if (j > 0)
                        {
                            num2 = myArray[j + 1];
                            if (num1 + num2 == 10)
                            {
                                Console.Write($"El resultado sería {num1} {num2}");
                                j = myArray.Length;
                                i = myArray.Length;
                            }
                        }
                        else
                        {

                            num2 = myArray[j];
                            if (num1 + num2 == 10)
                            {
                                Console.Write($"El resultado{num1} {num2} sería");
                                Console.ReadKey();

                            }
                        }

                    }

                }


            }
        }

        private static void Tablero_yX()
        {

            string [,] mat = new string[3, 3];

            int i = 1;
            string carta = "";
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                Console.Write("\n");
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    //int valor = mat[f, c];

                    if (i % 2 == 0)
                    {
                        carta = "_";
                    }
                    else
                    {
                        carta = "X";
                    }

                    mat[f, c] = carta.ToString();
                    i++;
                    Console.Write(mat[f, c] + "  ");


                }
            }
            Console.ReadKey();
        }

        private static void TableroMovimientos()
        {
            int[] myArray2 = new int[] { 1, 2, -1, 1, 0, 1, 2,-1,-1,-2 };
            string[,] matriz = new string [4,4];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matriz[i, j] = "O";
                    Console.Write(matriz[i,j]);
                }
                Console.WriteLine();
            }

            int derecha = 1;
            int abajo = 2;
            int izquierda = -1;
            int arriba = -2;
            int posicionMatriz;
            int posicionesFinal1;
            int posicionesFinal2;

            for (int i = 0; i < myArray2.Length; i++)
            {
                int posisionArray1 = myArray[i];
                int posisionArray2 = myArray[i+1];

                for (int k = 0; k < matriz.GetLength(0); k++)
                {
                    for (int m = 0; m < 4; m++)
                    {
                        matriz[k, m] = "O";
                        Console.Write(matriz[k, m]);

                        if (posisionArray1 == derecha)
                        {
                            //posicionesFinal1 = matriz[k + 1, m];
                            //matriz[k+1,m]="X";
                        }

                        if (posisionArray1 == abajo)
                        {

                        }

                        if (posisionArray1 == izquierda)
                        {

                        }

                        if (posisionArray1 == arriba)
                        {

                        }
                    }
                    Console.WriteLine();
                }

            }



                Console.ReadKey();
        }

        public class uno {
            protected int abc = 100;
        }

        public class dos:uno
        {

            void micode() {
                uno obj_uno = new uno();
                dos obj_dos = new dos();

                //obj_uno.abc = 10;
                obj_dos.abc = 10;
            }


        }
    }
}
