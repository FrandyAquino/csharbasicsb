using System;

public class Punto
{
    private double x;
    private double y;

    /// <summary>
    /// Carga las coordenadas x e y e imprime en qué cuadrante está el punto.
    /// </summary>
    public void DeterminarCuadrante()
    {
        // Cargar coordenadas
        Console.Write("Ingrese el valor de x: ");
        x = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el valor de y: ");
        y = double.Parse(Console.ReadLine());

        // Determinar y mostrar en qué cuadrante se encuentra el punto
        if (x > 0 && y > 0)
        {
            Console.WriteLine("El punto está en el primer cuadrante.");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("El punto está en el segundo cuadrante.");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("El punto está en el tercer cuadrante.");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("El punto está en el cuarto cuadrante.");
        }
        else if (x == 0 && y != 0)
        {
            Console.WriteLine("El punto está sobre el eje Y.");
        }
        else if (x != 0 && y == 0)
        {
            Console.WriteLine("El punto está sobre el eje X.");
        }
        else
        {
            Console.WriteLine("El punto está en el origen.");
        }
    }
}

public class Program
{
    public static void Main()
    {
        Punto punto = new Punto();
        punto.DeterminarCuadrante();
    }
}
