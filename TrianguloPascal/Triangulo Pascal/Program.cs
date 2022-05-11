// See https://aka.ms/new-console-template for more information

int pisos = 0;
int [] arreglo = new int[1];
Console.WriteLine("Ingreso el número de pisos");
pisos = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("");
Console.WriteLine("TRIÁNGULO DE PASCAL");
Console.WriteLine("");

//Ciclo para controlar cuantos pisos crear
for (int i = 1; i <= pisos; i++)
{

    //Vector para guardar la longitud y contenido de cada fila y luego imprimirla
    int [] pascal = new int[i];
    string [] vacios= new string [pisos];

    //Ciclo para crear cada fila en el vector
    for (int k = 0; k < i; k++)
    {
        //Permite dibujar los unos (1) al inicio y al final de cada piso o fila
        if (k == 0 || k == (i - 1))
        {
            //k = pisos;

            //for (int j = 0; j < vacios.Length; j++)
            //{
            //    vacios[j] = " ";
            //    Console.Write(vacios[j]);
            //}

            pascal[k] = 1;
            //Console.Write(pascal[k]);
        }
        else {
            //Suma la posicición actual de la fila con la posición anterior, del arreglo guardado antes
            pascal[k] = arreglo[k] + arreglo[k - 1];
        }
        Console.Write("["+pascal[k]+"]");
    }
    //Se guarda arreglo para poder sumar en el siguiente ciclo, las posiciones anteriores de la fila
    arreglo = pascal;

    Console.WriteLine("");
}
