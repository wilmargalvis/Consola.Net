using System;
using System.Diagnostics.Metrics;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

class Program
{
    static void Main(string[] args)
    {
        //EJERCICIOS CODERBYTE: https://www.youtube.com/watch?v=Qb2al04UmcY&list=PL88xup0DHWoYPIu3kIM8NWseGr0o9r-OP&index=10

        /*Comprobador de Fibonacci
        Haga que la función FibonacciChecker(num) devuelva la cadena "yes" si el número dado es parte de la secuencia de Fibonacci.
        Esta secuencia se define por: Fn Fn-1 + Fn - 2, lo que significa que para encontrar Fn se suman los dos números anteriores.
        Los primeros dos números son 0 y 1, luego vienen 1, 2, 3, 5, etc.Si num no está en la secuencia de Fibonacci, devuelva la cadena "no".

        En matemática, la sucesión de Fibonacci se trata de una serie infinita de números naturales que empieza con un 0 y un 1
        y continúa añadiendo números que son la suma de los dos anteriores: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597

        Ejemplos
                Entrada: 34
        Salida: yes

        Entrada: 54
        Salida: no  */

        //3 maneras de construir el fibonaci
        //Console.WriteLine(FibonacciCheckerv1(int.Parse(Console.ReadLine())));
        //Console.WriteLine(FibonacciCheckerv2(int.Parse(Console.ReadLine())));
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
        //Console.WriteLine(CountingMinutes("9:20 am-9:10 am")); //1:00 pm-11:00 am:1320   12:30pm-12:20pm:1430   9:00 am-10:00 am:60  9:20 am-9:10 am:1430

        /*Haga que la función PalindromeCreator(str) tome el parámetro str que se pasa y determine si es posible crear una cadena palindrómica de una longitud mínima de 3 caracteres eliminando 1 o 2 caracteres.
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
            salida: k                */
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

        //int[] arr2 = { 3, 5, 5, 7,7, 7 }; // 3, 4, 1, 6, 10 
        //Console.WriteLine(SimpleMode(arr2)); // Debería imprimir -1


        /*Asientos para estudiantes: Estudiantes sentados
        Haga que la función SeatingStudents(arr) lea la matriz de números enteros almacenada en arr, que tendrá el siguiente formato: [K, r1, r2, r3, ...]
        donde K representa la cantidad de escritorios en un aula y el resto de los números enteros en la matriz estarán en orden y representarán los escritorios que ya están ocupados.
        Todos los escritorios se organizarán en 2 columnas, donde el escritorio n #1 está en la parte superior izquierda, el escritorio n #2 está en la parte superior derecha,
        el escritorio n #3 está debajo del n #1, el escritorio n #4 está debajo del n #2, etc.
        Su programa debe devolver la cantidad de formas en que 2 estudiantes pueden sentarse uno al lado del otro. Esto significa que 1 estudiante está a la izquierda
        y 1 estudiante a la derecha, o 1 estudiante está directamente encima o debajo del otro estudiante.

        Por ejemplo: si arr es[12, 2, 6, 7, 11] entonces esta aula se parece a la siguiente lista:
        1 2
        3 4
        5 6
        7 8
        9 10
        11 12

        Según la disposición anterior de los escritorios ocupados, hay un total de 6 formas de sentar a 2 nuevos estudiantes uno al lado del otro.Las combinaciones son:
        [1, 3], [3, 4], [3, 5], [8, 10], [9, 10], [10, 12].Por lo tanto, para esta entrada, su programa debe devolver 6.K variará de 2 a 24 y siempre será un número par.
        Después de K, la cantidad de escritorios ocupados en la matriz puede variar de 0 a K.

        Ejemplos
        Entrada: [6, 4]
        Salida: 4

        Entrada: [8, 1, 8]
        Salida: 6*/

        //int[] arr1 = { 12, 2, 6, 7, 11 };
        //Console.WriteLine(SeatingStudents(arr1));


        /*Cambios de letras

        Haga que la función LetterChanges(str) tome el parámetro str que se está pasando y lo modifique utilizando el siguiente algoritmo.
        Reemplace cada letra de la cadena con la letra que le sigue en el alfabeto(es decir, c se convierte en d, z se convierte en a).Luego,
        ponga en mayúsculas todas las vocales de esta nueva cadena(a, e, i, o, u) y, por último, devuelva esta cadena modificada.

        Ejemplos
        Entrada: "hello*3"
        Salida: Ifmmp * 3

        Entrada: "¡fun times!"
        Salida: gvO Ujnft! */

        //Console.WriteLine(LetterChanges("hello*3z")); //fun times!

        /*Ocho reinas

        Haga que la función EightQueens(strArr) lea strArr, que será una matriz que constará de las ubicaciones de ocho reinas en un tablero de ajedrez estándar de 8x8
        sin otras piezas en el tablero.La estructura de strArr será la siguiente: ["(x,y)", "(x,y)", ...] donde(x, y)
        representa la posición de la reina actual en el tablero de ajedrez(X y Y estarán en un rango de 1 a 8,
        donde 1,1 es la parte inferior izquierda del tablero de ajedrez y 8,8 es la parte superior derecha).
        Su programa debe determinar si todas las reinas están ubicadas de tal manera que ninguna de ellas se ataque entre sí.Si esto es cierto para la entrada dada,
        devuelva la cadena true; de ​​lo contrario, devuelva la primera reina en la lista que esté atacando a otra pieza en el mismo formato en el que se proporcionó.

        Por ejemplo: si strArr es["(2,1)", "(4,2)", "(6,3)", "(8,4)", "(3,5)", "(1,6)", "(7,7)", "(5,8)"], entonces su programa debería devolver la cadena como verdadera. */

        //string[] array = { "(2,1)", "(4,2)", "(6,3)", "(8,4)", "(3,5)", "(1,6)", "(7,7)", "(5,8)" }; //"(2,1)", "(4,2)", "(6,3)", "(8,4)", "(3,5)", "(1,6)", "(7,7)", "(5,8)" da true
        // "(2,1)", "(4,3)", "(6,3)", "(8,4)", "(3,4)", "(1,6)", "(7,7)", "(5,8)"     "(2,1)", "(5,3)", "(6,3)", "(8,4)", "(3,4)", "(1,8)", "(7,7)", "(5,8)" 
        //Console.WriteLine(FightQueens(array));


        /*Números de verificación

        Haga que la función CheckNums(num1, num2) tome ambos parámetros que se pasan y devuelva la cadena true si num2 es mayor que num1;
        de lo contrario, devuelva la cadena false.Si los valores de los parámetros son iguales entre sí, devuelva la cadena - 1.

        Ejemplos

        Entrada: 3 y num2 122
        Salida: true

        Entrada: 67 y num2 67
        Salida: -1*/

        //Console.WriteLine(CheckNums(67,65));


        /*Blackjack más alto
        Haga que la función BlackjackHighest(strArr) tome el parámetro strArr que se pasa, que será una matriz de números y letras que representan las cartas del blackjack.
        Los números de la matriz se escribirán.Por ejemplo, strArr puede ser['two', 'three', 'ace', 'king'].
        La lista completa de posibilidades para strArr es: two, three, four, five, six, seven, eight, nine, ten, jack, queen, king, ace.Su programa debe generar como salida "below", "above" o "blackjack",
        lo que significa si tiene blackjack(si los números suman 21) o no, y la carta más alta en su mano en relación con si tiene o no blackjack.
        Si la matriz contiene un ace, pero su mano superará los 21, debe contar el ace como un 1.Siempre debe intentar mantenerse por debajo de la marca 21.
        Por lo tanto, al usar la matriz mencionada anteriormente, la salida debe ser "below king".
        El ace se cuenta como un 1 en este ejemplo porque, si no lo fuera, estaría por encima de la marca 21.

        Otro ejemplo sería si strArr fuera['four", "ten", "king"], el resultado aquí debería ser above king.
        Si tienes un empate entre un diez y una carta con figura en tu mano, devuelve la carta con figura como la "highest card".
        Si tienes varias cartas con figura, el orden de importancia es jack, queen, king

        Ejemplos
        Entrada: ["four", "ace", "ten"]
        Salida: below ten

        Entrada: ["ace", "queen"]
        Salida: blackjack ace */

        //string[] strArr = { "ace", "queen" };
        //"ace", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "Jack", "queen", "king"
        //Console.WriteLine(BlackjackHighest(strArr));


        /*Conteo de letras por palabra

        Haga que la función LetterCount(str) tome el parámetro str que se pasa y devuelva la primera palabra con la mayor cantidad de letras repetidas.
        Por ejemplo: "Today, is the greatest day ever!" debería devolver greatest porque tiene la mayor cantidad de letras repetidas(2e y 2t)
        y viene antes de ever, que también tiene 2e.Si no hay palabras con letras repetidas, devuelva -1.Las palabras se separarán con espacios.

        Ejemplos
        Entrada: "hello apple pie"
        Salida: hello

        Entrada:"no words"
        Salida: -1  */

        //Console.WriteLine(LetterCount("no words"));


        /*Cifrado César

        Haga que la función CaesarCipher(str, num) tome el parámetro str y realice un desplazamiento de Caesar Cipher sobre él
        utilizando el parámetro num como el número de desplazamiento. Un Caesar Cipher funciona desplazando cada letra de la cadena N lugares en el alfabeto(en este caso, N será num).
        La puntuación, los espacios y las mayúsculas deben permanecer intactos. Por ejemplo, si la cadena es "Caesar Cipher" y num es 2, el resultado debe ser "Ecguct Ekrjgt".

        Ejemplos

        Entrada: "Hello" y num = 4
        Salida: Lipps

        Entrada: "abc" y num = 0
        Salida: abc  */

        //Console.WriteLine(CaesarCipher("abc", 0));

        /*Determinador de monedas
        Haga que la función CoinDeterminer(num) tome la entrada, que será un entero que va de 1 a 250, y devuelva una salida entera que especificará la menor cantidad de monedas,
        que cuando se sumen, igualen al entero de entrada.Las monedas se basan en un sistema como el siguiente:
        hay monedas que representan los números enteros 1, 5, 7, 9 y 11.Entonces, por ejemplo: si num es 16,
        entonces la salida debería ser 2 porque puede lograr el número 16 con las monedas 9 y 7.
        Si num es 25, entonces la salida debería ser 3 porque puede lograr 25 con 11, 9 y 5 monedas o con 9, 9 y 7 monedas.

        Ejemplos
        Entrada: 6
        Salida: 2

        Entrada: 16
        Salida: 2  */

        //Console.WriteLine(CoinDeterminer(16));


        /*La mayor parte del tiempo libre

        Haga que la función MostFreeTime(strArr) lea el parámetro strArr que se pasa, que representará un día completo y se llenará con eventos que abarcan desde
        el tiempo X hasta el tiempo Y en el día.El formato de cada evento será hh: mmAM / PM - hh:mmAM / PM.
        Por ejemplo, strArr puede ser["10:00AM-12:30PM", "02:00PM- 02:45PM", "09:10AM-09:50AM"],
        Su programa tendrá que generar la mayor cantidad de tiempo libre disponible entre el inicio de su primer evento y el final de su último evento en el formato:
        hh: mm.El evento de inicio debe ser el evento más temprano del día y el evento más reciente debe ser el evento más reciente del día.
        La salida para la entrada anterior sería, por lo tanto, 01:30(con el evento más temprano del día comenzando a las 09:10AM y el evento más reciente terminando a las 02:45PM).
        La entrada contendrá al menos 3 eventos y los eventos pueden estar fuera de orden.

        Ejemplos

        Entrada: ["12:15PM-2:00PM", "09:00AM-10:00AM", "10:30AM-12:00PM"]   Revisar porque arroja 00:15
        Salida: 00:30

        Entrada: ["12:15PM-2:00PM", "09:00AM-12:11PM", "02:02PM-04:00PM"]  Arroja el resultado correcto
        Salida: 00:04  */

        //string[] strArr = { "12:15PM-2:00PM", "09:00AM-12:11PM", "02:02PM-04:00PM" };
        //Console.WriteLine(MostFreeTime(new string[] { "12:15PM-2:00PM", "09:00AM-10:00AM", "10:30AM-12:00PM" }));


        /*Haga que la función StockPicker(arr) tome la matriz de números almacenada en arr que contendrá números enteros que representan la cantidad en dólares que vale una sola acción,
         * y devuelva la ganancia máxima que se podría haber obtenido comprando acciones el día y, y vendiéndolas el día y donde y > x.
         * Por ejemplo: si arr es[44, 30, 24, 32, 35, 30, 40, 38, 15], entonces su programa debería devolver 16 porque en el índice 2 la acción valía $24
         * y en el índice 6 la acción valía $40, por lo que si compró la acción a 24 y la vendió a 40, habría obtenido una ganancia de $16
         * , que es la ganancia máxima que podría haberse obtenido con esta lista de precios de acciones.

        Si no se hubiera podido obtener una ganancia con los precios de las acciones, el programa debería devolver - 1.Por ejemplo: arr es[10, 9, 8, 2],
        entonces el programa debería devolver -1.

        Ejemplos

        Entrada: [10,12,4,5,9]
        Salida: 5

        Entrada: [14,20,4,12,5,11]
        Producción: 8  */

        //int[] arr = { 14, 20, 4, 12, 5, 11 }; // Un ejemplo de array de precios
        //Console.WriteLine(StockPicker(arr));


        string[] arr = { "4", "1:1", "2:2", "1:2", "0:1" }; // "4", "3:1", "2:2", "1:2", "0:1"   "4", "1:1", "2:2", "1:2", "0:1"
        Console.WriteLine(GasStation(arr)); // Por verificar


    }


    static string GasStation(string[] strArr)
    {
        int stations = int.Parse(strArr[0]); // Parsear el primer elemento del array como número de estaciones

        for (int i = 0; i < stations; i++)
        {
            int gas = 0;

            for (int j = 0; j < stations; j++)
            {
                int index = (i + j) % stations + 1; // Calcular el índice de la estación de gasolina actual

                string[] data = strArr[index].Split(":"); // Dividir los valores de gas y distancia
                //int gasAtStation = int.Parse(data[0]);
                //int distanceToNext = int.Parse(data[1]);

                gas += int.Parse(data[0]) - int.Parse(data[1]); // Sumar el gas disponible menos la distancia a la siguiente estación

                // Si no hay suficiente gas para llegar a la siguiente estación, salir del bucle
                if (gas >= 0) break;
            }

            // Si hay suficiente gas para recorrer todo el camino, retornar el índice de inicio (ajustado por 1)
            if (gas >= 0)
            {
                string result = (i + 1).ToString();
                return result;
            }
        }

        // Si no es posible recorrer todo el camino, retornar "Impossible"
        return "impossible"; // En C#, preferimos retornar un valor que indique claramente el fracaso
    }


    public static int StockPicker(int[] arr)
    {
        int profit = -1; // Inicializar el máximo beneficio a -1

        int buyPrice = arr[0]; // Inicializar el precio de compra al primer elemento del array

        for (int i = 1; i < arr.Length; i++) // Recorrer el array comenzando desde el segundo elemento
        {
            if (arr[i] < buyPrice) // Si el elemento actual es menor que el precio de compra
            {
                buyPrice = arr[i]; // Actualizar el precio de compra
            }
            else if ((arr[i] - buyPrice) > profit) // Si vender la acción al precio actual generará un beneficio mayor
            {
                profit = arr[i] - buyPrice; // Actualizar el máximo beneficio
            }
        }

        return profit; // Devolver el máximo beneficio
    }

    // Función que determina el tiempo libre más largo entre una serie de eventos
    static string MostFreeTime(string[] strArr)
    {
        // Creamos un array vacío para almacenar los minutos de cada evento
        List<int[]> minArr = new List<int[]>();

        // Variable para mantener un registro del tiempo libre más largo
        int longest = 0;

        // Función para convertir una cadena de tiempo a minutos
        int timeCalc(string time)
        {
            int min = 0;
            // Añadimos 12 horas (720 minutos) para tiempos PM
            if (time.ToLower().Contains("pm"))
            {
                min += 720;
            }

            // Añadimos las horas convertidas a minutos
            if (!time.Split(':')[0].Equals("12"))
            {
                min += int.Parse(time.Split(':')[0]) * 60;
            }

            string timeString = time.Split(':')[1];
            int minutes=0;

            // Eliminamos "PM" de la cadena si está presente
            if (timeString.EndsWith("PM"))
            {
                minutes = int.Parse(timeString.Substring(0, timeString.Length - 2));
            }


            // Añadimos los minutos
            min += minutes; //int.Parse(time.Split(':')[1]);

            return min;
        }

        // Recorremos el array de eventos y convertimos cada tiempo a minutos
        foreach (string eventStr in strArr)
        {
            var timeParts = eventStr.Split('-');
            minArr.Add(new int[] { timeCalc(timeParts[0]), timeCalc(timeParts[1]) });
        }

        // Ordenamos el array de minutos en orden ascendente
        minArr.Sort((a, b) => a[0].CompareTo(b[0]));

        // Recorremos el array ordenado y encontramos el tiempo libre más largo
        for (int j = 0; j < minArr.Count - 1; j++)
        {
            if (longest < minArr[j + 1][0] - minArr[j][1])
            {
                longest = minArr[j + 1][0] - minArr[j][1];
            }
        }

        // Convertimos el tiempo libre más largo a horas y minutos
        int hours = 0;
        while (longest >= 60)
        {
            longest -= 60;
            hours++;
        }

        string result = "";
        if (hours.ToString().Length == 1)
        {
            result = "0" + hours;
        }
        else
        {
            result = hours.ToString();
        }

        if (longest.ToString().Length == 1)
        {
            result += ":0" + longest;
        }
        else
        {
            result += ":" + longest;
        }

        return result;
    }


    // Función que determina la cantidad mínima de monedas necesarias para representar un número dado
    static int CoinDeterminer(int num)
    {
        int count = 0; // Inicializamos el contador a 0

        // Restamos 11 de num tantas veces como sea posible
        while (num > 10)
        {
            if (num % 11 > 1 && num % 11 < 5)
            {
                num -= 9; // Si el residuo de num dividido por 11 está entre 2 y 4, restamos 9 en lugar de 11
                count++; // Incrementamos el contador en 1
            }
            else
            {
                num -= 11; // Restamos 11
                count++; // Incrementamos el contador en 1
            }
        }

        // Restamos 9 de num tantas veces como sea posible
        while (num > 8)
        {
            if (num % 9 > 1 && num % 9 < 5)
            {
                num -= 7; // Si el residuo de num dividido por 9 está entre 2 y 4, restamos 7 en lugar de 9
                count++; // Incrementamos el contador en 1
            }
            else
            {
                num -= 9; // Restamos 9
                count++; // Incrementamos el contador en 1
            }
        }

        // Restamos 7 de num tantas veces como sea posible
        while (num > 6)
        {
            num -= 7; // Restamos 7
            count++; // Incrementamos el contador en 1
        }

        // Restamos 5 de num tantas veces como sea posible
        while (num > 4)
        {
            num -= 5; // Restamos 5
            count++; // Incrementamos el contador en 1
        }

        // Restamos 1 de num tantas veces como sea posible
        while (num > 0)
        {
            num -= 1; // Restamos 1
            count++; // Incrementamos el contador en 1
        }

        return count; // Devolvemos el contador
    }


    // Función de cifrado César que toma una cadena y un número como parámetros
    static string CaesarCipher(string str, int num)
    {
        StringBuilder sb = new StringBuilder(); // Usamos StringBuilder para construir la nueva cadena de manera eficiente

        foreach (char c in str) // Iteramos sobre cada carácter de la cadena
        {
            int ascii = Convert.ToInt32(c); // Convertimos el carácter a su código ASCII

            // Verificamos si el carácter es una letra
            if ((ascii > 64 && ascii < 91) || (ascii > 96 && ascii < 123))
            {
                ascii += num; // Sumamos el número de desplazamiento al código ASCII

                // Verificamos si el código ASCII está fuera del rango de las letras
                if ((ascii > 90 && ascii < 97) || ascii > 122)
                {
                    // Si es así, envolvemos alrededor de los alfabetos restando 26
                    ascii -= 26;
                }
            }

            sb.Append((char)ascii); // Convertimos el código ASCII de vuelta a su forma de carácter y lo agregamos al StringBuilder
        }

        return sb.ToString(); // Devolvemos la cadena cifrada
    }


    // Función que encuentra la palabra con la mayor cantidad de letras repetidas consecutivas
    static string LetterCount(string str)
    {
        string[] totalPalabras = str.Split(' '); // Divide la cadena en palabras
        string palabraMasRep = ""; // Palabra con la mayor cantidad de letras repetidas
        int maxCount = 1; // Mayor cantidad de letras repetidas encontradas

        foreach (var palabra in totalPalabras)
        {
            Dictionary<char, int> counts = new Dictionary<char, int>(); // Diccionario para contar ocurrencias de cada letra
            int count = 1; // Contador para la cantidad de letras repetidas en la palabra actual

            for (int j = 1; j < palabra.Length; j++)
            {
                if (palabra[j] == palabra[j - 1]) // Comprueba si la letra actual es igual a la anterior
                {
                    count++; // Incrementa el contador si la letra es repetida
                }
                else
                {
                    count = 1; // Reinicia el contador si la letra cambia
                }

                if (count > maxCount) // Actualiza la palabra y el conteo máximos si se encuentra una secuencia más larga
                {
                    maxCount = count;
                    palabraMasRep = palabra;
                }
            }
        }

        return palabraMasRep != "" ? palabraMasRep : "-1"; // Retorna la palabra con la mayor secuencia de letras repetidas, o "-1" si no se encuentra ninguna
    }

    // Función que calcula el puntaje más alto posible sin exceder 21 en un juego de Blackjack
    static string BlackjackHighest(string[] strArr)
    {
        int masAlto = -1;
        string cartaAlta = "";
        int total = 0;
        bool aceEncontrado = false;
        List<string> tarjetas = new List<string> { "ace", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "Jack", "queen", "king" };
        List<int> valores = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10 };

        for (int i = 0; i < strArr.Length; i++)
        {
            for (int j = 0; j < tarjetas.Count; j++)
            {
                if (strArr[i] == tarjetas[j])
                {
                    total += valores[j];
                    if (j > masAlto)
                    {
                        masAlto = j;
                        cartaAlta = tarjetas[j];
                    }
                    if (j == 0) aceEncontrado = true;
                }
            }
        }

        if (aceEncontrado && total <= 11)
        {
            total += 10;
            masAlto = 11;
            cartaAlta = "ace";
        }

        if (total < 21) return $"below {cartaAlta}";
        if (total > 21) return $"above {cartaAlta}";
        if (total == 21) return $"blackjack {cartaAlta}";

        return string.Join(", ", strArr); // Retorna la entrada si no se cumple ninguna condición anterior
    }

    static string CheckNums(int num1, int num2)
    {
        if (num2 > num1)
        {
            return "true";
        }
        else if (num2 == num1)
        {
            return "-1";
        }
        return "false";
    }


    // Función que verifica si alguna de las reinas se ataca mutuamente
    static string FightQueens(string[] strArr)
    {
        // Convertir la entrada de cadena a una lista de coordenadas
        List<(int X, int Y)> reinas = strArr.Select(coordenada =>
        {
            int x = int.Parse(coordenada.Substring(1, coordenada.IndexOf(',') - 1));
            int y = int.Parse(coordenada.Substring(coordenada.IndexOf(',') + 1, coordenada.Length - coordenada.IndexOf(',') - 2));
            return (X: x, Y: y);
        }).ToList();

        // Verificar si alguna reina se ataca mutuamente
        for (int i = 0; i < reinas.Count; i++)
        {
            for (int j = i + 1; j < reinas.Count; j++)
            {
                var q1 = reinas[i];
                var q2 = reinas[j];

                // Reinas se atacan si están en la misma fila, columna o diagonal
                if (q1.X == q2.X || q1.Y == q2.Y || Math.Abs(q1.X - q2.X) == Math.Abs(q1.Y - q2.Y))
                {
                    // Las reinas se atacan, retornar la ubicación de la primera reina
                    return $"({q1.X},{q1.Y})";
                }
            }
        }

        // Si todas las reinas son válidas, retornar verdadero
        return "true";
    }


    // Función que cambia cada letra en la cadena a la siguiente en el alfabeto,
    // convirtiendo las vocales resultantes a mayúsculas.
    static string LetterChanges(string str)
    {
        char[] Array = str.ToCharArray(); // Convertir la cadena en un array de caracteres

        for (int i = 0; i < Array.Length; i++)
        {
            // Comprobar si el carácter es una letra minúscula
            if (Regex.IsMatch(Array[i].ToString(), "[a-z]"))
            {
                // Manejar el caso especial de 'z' a 'a'
                if (Array[i] == 'z')
                {
                    Array[i] = 'A'; // Convertir 'z' en 'A' directamente
                    continue;
                }

                // Cambiar la letra al siguiente en el alfabeto
                Array[i] = (char)(Array[i] + 1);

                // Convertir las vocales resultantes a mayúsculas
                if ("aeiou".Contains(Array[i]))
                {
                    Array[i] = Char.ToUpper(Array[i]);
                }
            }
        }

        return new string(Array); // Convertir el array de caracteres de nuevo a cadena
    }

    // Función que calcula cuántos estudiantes adicionales pueden sentarse
    public static int SeatingStudents(int[] arr)
    {
        int k = arr[0]; // Número total de asientos
        HashSet<int> ocupados = new HashSet<int>(arr.Skip(1)); // Asientos ya ocupados

        int count = 0;
        for (int i = 1; i <= k; i++)
        {
            if (!ocupados.Contains(i))
            {
                // Verificar a la derecha
                if (i % 2 == 1 && !ocupados.Contains(i + 1) && i + 1 <= k)
                {
                    count++;
                }
                // Verificar abajo
                if (i < k - 1 && !ocupados.Contains(i + 2))
                {
                    count++;
                }
            }
        }
        return count;
    }

    public static int SimpleMode(int[] arr)
    {
        if (arr.Length == 0) throw new ArgumentException("La matriz no puede estar vacía.");

        Dictionary<int, int> frecuenciaxNumero = new Dictionary<int, int>();
        foreach (int num in arr)
        {
            if (frecuenciaxNumero.ContainsKey(num))
            {
                frecuenciaxNumero[num]++;
            }
            else
            {
                frecuenciaxNumero[num] = 1;
            }
        }

        int maximaRepeticion = 0;
        int numero = -1;
        foreach (KeyValuePair<int, int> entry in frecuenciaxNumero)
        {
            if (entry.Value > maximaRepeticion)
            {
                maximaRepeticion = entry.Value;
                numero = entry.Key;
            }
            else if (entry.Value > maximaRepeticion)
            {
                numero = entry.Key; // Se asegura de elegir el primer número en caso de empate
            }
        }

        if (maximaRepeticion == 1)
        {
            numero = -1;
        }

        return numero;
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
    // Función que calcula la diferencia de minutos entre dos tiempos dados
    static int CountingMinutes(string str)
    {
        // Dividir los tiempos de inicio y fin de la entrada
        string[] horasDadas = str.Split('-');

        // Convertir los tiempos de inicio y fin a minutos desde medianoche
        int totalMinutosInicio = minutosDesdeMediaNoche(horasDadas[0]);
        int totalMinutosFin = minutosDesdeMediaNoche(horasDadas[1]);

        // Calcular la diferencia de tiempo, asegurándose de que sea un valor positivo
        int diferencia = (totalMinutosFin - totalMinutosInicio + 1440) % 1440;

        // Devolver la diferencia de tiempo en minutos
        return diferencia;
    }

    // Función auxiliar que convierte una hora dada en formato de cadena a minutos desde medianoche
    static int minutosDesdeMediaNoche(string horaTexto)
    {
        // Dividir las horas y minutos de la cadena de tiempo
        string[] partesHora = horaTexto.Substring(0, horaTexto.Length - 2).Split(":");

        // Convertir las horas y minutos a enteros
        int hora = int.Parse(partesHora[0]);
        int minuto = int.Parse(partesHora[1]);

        // Determinar si el tiempo está en la PM (posterior al mediodía)
        bool isPM = horaTexto.Substring(horaTexto.Length - 2) == "pm";

        // Convertir el tiempo a minutos desde medianoche
        int totalMinutos = hora * 60 + minuto;
        return isPM ? totalMinutos + 720 : totalMinutos; // Si es PM, se suma 720 minutos para convertirlo a tiempo de la tarde
    }

    static int BinaryConverter(string textoBinario)
    {
        int valorDecimal = 0;
        int exponente = 0;

        // Itera sobre cada carácter de la cadena, comenzando desde el final
        for (int i = textoBinario.Length - 1; i >= 0; i--)
        {
            // Obtiene el valor del dígito actual (0 o 1)
            int digit = textoBinario[i] - '0'; // Resta '0' para convertir char a int

            // Se saca el valor posicional de cada digito binario. Para esto se eleva cada dígito a la potencia de 2
            double aux = Math.Pow(2, exponente);

            //Guarda la suma de cada dígito binario por cada potencia dada. Los binarios cero(0) no suman.
            valorDecimal += Convert.ToInt16(digit * aux);

            // Incrementa el exponent para el siguiente dígito
            exponente++;
        }

        //Se puede utilizar el método Convert.ToInt32(string, int) de la clase System.Convert
        //return Convert.ToInt32(binaryString, 2);

        return valorDecimal;
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

    //Mejor versión
    static string FibonacciChecker(int num)
    {
        // Inicializamos la secuencia de Fibonacci con los primeros dos números
        long NumFibonaci = 0;
        long NumFibonaciSig = 1;
        bool encontrado = false;

        while (true)
        {
            // Sumamos los dos últimos números para obtener el próximo y guardamos el resultado en temp
            long temp = NumFibonaci;
            NumFibonaci += NumFibonaciSig;

            // Verificamos si hemos alcanzado o superado el número dado
            if (NumFibonaci >= num)
            {
                break;
            }

            // Actualizamos NumFibonaciSig con el valor de NumFibonaci que ya tiene el valor del nuevo número, para la siguiente iteración
            NumFibonaciSig = temp;
        }

        // Comprobamos si el número dado es igual al último número generado
        if (NumFibonaci == num)
        {
            encontrado = true;
        }

        return encontrado ? "yes" : "no";
    }

    public static string FibonacciCheckerv1(int num)
    {

        string mensaje = "";
        //Se asigna num para no calcular una secuencia infinita, para tener una referencia aproximada de hasta donde calcular, sin embargo, esto puede pro

        int aux;
        int a = 0;
        int b = 1;
        //int[] vec = new int[num];//Para este ejercicio NO es necesario. Utilizando un List no requiero indicarle las items
        //vec[0] = 0; //Para este ejercicio NO es necesario. Se incluye en el vector porque el cero(0) hace parte de la cerie fibonaci, lo agrego de primeras.
                    //Aunque si el siclo lo inicio en cero, se me reemplazará por el primer número(1).

        for (int i = 0; i < num; i++)
        {
            aux = a;
            a = b;
            b = aux + a;
            //vec[i] = b; //Opcional para el ejercicio
            if (b >= num) { break; } //Para salirse cuando encuentre el num en el fibonaci y no recorrer más iteracciones innecesarias
            //Console.WriteLine(b);
        }

        if (b == num) { return "yes"; }

        //Una manera de ver si en los números fibonaci guardados está el número ingresado
        //for (int j = 0; j < vec.Length; j++)
        //{
        //    if (num == vec[j])
        //    {
        //        mensaje = "yes";
        //        break;
        //    }
        //    else
        //    {
        //        mensaje = "no";
        //    }
        //}

        return "no";
    }

    public static string FibonacciCheckerv2(int num)
    {
        // Inicializamos una lista con el primer valor de la secuencia de Fibonacci
        List<int> prev = new List<int> { 0 };

        // Recorremos cada número en la secuencia hasta e incluyendo el número de entrada
        for (int i = 1; i <= num; i++)
        {
            // Calculamos el siguiente número en la secuencia sumando los dos anteriores
            int check = i + prev[0];

            // Si el número calculado es igual al número de entrada, retornamos "yes"
            if (check == num)
            {
                return "yes";
            }

            // Agregamos el número actual al inicio de la lista para llevar un registro del anterior
            prev.Insert(0, i);

            // Actualizamos el número actual para ser el siguiente número en la secuencia
            i = check;
        }

        // Si el número de entrada no está en la secuencia de Fibonacci, retornamos "no"
        return "no";
    }
}


