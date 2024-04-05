using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculo_de_sueldos
{
    public class EmpleadoPorHora : Empleado
    {
        public double PagoHora { get; set; }
        public double HorasTrabajadas { get; set; }
        public override double CalcularSueldo()
        {
            return PagoHora*HorasTrabajadas;
        }
    }
}
