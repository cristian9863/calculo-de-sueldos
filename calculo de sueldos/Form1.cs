using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculo_de_sueldos
{
    public partial class Form1 : Form
    {
        private object txtCodigoHora;
        private object txtApellidoHora;
        private object txtPagoHora;
        private object txtHorasHora;
        private object txtCodigoComision;
        private object txtApellidoComision;
        private object txtSueldoBase;
        private object txtPagoArticulo;
        private object txtNumeroArticulos;
        private object lblSueldoHora;
        private object lblSueldoComision;

        public int NumeroArticulos { get; private set; }

        public Form1()
        {
            InitializeComponent();

         txtCodigoHora = new TextBox();
         txtApellidoHora= new TextBox(); 
         txtPagoHora = new TextBox(); 
         txtHorasHora= new TextBox(); 
         txtCodigoComision = new TextBox(); 
         txtApellidoComision = new TextBox(); 
         txtSueldoBase = new TextBox(); 
         txtPagoArticulo = new TextBox();
         txtNumeroArticulos = new TextBox();
         lblSueldoHora = new Label();
         lblSueldoComision = new Label();
    }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            EmpleadoPorHora empleadoPorHora = new EmpleadoPorHora
            {
                Codigo = int.Parse(txtCodigoHora.ToString()),
                Apellido = txtApellidoHora.ToString(),
                PagoHora = double.Parse(txtPagoHora.ToString()),
                HorasTrabajadas = double.Parse(txtHorasHora.ToString())
            };
            lblSueldoHora = $"Sueldo del empleado por hora: {empleadoPorHora.CalcularSueldo()}";

            string s = txtNumeroArticulos.ToString();
            EmpleadosPorComision empleadosPorComision = new EmpleadosPorComision
            {
                Codigo = int.Parse(txtCodigoComision.ToString()),
                Apellido = txtApellidoComision.ToString(),
                SueldoBase = double.Parse(txtSueldoBase.ToString()),
                PagoPorArticulo = double.Parse(txtPagoArticulo.ToString(),
                NumeroArticulos = int.Parse


            };
            lblSueldoComision = $"Sueldo del empleado por comision: {empleadosPorComision.CalcularSueldo()}";
        }

        
    }
}
