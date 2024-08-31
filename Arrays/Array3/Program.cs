using System;

public class Program
{
    public static void Main()
    {
        ProcesarNumeros();
    }

    /// <summary>
    /// Solicita al usuario ingresar una cantidad variable de números, determina el menor valor y verifica si hay valores duplicados
    /// </summary>
    public static void ProcesarNumeros()
    {
        List<int> numeros = new List<int>();
        HashSet<int> valoresVistos = new HashSet<int>();

        Console.Write("Ingrese la cantidad de números que desea ingresar: ");
        if (!int.TryParse(Console.ReadLine(), out int cantidad) || cantidad <= 0)
        {
            Console.WriteLine("Cantidad inválida");
            return;
        }

        Console.WriteLine("Ingrese los números:");

        for (int i = 0; i < cantidad; i++)
        {
            if (!int.TryParse(Console.ReadLine(), out int numero))
            {
                Console.WriteLine("Valor inválido");
                return;
            }
            numeros.Add(numero);
        }

        if (numeros.Count == 0)
        {
            Console.WriteLine("No se ingresaron números.");
            return;
        }

        // Encontrar el menor valor
        int menorValor = numeros[0];
        foreach (int numero in numeros)
        {
            if (numero < menorValor)
            {
                menorValor = numero;
            }
        }

        // Verificar si hay valores duplicados
        bool hayDuplicados = false;
        foreach (int numero in numeros)
        {
            if (!valoresVistos.Add(numero))
            {
                hayDuplicados = true;
                break;
            }
        }

        Console.WriteLine($"El menor valor es: {menorValor}");
        Console.WriteLine(hayDuplicados ? "Hay valores repetidos" : "No hay valores repetidos");
    }
}
