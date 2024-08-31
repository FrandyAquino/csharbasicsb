using System;

public class PruebaLibroCalificaciones
{
    // El método Main comienza la ejecución de la aplicación
    public static void Main(string[] args)
    {
        // Arreglo unidimensional de calificaciones de estudiantes
        int[] arregloCalificaciones = { 87, 68, 94, 100, 83, 78, 85, 91, 76, 87 };

        // Crear una instancia de LibroCalificaciones con el nombre del curso y el arreglo de calificaciones
        LibroCalificaciones miLibroCalificaciones = new LibroCalificaciones(
            "CS101 Introducción a la programación en C#", arregloCalificaciones);

        // Mostrar un mensaje de bienvenida
        miLibroCalificaciones.MostrarMensaje();

        // Procesar las calificaciones
        miLibroCalificaciones.ProcesarCalificaciones();
    } // fin de Main
} // fin de la clase PruebaLibroCalificaciones
