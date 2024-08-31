// Fig. 8.3: InicArreglo.cs
// Inicialización de los elementos de un arreglo, mediante un inicializador de arreglos.
using System;

public class InicArreglo
{
    public static void Main(string[] args)
    {
        // la lista inicializadora especifica el valor para cada elemento
        int[] arreglo = { 32, 27, 64, 18, 95, 14, 90, 70, 60, 37 };

        Console.WriteLine("{0}{1,8}", "Índice", "Valor"); // encabezados

        // imprime en pantalla el valor de cada elemento del arreglo
        for (int contador = 0; contador < arreglo.Length; contador++)
            Console.WriteLine("{0,5}{1,8}", contador, arreglo[contador]);
    } // fin de Main
} // fin de la clase InicArreglo
