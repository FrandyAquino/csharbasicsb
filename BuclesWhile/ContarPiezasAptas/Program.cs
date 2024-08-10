using System;

public class Program
{
    public static void Main()
    {
        ContarPiezasAptas();
    }

    /// <summary>
    /// Cuenta cuántas piezas de hierro están dentro de un rango específico de longitud
    /// </summary>
    public static void ContarPiezasAptas()
    {
        int cantidadAptas = 0;
        const double longitudMinima = 5.0; // Longitud mínima aceptable
        const double longitudMaxima = 10.0; // Longitud máxima aceptable

        Console.WriteLine("Ingrese las longitudes de las piezas de hierro. Ingrese un valor negativo para terminar.");

        while (true)
        {
            Console.Write("Ingrese la longitud de la pieza: ");
            if (!double.TryParse(Console.ReadLine(), out double longitud) || longitud < 0)
            {
                break; // Salir del bucle si el usuario ingresa un valor negativo
            }

            if (longitud >= longitudMinima && longitud <= longitudMaxima)
            {
                cantidadAptas++;
            }
        }

        Console.WriteLine($"Cantidad de piezas aptas para fabricar perfiles: {cantidadAptas}");
    }
}
