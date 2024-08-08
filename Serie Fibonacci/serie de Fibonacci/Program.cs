// See https://aka.ms/new-console-template for more information
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("SERIE FIBONACCI");
            //Console.WriteLine("Indique el número de secuencias");
            //int secuencias = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(LetterChanges("hello * 3"));

            Console.WriteLine(FibonacciChecker(4));

            //Console.WriteLine("Secuencia completada" + "\n");
            //imprimirVec(vec);
            //Console.ReadKey();
        }

        public static string FibonacciChecker(int num)
        {
            string mensaje="";

            //Se asigna num para no calcular una secuencia infinita, para tener una referencia aproximada de hasta donde calcular
            int secuencias = num;

            int aux;
            int a = 0;
            int b = 1;
            int[] vec = new int[secuencias];

            for (int i = 0; i < secuencias; i++)
            {
                aux = a;
                a = b;
                b = aux + a;
                vec[i] = b;
                Console.WriteLine(b);
            }

            for (int j = 0; j < vec.Length; j++)
            {
                if (num == vec[j])
                {
                    mensaje = "yes";
                    break;
                }
                else {
                    mensaje = "no";
                
                }
            }
            return mensaje;
        }
        public static void imprimirVec(int [] vec) {

            Console.WriteLine("Imprimiendo vector" + "\n");
            for (int i = 0; i < vec.Length; i++)
            {
                Console.WriteLine(vec[i]);
            }
        }

        public static string LetterChanges(string str)
        {

            char[] cadena = str.ToCharArray();
            char[] nuevaCadena = new char[cadena.Length];


            for (int i = 0; i < cadena.Length; i++)
            {
                nuevaCadena[i] = cadena[i];
            }
            //perdón, faltó tiempito para completarlo
            return str;

        }

    }
}




