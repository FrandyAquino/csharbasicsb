// Fig. 8.4: InicArreglo.cs
// Cálculo de los valores a colocar en los elementos de un arreglo.
using System;

public class InicArreglo
{
    public static void Main(string[] args)
    {
        const int LONGITUD_ARREGLO = 10; // crea una constante con nombre
        int[] arreglo = new int[LONGITUD_ARREGLO]; // crea el arreglo

        // calcula el valor para cada elemento del arreglo
        for (int contador = 0; contador < arreglo.Length; contador++)
            arreglo[contador] = 2 + 2 * contador;

        Console.WriteLine("{0}{1,8}", "Índice", "Valor"); // encabezados

        // imprime en pantalla el valor de cada elemento del arreglo
        for (int contador = 0; contador < arreglo.Length; contador++)
            Console.WriteLine("{0,5}{1,8}", contador, arreglo[contador]);
    } // fin de Main
} // fin de la clase InicArreglo
