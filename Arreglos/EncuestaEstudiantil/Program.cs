using System;

public class EncuestaEstudiantil
{
    public static void Main(string[] args)
    {
        int[] respuestas = { 1, 2, 6, 4, 8, 5, 9, 7, 8, 10, 1, 6, 3, 8, 6, 11,
                             10, 3, 8, 2, 7, 6, 5, 7, 6, 8, 6, 7, 5, 6, 6, 5, 6, 7, 5, 6,
                             12, 4, 8, 6, 8, 10 };

        int[] frecuencia = new int[13]; 

        for (int respuesta = 0; respuesta < respuestas.Length; respuesta++)
        {
            if (respuestas[respuesta] >= 1 && respuestas[respuesta] <= 12)
            {
                ++frecuencia[respuestas[respuesta]];
            }
        }

        Console.WriteLine("{0}{1,11}", "Calificación", "Frecuencia");

        for (int calificacion = 1; calificacion < frecuencia.Length; calificacion++)
        {
            Console.WriteLine("{0,12}{1,11}", calificacion, frecuencia[calificacion]);
        }
    }
} 
