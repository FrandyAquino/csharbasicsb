// Fig. 8.9: Carta.cs
// La clase Carta representa una carta de juego.
public class Carta
{
    private string cara; // cara de la carta ("As", "Dos", ...)
    private string palo; // palo de la carta ("Corazones", "Diamantes", ...)

    // El constructor con dos parámetros inicializa la cara y el palo de la carta
    public Carta(string caraCarta, string paloCarta)
    {
        cara = caraCarta;   // inicializa la cara de la carta
        palo = paloCarta;   // inicializa el palo de la carta
    }

    // Devuelve representación de cadena del objeto Carta
    public override string ToString()
    {
        return cara + " de " + palo;
    }
}
