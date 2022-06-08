using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrasesAlReves
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = "Bienvenido a Treda Solutions";

            string[] vec = frase.Split(' ');

            for (int i = 0; i < vec.GetLength(0); i++)
            {
                if (vec[i].Length>5) {
                    string FraseAux = vec[i];
                    string FraseDevuelta="";
                    for (int j = FraseAux.Length-1; j >=0; j--)
                    {
                        FraseDevuelta += FraseAux[j];
                    }

                    vec[i] = FraseDevuelta;
                }

            }

            //Imprimir Frase devuelta
            for (int i = 0; i < vec.GetLength(0); i++)
            {
                Console.Write(vec[i]+ " ");
            }

            Console.ReadKey();

        }
    }
}
