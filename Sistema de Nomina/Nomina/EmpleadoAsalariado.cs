public class EmpleadoAsalariado : Empleado
{
    private decimal salarioSemanal;

    public EmpleadoAsalariado(string primerNombre, string apellidoPaterno, string nss, decimal salarioSemanal)
        : base(primerNombre, apellidoPaterno, nss)
    {
        this.salarioSemanal = salarioSemanal;
    }

    public override decimal Ingresos()
    {
        return salarioSemanal; // Salario fijo semanal
    }

    public override string ToString()
    {
        return $"{base.ToString()}\nSalario semanal: {salarioSemanal:C}";
    }
}
