public class EmpleadoBaseMasComision : EmpleadoPorComision
{
    private decimal salarioBase;

    public EmpleadoBaseMasComision(string primerNombre, string apellidoPaterno, string nss, decimal tarifaComision, decimal ventasBrutas, decimal salarioBase)
        : base(primerNombre, apellidoPaterno, nss, tarifaComision, ventasBrutas)
    {
        this.salarioBase = salarioBase;
    }

    public override decimal Ingresos()
    {
        return salarioBase + base.Ingresos(); // Salario base + comisión por ventas
    }

    public override string ToString()
    {
        return $"{base.ToString()}\nSalario base: {salarioBase:C}";
    }
}
