using System;
using System.Collections.Generic;

internal class Program
{
    // Lista donde se guardan todos los empleados
    private static List<Empleado> empleados = new List<Empleado>();

    private static void Main()
    {
        while (true)
        {
            // Menú principal
            Console.WriteLine("\n1. Registrar Empleado");
            Console.WriteLine("2. Editar Empleado");
            Console.WriteLine("3. Reporte semanal");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");
            var opt = Console.ReadLine();

            switch (opt)
            {
                case "1":
                    RegistrarEmpleado(); 
                    break;

                case "2":
                    EditarEmpleado(); 

                case "3":
                    Reporte(); 
                    break;

                case "4":
                    return; 

                default:
                    Console.WriteLine("Opción no válida, intenta de nuevo.");
                    break;
            }
        }
    }

    // Permite registrar un empleado según su tipo
    private static void RegistrarEmpleado()
    {
        Console.WriteLine("Tipo de empleado:");
        Console.WriteLine("1. Asalariado");
        Console.WriteLine("2. Por Horas");
        Console.WriteLine("3. Por Comisión");
        Console.WriteLine("4. Asalariado por Comisión");
        Console.Write("Seleccione: ");
        var tipo = Console.ReadLine();

        Empleado empleado = null;

        switch (tipo)
        {
            case "1": // Empleado Asalariado
                empleado = new EmpleadoAsalariado();
                Console.Write("Nombre: ");
                empleado.Nombre = Console.ReadLine();
                Console.Write("Apellido: ");
                empleado.Apellido = Console.ReadLine();
                Console.Write("NSS: ");
                empleado.NumeroSeguroSocial = Console.ReadLine();
                Console.Write("Salario semanal: ");
                ((EmpleadoAsalariado)empleado).SalarioSemanal = decimal.Parse(Console.ReadLine());
                break;

            case "2": // Empleado por Horas
                empleado = new EmpleadoPorHoras();
                Console.Write("Nombre: ");
                empleado.Nombre = Console.ReadLine();
                Console.Write("Apellido: ");
                empleado.Apellido = Console.ReadLine();
                Console.Write("NSS: ");
                empleado.NumeroSeguroSocial = Console.ReadLine();
                Console.Write("Sueldo por hora: ");
                ((EmpleadoPorHoras)empleado).SueldoPorHora = decimal.Parse(Console.ReadLine());
                Console.Write("Horas trabajadas: ");
                ((EmpleadoPorHoras)empleado).HorasTrabajadas = int.Parse(Console.ReadLine());
                break;

            case "3": // Empleado por Comisión
                empleado = new EmpleadoPorComision();
                Console.Write("Nombre: ");
                empleado.Nombre = Console.ReadLine();
                Console.Write("Apellido: ");
                empleado.Apellido = Console.ReadLine();
                Console.Write("NSS: ");
                empleado.NumeroSeguroSocial = Console.ReadLine();
                Console.Write("Ventas brutas: ");
                ((EmpleadoPorComision)empleado).TotalVentas = decimal.Parse(Console.ReadLine());
                Console.Write("Tarifa comisión (ejemplo: 0.05): ");
                ((EmpleadoPorComision)empleado).TarifaComision = decimal.Parse(Console.ReadLine());
                break;

            case "4": // Empleado Asalariado por Comisión
                empleado = new EmpleadoAsalariadoPorComision();
                Console.Write("Nombre: ");
                empleado.Nombre = Console.ReadLine();
                Console.Write("Apellido: ");
                empleado.Apellido = Console.ReadLine();
                Console.Write("NSS: ");
                empleado.NumeroSeguroSocial = Console.ReadLine();
                Console.Write("Ventas brutas: ");
                ((EmpleadoAsalariadoPorComision)empleado).TotalVentas = decimal.Parse(Console.ReadLine());
                Console.Write("Tarifa comisión (ejemplo: 0.05): ");
                ((EmpleadoAsalariadoPorComision)empleado).TarifaComision = decimal.Parse(Console.ReadLine());
                Console.Write("Salario base: ");
                ((EmpleadoAsalariadoPorComision)empleado).SalarioBase = decimal.Parse(Console.ReadLine());
                break;

            default:
                Console.WriteLine("Tipo inválido. Nada que registrar.");
                return;
        }

        empleados.Add(empleado);
        Console.WriteLine("Empleado agregado con éxito!"); 
    }

    // Edita los datos de un empleado 
    private static void EditarEmpleado()
    {
        Console.Write("NSS del empleado a actualizar: ");
        var nss = Console.ReadLine();
        var empleado = empleados.Find(e => e.NumeroSeguroSocial == nss);

        if (empleado == null)
        {
            Console.WriteLine("No se encontró el empleado.");
            return;
        }

        empleados.Remove(empleado); // Lo eliminamos para reemplazarlo con nuevos datos
        Console.WriteLine("Ingrese los nuevos datos:");
        RegistrarEmpleado();
    }

    // Muestra el reporte semanal de todos los empleados
    private static void Reporte()
    {
        Console.WriteLine("\n--- Reporte Semanal ---");
        foreach (var e in empleados)
        {
            Console.WriteLine($"Tipo: {e.Tipo}");
            Console.WriteLine($"Nombre: {e.Nombre} {e.Apellido}");
            Console.WriteLine($"NSS: {e.NumeroSeguroSocial}");
            Console.WriteLine($"Pago semanal: {e.CalcularPagoSemanal():C}");
            Console.WriteLine("----------------------");
        }
    }
}
