using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class EmpleadoAsalariado : Empleado
{
    public decimal SalarioSemanal { get; set; }
    public override decimal CalcularPagoSemanal() => SalarioSemanal;
    public override string Tipo => "Asalariado";
}