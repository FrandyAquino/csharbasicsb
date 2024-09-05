// Fig. 4.5: LibroPruebaCalificaciones.cs
// Crea objeto LibroCalificaciones y pasa una cadena a su método MostrarMensaje.
using System;

public class LibroPruebaCalificaciones
{
    // El método Main comienza la ejecución del programa
    public static void Main(string[] args)
    {
        // Crea un objeto LibroCalificaciones y lo asigna a miLibroCalificaciones
        LibroCalificaciones miLibroCalificaciones = new LibroCalificaciones();

        // Pide el nombre del curso y lo recibe como entrada
        Console.WriteLine("Por favor escriba el nombre del curso:");
        string nombreDelCurso = Console.ReadLine(); // Lee una línea de texto
        Console.WriteLine();   // Imprime en pantalla una línea en blanco

        // Llama al método MostrarMensaje de miLibroCalificaciones
        // y pasa nombreDelCurso como argumento
        miLibroCalificaciones.MostrarMensaje(nombreDelCurso);
    }  // fin de Main
}
