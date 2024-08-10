using System;

public class Program
{
    public static void Main()
    {
        CalcularTotal();
    }

    /// <summary>
    /// Sirve para calcular el total a pagar por un artículo según su precio y cantidad
    /// </summary>
    public static void CalcularTotal()
    {
        decimal precio = 0;
        int cantidad = 0;
        decimal total = 0;
        string linea = string.Empty;

        Console.WriteLine("Ingrese el precio del artículo:");
        linea = Console.ReadLine();

        if (!decimal.TryParse(linea, out precio) || precio < 0)
        {
            Console.WriteLine("El precio ingresado es inválido");
            return;
        }

        Console.WriteLine("Ingrese la cantidad que lleva el cliente:");
        linea = Console.ReadLine();

        if (!int.TryParse(linea, out cantidad) || cantidad < 0)
        {
            Console.WriteLine("La cantidad ingresada es inválida");
            return;
        }

        total = precio * cantidad;

        Console.WriteLine($"El total a pagar es: {total:C}");
    }
}
