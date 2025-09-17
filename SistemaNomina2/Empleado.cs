using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public abstract class Empleado
{
    public string Nombre { get; set; } = "";
    public string Apellido { get; set; } = "";
    public string NumeroSeguroSocial { get; set; } = "";

    public abstract decimal CalcularPagoSemanal();
    public abstract string Tipo { get; }
}