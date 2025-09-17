using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class EmpleadoAsalariadoPorComision : Empleado
{
    public decimal TotalVentas { get; set; }
    public decimal TarifaComision { get; set; }
    public decimal SalarioBase { get; set; }

    public override decimal CalcularPagoSemanal() =>
        (TotalVentas * TarifaComision) + SalarioBase + (SalarioBase * 0.10m);

    public override string Tipo => "Asalariado por Comisión";
}