using System;

public class Program
{
    public static void Main()
    {
        ProcesarTriangulos();
    }

    /// <summary>
    /// Solicita la cantidad de triángulos a procesar, captura los valores de base y altura, 
    /// calcula el área de cada triángulo y muestra los resultados.
    /// </summary>
    public static void ProcesarTriangulos()
    {
        Console.Write("Ingrese la cantidad de triángulos a procesar: ");
        if (!int.TryParse(Console.ReadLine(), out int cantidadTriangulos) || cantidadTriangulos <= 0)
        {
            Console.WriteLine("Cantidad de triángulos inválida.");
            return;
        }

        int cantidadTriangulosConAreaMayorA12 = 0;

        for (int i = 0; i < cantidadTriangulos; i++)
        {
            Console.Write($"Ingrese la base del triángulo {i + 1}: ");
            if (!double.TryParse(Console.ReadLine(), out double baseTriangulo) || baseTriangulo <= 0)
            {
                Console.WriteLine("Valor de la base inválido.");
                i--;
                continue;
            }

            Console.Write($"Ingrese la altura del triángulo {i + 1}: ");
            if (!double.TryParse(Console.ReadLine(), out double alturaTriangulo) || alturaTriangulo <= 0)
            {
                Console.WriteLine("Valor de la altura inválido.");
                i--;
                continue;
            }

            double area = (baseTriangulo * alturaTriangulo) / 2;
            Console.WriteLine($"Triángulo {i + 1} - Base: {baseTriangulo}, Altura: {alturaTriangulo}, Área: {area}");

            if (area > 12)
            {
                cantidadTriangulosConAreaMayorA12++;
            }
        }

        Console.WriteLine($"\nCantidad de triángulos con un área superior a 12 unidades cuadradas: {cantidadTriangulosConAreaMayorA12}");
    }
}
