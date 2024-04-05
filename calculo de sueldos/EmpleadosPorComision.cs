using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculo_de_sueldos
{
    public class EmpleadosPorComision : Empleado
    {
        public double SueldoBase { get; set; }
        public double PagoPorArticulo { get; set; }
        public int NumeroArticulos { get; set; }

        public override double CalcularSueldo()
        {
            return SueldoBase + (PagoPorArticulo * NumeroArticulos);
        }
    }
}
