using System;

public class Program
{
    public static void Main()
    {
        CompararMatrices();
    }

    public static void CompararMatrices()
    {
        Console.Write("Ingrese el tamaño de la primera matriz: ");
        if (!int.TryParse(Console.ReadLine(), out int tamañoMatriz1) || tamañoMatriz1 <= 0)
        {
            Console.WriteLine("Tamaño inválido");
            return;
        }
        int[] matriz1 = new int[tamañoMatriz1];
        Console.WriteLine("Ingrese los elementos de la primera matriz:");
        for (int i = 0; i < tamañoMatriz1; i++)
        {
            if (!int.TryParse(Console.ReadLine(), out matriz1[i]))
            {
                Console.WriteLine("Valor inválido");
                return;
            }
        }

        Console.Write("Ingrese el tamaño de la segunda matriz: ");
        if (!int.TryParse(Console.ReadLine(), out int tamañoMatriz2) || tamañoMatriz2 <= 0)
        {
            Console.WriteLine("Tamaño inválido");
            return;
        }
        int[] matriz2 = new int[tamañoMatriz2];
        Console.WriteLine("Ingrese los elementos de la segunda matriz:");
        for (int i = 0; i < tamañoMatriz2; i++)
        {
            if (!int.TryParse(Console.ReadLine(), out matriz2[i]))
            {
                Console.WriteLine("Valor inválido");
                return;
            }
        }

        if (tamañoMatriz1 != tamañoMatriz2)
        {
            Console.WriteLine("Las matrices no son iguales");
            return;
        }

        bool sonIguales = true;
        for (int i = 0; i < tamañoMatriz1; i++)
        {
            if (matriz1[i] != matriz2[i])
            {
                sonIguales = false;
                break;
            }
        }

        Console.WriteLine(sonIguales ? "Las matrices son iguales" : "Las matrices no son iguales");
    }
}
