using System;

public class Program
{
    public static void Main()
    {
        CalcularPromedio();
    }

    /// <summary>
    /// Calcula el promedio de tres calificaciones y determina si el alumno ha aprobado
    /// </summary>
    public static void CalcularPromedio()
    {
        double calificacion1, calificacion2, calificacion3;

        Console.Write("Ingrese la primera calificación: ");
        if (!double.TryParse(Console.ReadLine(), out calificacion1))
        {
            Console.WriteLine("La calificación ingresada es inválida");
            return;
        }

        Console.Write("Ingrese la segunda calificación: ");
        if (!double.TryParse(Console.ReadLine(), out calificacion2))
        {
            Console.WriteLine("La calificación ingresada es inválida");
            return;
        }

        Console.Write("Ingrese la tercera calificación: ");
        if (!double.TryParse(Console.ReadLine(), out calificacion3))
        {
            Console.WriteLine("La calificación ingresada es inválida");
            return;
        }

        double promedio = (calificacion1 + calificacion2 + calificacion3) / 3;
        Console.WriteLine($"Promedio: {promedio:F2}");

        if (promedio >= 7)
        {
            Console.WriteLine("El alumno ha aprobado");
        }
    }
}
