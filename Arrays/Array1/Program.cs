using System;

public class Program
{
    public static void Main()
    {
        InicializarYImprimirMatriz();
    }

    /// <summary>
    /// Crea una matriz de 20 elementos enteros, inicializa cada elemento con el índice multiplicado por 5 y los imprime en la consola
    /// </summary>
    /// 
    public static void InicializarYImprimirMatriz()
    {
        const int tamañoMatriz = 20;
        int[] matriz = new int[tamañoMatriz];

        for (int i = 0; i < tamañoMatriz; i++)
        {
            matriz[i] = i * 5;
        }

        Console.WriteLine("Elementos de la matriz:");
        for (int i = 0; i < tamañoMatriz; i++)
        {
            Console.WriteLine($"Elemento en índice {i}: {matriz[i]}");
        }
    }
}
