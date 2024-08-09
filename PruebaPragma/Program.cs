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
        //int numDecimal = BinaryConverter("100101");

        /*Haga que la función CountingMinutes(str) tome el parámetro str que se pasa, que será dos horas (cada una con el formato correcto con dos puntos am o pm)
         * separadas por un guion y devuelva el número total de minutos entre las dos horas. La hora estará en un formato de reloj de 12 horas.
         * Por ejemplo: si str es 9:00 am-10:00 am, entonces la salida debe ser 60. Si str es 1:00 pm-11:00 am, debe ser 1320 */
        //CountingMinutes("10:30 pm-9:20 pm"); //1:23 am-1:08 am    9:20 am-9:10 am

        /*Haga que la función PalidromeCreator(str) tome el parámetro str que se pasa y determine si es posible crear una cadena palindrómica de una longitud mínima de 3 caracteres eliminando 1 o 2 caracteres.
         * Por ejemplo: si str es "abjchba", puede eliminar los caracteres jc para producir "abhba", que es un palíndromo.
         * Para este ejemplo, su programa debe devolver los dos caracteres que se eliminaron sin delimitador y en el orden en que aparecen en la cadena,
         * es decir, jc. Si no se pueden eliminar 1 o 2 caracteres para producir un palíndromo, entonces no es posible devolver la cadena.
           Si la cadena de entrada ya es un palíndromo, su programa debe devolver la cadena 'palíndromo'. Su programa siempre debe eliminar los caracteres que aparecen antes en la cadena.
           En el ejemplo anterior, también puede eliminar ch para formar un palíndromo, pero jc aparece primero, por lo que la respuesta correcta es jc.

           La entrada solo contendrá caracteres alfabéticos en minúscula. Su programa siempre debe intentar crear la subcadena palindrómica más larga eliminando 1 o 2 caracteres
           (consulte el segundo caso de prueba de muestra como ejemplo). Los 2 caracteres que elimine no tienen que ser adyacentes en la cadena.       
        Ejemplo:
            entrada: "mmop"
            salida: no es posible

            entrada: "kjjjhjjj"
            salida: k
        * Quedó pendiente evaluar más el ejercicio de Palindrome Creator*/
        //Console.WriteLine(PalindromeCreator("abhba")); // Debería imprimir "jc"
        //Console.WriteLine(PalindromeCreator("kjjjhjjj")); // Debería imprimir "k"
        //Console.WriteLine(PalindromeCreator("mmop")); // Debería imprimir "no es posible"

        //Hallar Factorial
        //Console.WriteLine(Factorial(4)); // 1*2*3*4: 24

        //Haga que la función ArrayAddition (arr) tome la matriz de números almacenada en arr y devuelva la cadena true si cualquier combinación de números en la matriz
        //(excluyendo el número más grande) se puede sumar para igualar o superar el número más grande en la matriz, de lo contrario devuelva la cadena false.
        //Por ejemplo: si arr contiene (4, 6, 23, 10, 1, 3] la salida debe devolver true porque 4 + 6 + 10 + 3 = 23.
        //La matriz no estará vacía, no contendrá todos los mismos elementos y puede contener números negativos.
        //int[] arr = { 4, 6, 23, 10, 1, 3 };
        //Console.WriteLine(ArrayAddition(arr)); // Debería imprimir "True"

        //Haga que la función SimpleMode(arr) tome la matriz de números almacenada en arr y devuelva el número que aparece con mayor frecuencia (la moda).
        //Por ejemplo: si arr contiene [10, 4, 5, 2, 4], la salida debe ser 4.
        //Si hay más de una moda, devuelva la que apareció primero en la matriz (es decir, [5, 10, 10, 6, 5] debe devolver 5 porque apareció primero).
        //Si no hay moda, devuelva -1. La matriz no puede estar vacía.

        //Ejemplos
        //Entrada: [5,5,2,2,1]
        //Salida: 5
        //Entrada: [3,4,1,6,10]
        //Salida: -1

        //int[] arr1 = { 5, 5, 2, 2, 1 };
        //Console.WriteLine(SimpleMode(arr1)); // Debería imprimir 5

        int[] arr2 = { 3, 5, 5, 7,7, 7 }; // 3, 4, 1, 6, 10 
        Console.WriteLine(SimpleMode(arr2)); // Debería imprimir -1


    }

    public static int SimpleMode(int[] arr)
    {
        if (arr.Length == 0) throw new ArgumentException("La matriz no puede estar vacía.");

        Dictionary<int, int> frequencyCount = new Dictionary<int, int>();
        foreach (int num in arr)
        {
            if (frequencyCount.ContainsKey(num))
            {
                frequencyCount[num]++;
            }
            else
            {
                frequencyCount[num] = 1;
            }
        }

        int maxFrequency = 0;
        int mode = -1;
        foreach (KeyValuePair<int, int> entry in frequencyCount)
        {
            if (entry.Value > maxFrequency)
            {
                maxFrequency = entry.Value;
                mode = entry.Key;
            }
            else if (entry.Value > maxFrequency)
            {
                mode = entry.Key; // Se asegura de elegir el primer número en caso de empate
            }
        }

        if (maxFrequency == 1)
        {
            mode = -1;
        }

        return mode;
    }

    static string ArrayAddition(int[] arr)
    {
        // Paso 1: Ordenar la matriz
        Array.Sort(arr);

        // Paso 2: Eliminar el número más grande
        int maxNumber = arr[arr.Length - 1];
        int[] remainingNumbers = arr.Where(x => x != maxNumber).ToArray();

        // Paso 3: Sumar los números restantes
        int sumOfRemainingNumbers = remainingNumbers.Sum();

        // Verificar si la suma es igual o mayor que el número más grande
        if (sumOfRemainingNumbers >= maxNumber)
        {
            return "True";
        }
        else
        {
            return "False";
        }
    }

    static int Factorial(int num)
    {
        if ((num == 0) || (num == 1)) { return 1; } else 
        {
            int fact = num * Factorial(num - 1);
            return fact;
        }
    }

    static string PalindromeCreator(string str)
    {
        str = str.ToLower();
        int n = str.Length;

        // Caso base: si la cadena ya es un palíndromo o su longitud es menor que 3
        if (IsPalindrome(str) || n < 3)
        {
            return "palíndromo";
        }

        // Intenta eliminar uno o dos caracteres para crear un palíndromo
        for (int i = 0; i <= n - 3; i++)
        {
            // Elimina el carácter actual y verifica si la subcadena resultante es un palíndromo
            if (IsPalindrome(str.Remove(i, 1)))
            {
                return str.Substring(i, 1);
            }

            // Si no se puede crear un palíndromo eliminando solo un carácter,
            // intenta eliminar dos caracteres consecutivos
            if (i <= n - 4 && IsPalindrome(str.Remove(i, 2)))
            {
                return str.Substring(i, 2);
            }
        }

        // Si no se puede crear un palíndromo eliminando uno o dos caracteres
        return "no es posible";
    }

    static bool IsPalindrome(string str)
    {
        int n = str.Length;
        //Como un palíndromo se lee igual hacia adelante y hacia atrás, solo necesita verificar hasta el punto medio de la cadena.
        //Si encuentra una discrepancia antes de llegar al punto medio, puede concluir que la cadena no es un palíndromo sin necesidad de verificar el resto de los caracteres.
        for (int i = 0; i < n / 2; i++)
        {
            //En cada iteración del bucle, compara el carácter en la posición actual i con el carácter en la posición simétrica desde el final de la cadena (n - i - 1).
            //Si encuentra una pareja de caracteres que no son iguales, significa que la cadena no es un palíndromo y retorna false inmediatamente.
            if (str[i] != str[n - i - 1])
            {
                return false;
            }
        }
        return true;
    }

    static int CountingMinutes(string str)
    {
        //int totalMinutos = 0;
        //int Minutos = 0;
        //int MinHoras = 0;

        string [] vecHoras =  str.Split('-');

        // Divide la hora de inicio por hora, minuto, y am o pm
        var partesdeHoraIni = vecHoras[0].Split(new[] { ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int horaIni = Convert.ToUInt16(partesdeHoraIni[0]);
        int minutoIni = Convert.ToUInt16(partesdeHoraIni[1]);
        var amOpmIni = partesdeHoraIni[2].ToString();

        // Ajusta la hora inicial para AM/PM
        horaIni += amOpmIni.Equals("pm") && horaIni < 12 ? 12 : 0;

        // Divide la hora final por hora, minuto, y am o pm
        var partesdeHoraFin = vecHoras[1].Split(new[] { ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int horaFin = Convert.ToUInt16(partesdeHoraFin[0]);
        int minutoFin = Convert.ToUInt16(partesdeHoraFin[1]);
        var amOpmFin = partesdeHoraFin[2].ToString();

        //Ajusta la hora final para AM/ PM
        horaFin += amOpmFin.Equals("pm") && horaFin < 12 ? 12 : 0;

        int totalMinutos = ((horaFin - horaIni) * 60) + (minutoFin - minutoIni);


        //----------------------MEJORA A LA SOLUCIÓN PREVIA SOLUCIÓN---------


        //if (amOpmIni.Equals("pm") && amOpmFin.Equals("am"))
        //{
        //    if (horaIni == 12 && horaFin <= 12)
        //    {
        //        MinHoras = ((horaFin + horaIni) * 60);

        //        if (minutoIni > minutoFin)
        //        {
        //            Minutos = minutoIni - minutoFin;
        //            if (horaIni == 12) { totalMinutos = MinHoras - Minutos; }
        //        }

        //        if (minutoIni < minutoFin)
        //        {
        //            Minutos = minutoFin - minutoIni;
        //            totalMinutos = MinHoras + Minutos;
        //        }

        //        if (minutoIni == minutoFin) { totalMinutos = MinHoras; }
        //    }

        //    if (horaIni < 12 && horaFin < 12)
        //    {
        //        MinHoras = (((12 - horaIni) + horaFin) * 60);
        //        Minutos = minutoIni + minutoFin;
        //        totalMinutos = MinHoras + Minutos;
        //    }

        //    if (horaIni < 12 && horaFin == 12)
        //    {
        //        if (minutoIni > 0) { MinHoras = ((12 - (horaIni + 1)) * 60); } else { MinHoras = ((12 - horaIni) * 60); }

        //        Minutos = minutoIni + minutoFin;
        //        totalMinutos = MinHoras + Minutos;
        //    }
        //}

        //Falta el caso  if (amOpmIni.Equals("am") && amOpmFin.Equals("am"))

        return totalMinutos;
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


