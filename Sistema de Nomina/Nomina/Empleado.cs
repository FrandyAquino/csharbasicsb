using System;

public abstract class Empleado
{
    public string PrimerNombre { get; }
    public string ApellidoPaterno { get; }
    public string NSS { get; }

    public Empleado(string primerNombre, string apellidoPaterno, string nss)
    {
        PrimerNombre = primerNombre;
        ApellidoPaterno = apellidoPaterno;
        NSS = nss;
    }

    // Método abstracto que se sobrescribirá en las subclases
    public abstract decimal Ingresos();

    public override string ToString()
    {
        return $"Empleado: {PrimerNombre} {ApellidoPaterno}\nNúmero de seguro social: {NSS}";
    }
}
