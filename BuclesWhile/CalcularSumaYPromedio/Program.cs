using System;

public class Program
{
    public static void Main()
    {
        CalcularSumaYPromedio();
    }

    /// <summary>
    /// Calcula la suma y el promedio de una secuencia de 10 números enteros
    /// </summary>
    public static void CalcularSumaYPromedio()
    {
        int suma = 0;
        int contador = 0;

        while (contador < 10)
        {
            Console.Write($"Ingrese el número {contador + 1}: ");
            if (!int.TryParse(Console.ReadLine(), out int numero))
            {
                Console.WriteLine("Número inválido, por favor ingrese un número entero.");
                continue;
            }

            suma += numero;
            contador++;
        }

        double promedio = suma / 10.0;
        Console.WriteLine($"La suma de los números es: {suma}");
        Console.WriteLine($"El promedio de los números es: {promedio:F2}");
    }
}
