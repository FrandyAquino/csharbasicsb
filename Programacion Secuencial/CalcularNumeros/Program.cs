using System;

public class Program
{
    public static void Main()
    {
        Calcular();
    }

    /// <summary>
    /// Sirve para calcular numeros, digase Suma y Resta
    /// </summary>

    public static void Calcular()
    {
        int num1 = 0;
        int num2 = 0;
        int suma = 0;
        int producto = 0;
        string linea = string.Empty;

        Console.WriteLine("Ingrese el valor de num1");
        linea = Console.ReadLine();

        if (!int.TryParse(linea, out num1))
        {
            Console.WriteLine("El numero num1 es invalido");
            return;
        }

        Console.WriteLine("Ingrese el valor de num2");
        linea = Console.ReadLine();

        if (!int.TryParse(linea, out num2))
        {
            Console.WriteLine("El numero num2 es invalido");
            return;
        }

        suma = (num1 + num2);
        producto = (num1 * num2);

        Console.WriteLine($"La suma es: {suma}");
        Console.WriteLine($"El producto es: {producto}");
    }
}
