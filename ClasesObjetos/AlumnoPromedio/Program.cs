using System;
using System.Collections.Generic;

public class Alumno
{
    // Propiedades del alumno
    public string Nombre { get; set; }
    public string Matricula { get; set; }
    public string Carrera { get; set; }
    public List<int> Calificaciones { get; set; }

    /// <summary>
    /// Calcula y devuelve el promedio de las calificaciones del alumno.
    /// </summary>
    public double CalcularPromedio()
    {
        if (Calificaciones.Count == 0)
            return 0;

        double suma = 0;
        foreach (int calificacion in Calificaciones)
        {
            suma += calificacion;
        }

        return suma / Calificaciones.Count;
    }

    /// <summary>
    /// Muestra la información del alumno: nombre, matrícula, carrera y promedio.
    /// </summary>
    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Matrícula: {Matricula}");
        Console.WriteLine($"Carrera: {Carrera}");
        Console.WriteLine($"Promedio: {CalcularPromedio():F2}"); // Formato con 2 decimales
    }
}

public class Program
{
    public static void Main()
    {
        // Crear una instancia del alumno
        Alumno alumno = new Alumno();

        // Asignar valores a las propiedades
        Console.Write("Ingrese el nombre del alumno: ");
        alumno.Nombre = Console.ReadLine();

        Console.Write("Ingrese la matrícula del alumno: ");
        alumno.Matricula = Console.ReadLine();

        Console.Write("Ingrese la carrera del alumno: ");
        alumno.Carrera = Console.ReadLine();

        // Cargar las calificaciones
        alumno.Calificaciones = new List<int>();
        Console.WriteLine("Ingrese las calificaciones del alumno (escriba 'fin' para terminar):");

        while (true)
        {
            Console.Write("Calificación: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "fin")
                break;

            if (int.TryParse(input, out int calificacion) && calificacion >= 0 && calificacion <= 100)
            {
                alumno.Calificaciones.Add(calificacion);
            }
            else
            {
                Console.WriteLine("Calificación inválida. Debe ser un número entre 0 y 100.");
            }
        }

        // Mostrar la información del alumno
        alumno.MostrarInformacion();
    }
}
