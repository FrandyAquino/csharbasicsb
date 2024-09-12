class Program
{
    static void Main(string[] args)
    {
        Empleado[] empleados = new Empleado[]
        {
            new EmpleadoAsalariado("Juan", "Pérez", "123-45-6789", 800.00m),
            new EmpleadoPorHoras("Ana", "García", "987-65-4321", 20.00m, 45),
            new EmpleadoPorComision("Luis", "Martínez", "123-45-9876", 0.10m, 5000.00m),
            new EmpleadoBaseMasComision("Carla", "Hernández", "987-65-1234", 0.05m, 7000.00m, 300.00m)
        };

        foreach (Empleado empleado in empleados)
        {
            Console.WriteLine(empleado);
            Console.WriteLine($"Ingresos: {empleado.Ingresos():C}\n");
        }
    }
}
