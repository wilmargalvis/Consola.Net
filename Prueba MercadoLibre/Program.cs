// See https://aka.ms/new-console-template for more information


/*La diferencia de un par de elementos en el array a está definida como a[j] - a[i] donde i < j y a[i] < a[j]

Completa el método maximaDiferencia que recibirá un array a de enteros y calculará la máxima diferencia para ese array.
Si no se puede calcular la máxima diferencia (por ejemplo si a está en orden descendente) entonces retorna -1.

Ejemplo:
Dado el array [15, 3, 6, 10], las diferencias que se tienen son:
• 6-3-3
• 10-3-7
• 10-6-4

Por 10 tanto la máxima diferencia será: 7  */


Console.WriteLine(maximaDiferencia(new int[] { 15, 3, 6, 10 }));

static int maximaDiferencia(int[] arr)
{
    if (arr == null || arr.Length < 2)
        return -1;

    int minimo = arr[0];
    int maxDif = -1;

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > minimo)
        {
            int diferencia = arr[i] - minimo;

            if (diferencia > maxDif)
                maxDif = diferencia;
        }

        if (arr[i] < minimo)
            minimo = arr[i];
    }

    return maxDif;
}
