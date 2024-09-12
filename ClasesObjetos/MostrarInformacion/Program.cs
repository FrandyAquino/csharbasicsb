using System;

public class Libro
{
    // Propiedades del libro
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int Paginas { get; set; }

    /// <summary>
    /// Muestra la información del libro.
    /// </summary>
    public void MostrarInformacion()
    {
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Autor: {Autor}");
        Console.WriteLine($"Páginas: {Paginas}");
    }

    /// <summary>
    /// Devuelve true si el libro tiene más de 500 páginas, false en caso contrario.
    /// </summary>
    public bool EsLargo()
    {
        return Paginas > 500;
    }
}

public class Program
{
    public static void Main()
    {
        // Crear una instancia del libro
        Libro libro = new Libro();

        // Asignar valores a las propiedades
        Console.Write("Ingrese el título del libro: ");
        libro.Titulo = Console.ReadLine();

        Console.Write("Ingrese el autor del libro: ");
        libro.Autor = Console.ReadLine();

        Console.Write("Ingrese el número de páginas: ");
        if (!int.TryParse(Console.ReadLine(), out int paginas))
        {
            Console.WriteLine("Número de páginas inválido.");
            return;
        }
        libro.Paginas = paginas;

        // Mostrar la información del libro
        libro.MostrarInformacion();

        // Verificar si el libro es largo
        if (libro.EsLargo())
        {
            Console.WriteLine("El libro es largo.");
        }
        else
        {
            Console.WriteLine("El libro no es largo.");
        }
    }
}
