using System;

public class Program
{
    public static void Main()
    {
        CalcularSumaYPromedio();
    }

    /// <summary>
    /// Sirve para calcular la suma y el promedio de cuatro números
    /// </summary>
    public static void CalcularSumaYPromedio()
    {
        int suma = 0;
        double promedio = 0.0;
        string linea = string.Empty;
        int numero;

        for (int i = 1; i <= 4; i++)
        {
            Console.WriteLine($"Ingrese el valor del num {i}:");
            linea = Console.ReadLine();

            if (!int.TryParse(linea, out numero))
            {
                Console.WriteLine("El número ingresado es inválido");
                return;
            }

            suma += numero;
        }

        promedio = suma / 4.0;

        Console.WriteLine($"La suma es: {suma}");
        Console.WriteLine($"El promedio es: {promedio:F2}");
    }
}
