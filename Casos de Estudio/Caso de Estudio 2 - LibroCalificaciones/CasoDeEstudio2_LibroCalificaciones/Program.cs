using System;

public class LibroCalificaciones
{
    private string nombreCurso;
    private int[] calificaciones;

    public LibroCalificaciones(string nombre, int[] arregloCalificaciones)
    {
        nombreCurso = nombre;
        calificaciones = arregloCalificaciones;
    }

    public string NombreCurso
    {
        get { return nombreCurso; }
        set { nombreCurso = value; }
    }

    public void MostrarMensaje()
    {
        Console.WriteLine("¡Bienvenido al libro de calificaciones para\n{0}!\n", NombreCurso);
    }

    public void ProcesarCalificaciones()
    {
        ImprimeCalificaciones();
        Console.WriteLine("\nEl promedio de la clase es {0:F2}", ObtenerPromedio());
        Console.WriteLine("La calificación más baja es {0}\nLa calificación más alta es {1}\n", ObtenerMinimo(), ObtenerMaximo());
        ImprimirGraficoBarras();
    }

    public int ObtenerMinimo()
    {
        int califBaja = calificaciones[0];
        foreach (int calificacion in calificaciones)
        {
            if (calificacion < califBaja)
                califBaja = calificacion;
        }
        return califBaja;
    }

    public int ObtenerMaximo()
    {
        int califAlta = calificaciones[0];
        foreach (int calificacion in calificaciones)
        {
            if (calificacion > califAlta)
                califAlta = calificacion;
        }
        return califAlta;
    }

    public double ObtenerPromedio()
    {
        int total = 0;
        foreach (int calificacion in calificaciones)
            total += calificacion;
        return (double)total / calificaciones.Length;
    }

    public void ImprimirGraficoBarras()
    {
        Console.WriteLine("Distribucion de calificaciones:");
        int[] frecuencia = new int[11];

        foreach (int calificacion in calificaciones)
            ++frecuencia[calificacion / 10];

        for (int cuenta = 0; cuenta < frecuencia.Length; cuenta++)
        {
            if (cuenta == 10)
                Console.Write(" 100: ");
            else
                Console.Write("{0:D2}-{1:D2}: ", cuenta * 10, cuenta * 10 + 9);

            for (int estrellas = 0; estrellas < frecuencia[cuenta]; estrellas++)
                Console.Write("*");

            Console.WriteLine();
        }
    }

    public void ImprimeCalificaciones()
    {
        Console.WriteLine("Las calificaciones son:\n");
        for (int estudiante = 0; estudiante < calificaciones.Length; estudiante++)
            Console.WriteLine("Estudiante {0,2}: {1,3}", estudiante + 1, calificaciones[estudiante]);
    }
}
