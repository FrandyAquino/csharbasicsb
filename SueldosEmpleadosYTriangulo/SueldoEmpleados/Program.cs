using System;

public class Program
{
    public static void Main()
    {
        ProcesarSueldos();
    }

    /// <summary>
    /// Procesa los sueldos de los empleados y muestra los resultados según los rangos especificados.
    /// </summary>
    public static void ProcesarSueldos()
    {
        Console.Write("Ingrese el número de empleados: ");
        if (!int.TryParse(Console.ReadLine(), out int numEmpleados) || numEmpleados <= 0)
        {
            Console.WriteLine("Número de empleados inválido.");
            return;
        }

        int empleadosEntre100y300 = 0;
        int empleadosMasDe300 = 0;
        double totalSueldos = 0;

        for (int i = 0; i < numEmpleados; i++)
        {
            Console.Write($"Ingrese el sueldo del empleado {i + 1}: ");
            if (double.TryParse(Console.ReadLine(), out double sueldo))
            {
                if (sueldo >= 100 && sueldo <= 500)
                {
                    totalSueldos += sueldo;

                    if (sueldo >= 100 && sueldo <= 300)
                    {
                        empleadosEntre100y300++;
                    }
                    else if (sueldo > 300)
                    {
                        empleadosMasDe300++;
                    }
                }
                else
                {
                    Console.WriteLine("El sueldo ingresado está fuera del rango permitido ($100 - $500).");
                    i--;
                }
            }
            else
            {
                Console.WriteLine("Sueldo inválido.");
                i--;
            }
        }

        Console.WriteLine($"\nEmpleados que cobran entre $100 y $300: {empleadosEntre100y300}");
        Console.WriteLine($"Empleados que cobran más de $300: {empleadosMasDe300}");
        Console.WriteLine($"Total gastado en sueldos: ${totalSueldos}");
    }
}
