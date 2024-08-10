using System;

public class Program
{
    public static void Main()
    {
        ContarTriangulos();
    }

    /// <summary>
    /// Calcula y cuenta los triángulos cuya área excede un valor límite dado
    /// </summary>
    public static void ContarTriangulos()
    {
        const double limiteArea = 10.0; 
        int cantidadTriangulos = 0;

        for (int i = 1; i <= 5; i++) 
        {
            Console.WriteLine($"Ingrese las dimensiones del triángulo {i}:");

            Console.Write("Base: ");
            if (!double.TryParse(Console.ReadLine(), out double baseTriangulo))
            {
                Console.WriteLine("Valor de base inválido");
                return;
            }

            Console.Write("Altura: ");
            if (!double.TryParse(Console.ReadLine(), out double alturaTriangulo))
            {
                Console.WriteLine("Valor de altura inválido");
                return;
            }

            double area = (baseTriangulo * alturaTriangulo) / 2;

            if (area > limiteArea)
            {
                cantidadTriangulos++;
            }
        }

        Console.WriteLine($"Cantidad de triángulos con área mayor que {limiteArea}: {cantidadTriangulos}");
    }
}
