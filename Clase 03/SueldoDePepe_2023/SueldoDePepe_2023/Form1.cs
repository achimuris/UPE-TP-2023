using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SueldoDePepe_2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empresa empresa = new Empresa();
            Cadete gerente = new Cadete();
            Empleado objEmpleado = new Empleado(gerente, "Pepe", "Pomping");


            MessageBox.Show(objEmpleado.Apellido + ", " + "\n" + objEmpleado.Nombre + "\n" + "Tiene un sueldo de: " + empresa.CalcularSueldo(objEmpleado, 0).ToString(), "Un título");
        }
    }
}
