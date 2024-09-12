public class EmpleadoPorComision : Empleado
{
    private decimal tarifaComision;
    private decimal ventasBrutas;

    public EmpleadoPorComision(string primerNombre, string apellidoPaterno, string nss, decimal tarifaComision, decimal ventasBrutas)
        : base(primerNombre, apellidoPaterno, nss)
    {
        this.tarifaComision = tarifaComision;
        this.ventasBrutas = ventasBrutas;
    }

    public override decimal Ingresos()
    {
        return tarifaComision * ventasBrutas; // Comisión basada en ventas
    }

    public override string ToString()
    {
        return $"{base.ToString()}\nVentas brutas: {ventasBrutas:C}\nTarifa de comisión: {tarifaComision:P}";
    }
}
