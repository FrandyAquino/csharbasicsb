using System;

public class Program
{
    public static void Main()
    {
        ContarDivisibles();
    }

    /// <summary>
    /// Cuenta cuántos números en un conjunto de 10 son divisibles por 3 o por 5
    /// </summary>
    public static void ContarDivisibles()
    {
        int conteoDivisibles = 0;

        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"Ingrese el número {i}: ");
            if (!int.TryParse(Console.ReadLine(), out int numero))
            {
                Console.WriteLine("Número inválido");
                return;
            }

            if (numero % 3 == 0 || numero % 5 == 0)
            {
                conteoDivisibles++;
            }
        }

        Console.WriteLine($"Cantidad de números divisibles por 3 o por 5: {conteoDivisibles}");
    }
}
