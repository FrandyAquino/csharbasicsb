using System;

public class Program
{
    public static void Main()
    {
        SolicitarNumeros();
    }

    /// <summary>
    /// Solicita dos números al usuario y realiza operaciones según la comparación
    /// </summary>
    public static void SolicitarNumeros()
    {
        double num1, num2;

        Console.Write("Ingrese el primer número: ");
        if (!double.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("El número ingresado es invalido");
            return;
        }

        Console.Write("Ingrese el segundo número: ");
        if (!double.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("El número ingresado es invalido");
            return;
        }

        if (num1 > num2)
        {
            double suma = num1 + num2;
            double resta = num1 - num2;
            Console.WriteLine($"Suma: {suma}");
            Console.WriteLine($"Resta: {resta}");
        }
        else
        {
            if (num2 != 0)
            {
                double producto = num1 * num2;
                double cociente = num1 / num2;
                Console.WriteLine($"Producto: {producto}");
                Console.WriteLine($"Cociente: {cociente}");
            }
            else
            {
                Console.WriteLine("El segundo número no puede ser cero para calcular el cociente.");
            }
        }
    }
}
