// Fig. 8.11: PruebaPaqueteDeCartas.cs
// Aplicación para barajar y repartir cartas.
using System;

public class PruebaPaqueteDeCartas
{
    // Ejecuta la aplicación
    public static void Main(string[] args)
    {
        PaqueteDeCartas miPaqueteDeCartas = new PaqueteDeCartas();
        miPaqueteDeCartas.Barajar(); // Coloca las cartas en orden aleatorio

        // Imprime las 52 cartas en el orden en el que se reparten
        for (int i = 0; i < 13; i++)
        {
            // Reparte e imprime 4 objetos Carta
            Console.WriteLine("{0,-20}{1,-20}{2,-20}{3,-20}",
                miPaqueteDeCartas.RepartirCarta(),
                miPaqueteDeCartas.RepartirCarta(),
                miPaqueteDeCartas.RepartirCarta(),
                miPaqueteDeCartas.RepartirCarta());
        }
    }
}
