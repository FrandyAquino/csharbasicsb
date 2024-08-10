using System;

public class Program
{
    public static void Main()
    {
        SumarUltimosCinco();
    }

    /// <summary>
    /// Permite ingresar 10 números y muestra la suma de los últimos 5 números ingresados
    /// </summary>
    public static void SumarUltimosCinco()
    {
        int[] numeros = new int[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Ingrese el número {i + 1}: ");
            if (!int.TryParse(Console.ReadLine(), out numeros[i]))
            {
                Console.WriteLine("Número inválido");
                return;
            }
        }

        int sumaUltimosCinco = 0;
        for (int i = 5; i < 10; i++)
        {
            sumaUltimosCinco += numeros[i];
        }

        Console.WriteLine($"La suma de los últimos 5 números ingresados es: {sumaUltimosCinco}");
    }
}
