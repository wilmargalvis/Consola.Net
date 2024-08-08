using System;

class Program
{
    static void Main(string[] args)
    {
        //int a = int.Parse(Console.ReadLine());
        //Console.WriteLine(FibonacciChecker(int.Parse(Console.ReadLine())));

        /*haga que la función Consecutive(arr) tome la matriz de números enteros almacenados en arr y devuelva el número mínimo de números enteros necesarios
         * para hacer que el contenido de arr sea consecutivo desde el número más bajo hasta el número más alto. Por ejemplo: si arr contiene [4,8,6],
         * entonces la salida debe ser 2 porque se deben agregar dos números a la matriz (5 y 7) para convertirla en una matriz consecutiva de números del 4 al 8.
         * Se pueden ingresar números negativos como parámetro y ninguna matriz tendrá menos de 2 elementos.*/
        //consecutivo();

        /*Haga que la función BinaryConverter(str) devuelva la forma decimal del valor binario.
         * Por ejemplo: si se pasa 101, devuelva 5, o si se pasa 1000, devuelva 8.*/
        int numDecimal = BinaryConverter("100101");

        /*Haga que la función CountingMinutes(str) tome el parámetro str que se pasa, que será dos horas (cada una con el formato correcto con dos puntos am o pm)
         * separadas por un guion y devuelva el número total de minutos entre las dos horas. La hora estará en un formato de reloj de 12 horas.
         * Por ejemplo: si str es 9:00 am-10:00 am, entonces la salida debe ser 60. Si str es 1:00 pm-11:00 am, debe ser 13:20 */
        //CountingMinutes();

        /*Quedó pendiente el ejercicio de Palindrome Creator*/
    }

    static int CountingMinutes()
    {
        return 2;
    }

    static int BinaryConverter(string binaryString)
    {
        int decimalValue = 0;
        int exponent = 0;

        // Itera sobre cada carácter de la cadena, comenzando desde el final
        for (int i = binaryString.Length - 1; i >= 0; i--)
        {
            // Obtiene el valor del dígito actual (0 o 1)
            int digit = binaryString[i] - '0'; // Resta '0' para convertir char a int

            // Se saca el valor posicional de cada digito binario. Para esto se eleva cada dígito a la potencia de 2
            double aux = Math.Pow(2, exponent);

            //Guarda la suma de cada dígito binario por cada potencia dada. Los binarios cero(0) no suman.
            decimalValue += Convert.ToInt16(digit * aux);

            // Incrementa el exponent para el siguiente dígito
            exponent++;
        }

        //Se puede utilizar el método Convert.ToInt32(string, int) de la clase System.Convert
        //return Convert.ToInt32(binaryString, 2);

        return decimalValue;
    }

    public static int consecutivo()
    {
        int[] arr = new int[] {4,8,6 };
        int min = arr.Min();
        int max = arr.Max();

        int longitudTotal = max - min + 1;

        int elementosFaltantes = longitudTotal - arr.Length;

        return elementosFaltantes;
    }

    public static string FibonacciChecker(int num)
    {

        string mensaje = "";
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
              Console.WriteLine("YES");
                break;
            }
            else
            {
                mensaje = "no";
                Console.WriteLine("NO");
            }
        }

        return mensaje;
    }
}


