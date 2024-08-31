// Fig. 8.7: TirarDado.cs
// Tirar 6000 veces un dado de seis lados.
using System;

public class TirarDado
{
    public static void Main(string[] args)
    {
        Random numerosAleatorios = new Random(); // generador de números aleatorios
        int[] frecuencia = new int[7]; // arreglo de contadores de frecuencia

        // tira el dado 6000 veces; usa el valor del dado como subíndice de frecuencia
        for (int tiro = 1; tiro <= 6000; tiro++)
            ++frecuencia[numerosAleatorios.Next(1, 7)];

        Console.WriteLine("{0}{1,10}", "Cara", "Frecuencia");

        // imprime en pantalla el valor de cada elemento del arreglo
        for (int cara = 1; cara < frecuencia.Length; cara++)
            Console.WriteLine("{0,4}{1,10}", cara, frecuencia[cara]);
    } // fin de Main
} // fin de la clase TirarDado
