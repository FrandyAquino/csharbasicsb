// Fig. 8.10: PaqueteDeCartas.cs
// La clase PaqueteDeCartas representa un paquete de cartas de juego.
using System;

public class PaqueteDeCartas
{
    private Carta[] paquete; // arreglo de objetos Carta
    private int cartaActual; // subíndice de la siguiente Carta a repartir
    private const int NUMERO_DE_CARTAS = 52; // constante para el número de objetos Carta
    private Random numerosAleatorios; // generador de números aleatorios

    // El constructor llena el paquete de objetos Carta
    public PaqueteDeCartas()
    {
        string[] caras = { "As", "Dos", "Tres", "Cuatro", "Cinco", "Seis", "Siete", "Ocho", "Nueve", "Diez", "Joto", "Qüina", "Rey" };
        string[] palos = { "Corazones", "Diamantes", "Tréboles", "Espadas" };

        paquete = new Carta[NUMERO_DE_CARTAS]; // crea un arreglo de objetos Carta
        cartaActual = 0; // establece cartaActual para que la primera Carta repartida sea paquete[0]

        numerosAleatorios = new Random(); // crea el generador de números aleatorios

        // Llena el paquete con objetos Carta
        for (int cuenta = 0; cuenta < paquete.Length; cuenta++)
        {
            paquete[cuenta] = new Carta(caras[cuenta % 13], palos[cuenta / 13]);
        }
    }

    // Baraja el paquete de objetos Carta con un algoritmo de una pasada
    public void Barajar()
    {
        // Después de barajar, la repartición debe empezar otra vez en paquete[0]
        cartaActual = 0; // reinicializa cartaActual

        // Para cada Carta, selecciona otra Carta aleatoria y las intercambia
        for (int primera = 0; primera < paquete.Length; primera++)
        {
            // Selecciona un número aleatorio entre 0 y 51
            int segunda = numerosAleatorios.Next(NUMERO_DE_CARTAS);

            // Intercambia la Carta actual con la Carta seleccionada al azar
            Carta temp = paquete[primera];
            paquete[primera] = paquete[segunda];
            paquete[segunda] = temp;
        }
    }

    // Reparte una Carta
    public Carta RepartirCarta()
    {
        // Determina si hay objetos Carta por repartir
        if (cartaActual < paquete.Length)
            return paquete[cartaActual++]; // Devuelve la Carta actual en el arreglo
        else
            return null; // Devuelve null para indicar que se repartieron todos los objetos Carta
    }
}
