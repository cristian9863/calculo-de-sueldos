using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculo_de_sueldos
{
    public abstract class Empleado
    {
        public int Codigo {  get; set; }
        public string Apellido { get; set; }

        public abstract double CalcularSueldo();
    }
}
