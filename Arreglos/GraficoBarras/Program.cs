// Fig. 8.6: GraficoBarras.cs
// Aplicación para imprimir gráficos de barras.
using System;

public class GraficoBarras
{
    public static void Main(string[] args)
    {
        int[] arreglo = { 0, 0, 0, 0, 0, 0, 1, 2, 4, 2, 1 };

        Console.WriteLine("Distribución de las calificaciones:");

        // para cada elemento del arreglo, mostrar en pantalla una barra del gráfico
        for (int contador = 0; contador < arreglo.Length; contador++)
        {
            // muestra etiquetas de las barras ("00-09: ", ..., "90-99: ", "100: ")
            if (contador == 10)
                Console.Write("  100: ");
            else
                Console.Write("{0:D2}-{1:D2}: ",
                    contador * 10, contador * 10 + 9);

            // imprime barra de asteriscos
            for (int estrellas = 0; estrellas < arreglo[contador]; estrellas++)
                Console.Write("*");

            Console.WriteLine(); // inicia una nueva línea de salida
        } // fin de for externo
    } // fin de Main
} // fin de la clase GraficoBarras
