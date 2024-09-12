public class EmpleadoPorHoras : Empleado
{
    private decimal sueldoPorHora;
    private decimal horasTrabajadas;

    public EmpleadoPorHoras(string primerNombre, string apellidoPaterno, string nss, decimal sueldoPorHora, decimal horasTrabajadas)
        : base(primerNombre, apellidoPaterno, nss)
    {
        this.sueldoPorHora = sueldoPorHora;
        this.horasTrabajadas = horasTrabajadas;
    }

    public override decimal Ingresos()
    {
        if (horasTrabajadas <= 40)
            return sueldoPorHora * horasTrabajadas;
        else
            return (40 * sueldoPorHora) + ((horasTrabajadas - 40) * sueldoPorHora * 1.5m); // Pago extra por horas adicionales
    }

    public override string ToString()
    {
        return $"{base.ToString()}\nSueldo por horas: {sueldoPorHora:C}\nHoras trabajadas: {horasTrabajadas}";
    }
}
