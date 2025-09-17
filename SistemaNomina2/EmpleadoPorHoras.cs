using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class EmpleadoPorHoras : Empleado
{
    public decimal SueldoPorHora { get; set; }
    public int HorasTrabajadas { get; set; }

    public override decimal CalcularPagoSemanal()
    {
        if (HorasTrabajadas <= 40)
            return SueldoPorHora * HorasTrabajadas;
        else
            return (SueldoPorHora * 40) + (SueldoPorHora * 1.5m * (HorasTrabajadas - 40));
    }
    public override string Tipo => "Por Horas";
}
