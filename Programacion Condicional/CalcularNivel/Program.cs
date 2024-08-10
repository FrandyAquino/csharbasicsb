using System;

public class Program
{
    public static void Main()
    {
        CalcularNivel();
    }

    /// <summary>
    /// Calcula el nivel del postulante basado en el porcentaje de respuestas correctas
    /// </summary>
    public static void CalcularNivel()
    {
        int totalPreguntas, respuestasCorrectas;

        Console.Write("Ingrese el número total de preguntas: ");
        if (!int.TryParse(Console.ReadLine(), out totalPreguntas) || totalPreguntas <= 0)
        {
            Console.WriteLine("El número total de preguntas debe ser mayor que cero.");
            return;
        }

        Console.Write("Ingrese el número de respuestas correctas: ");
        if (!int.TryParse(Console.ReadLine(), out respuestasCorrectas) || respuestasCorrectas < 0)
        {
            Console.WriteLine("El número de respuestas correctas no puede ser negativo.");
            return;
        }

        double porcentaje = (double)respuestasCorrectas / totalPreguntas * 100;

        if (porcentaje >= 90)
        {
            Console.WriteLine("Nivel máximo");
        }
        else if (porcentaje >= 75)
        {
            Console.WriteLine("Nivel medio");
        }
        else if (porcentaje >= 50)
        {
            Console.WriteLine("Nivel regular");
        }
        else
        {
            Console.WriteLine("Fuera de nivel");
        }
    }
}
