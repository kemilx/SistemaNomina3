using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class EmpleadoPorComision : Empleado
{
    public decimal TotalVentas { get; set; }
    public decimal TarifaComision { get; set; }

    public override decimal CalcularPagoSemanal() => TotalVentas * TarifaComision;
    public override string Tipo => "Por Comisión";
}
