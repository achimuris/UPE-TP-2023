using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialTemaA
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        EmpresaImportadora oEmpresa = new EmpresaImportadora();
        private void Form1_Load(object sender, EventArgs e)
        {
            this.lboxVehiculosParaVender.DataSource = oEmpresa.Vehiculos;
            this.nudCotizacionDolar.Value = (Decimal)oEmpresa.CotizacionDelDia;
            //this.cboxAdicionales.Items.a = oEmpresa.Adicionales;
            
            foreach (AdicionalVehiculo unAdicional in  oEmpresa.Adicionales)
            {
                this.cboxAdicionales.Items.Add(unAdicional);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lboxVehiculosParaVender.SelectedItems.Count==0)
            {
                MessageBox.Show("Debe seleccionar un auto de la lista");
                return;
            }

            if (nudCotizacionDolar.Value <= 0)
            {
                MessageBox.Show("Cargue una cotización valida");
                return;
            }

            //Piso la cotización del día de la empresa
            oEmpresa.CotizacionDelDia = (double) nudCotizacionDolar.Value;
            
            
            //MessageBox.Show("Seleccionó un auto");

            VehiculoEuropeo elCocheSeleccionado = (VehiculoEuropeo)lboxVehiculosParaVender.SelectedItem;
            elCocheSeleccionado.Adicionales = new List<AdicionalVehiculo>();
            foreach (var item in cboxAdicionales.CheckedItems)
            {
                elCocheSeleccionado.Adicionales.Add((AdicionalVehiculo) item);
               
            }

            FrmDetalleVenta formularioDetalleDeLaVenta = new FrmDetalleVenta();

            formularioDetalleDeLaVenta.Empresa = oEmpresa;
            formularioDetalleDeLaVenta.Vehiculo = elCocheSeleccionado;

            formularioDetalleDeLaVenta.ShowDialog();

            //MessageBox.Show("El precio del " + elCocheSeleccionado.Descripcion + " es de " + oEmpresa.CalcularPrecio(elCocheSeleccionado).ToString());
                
                
            
        }
    }
}
