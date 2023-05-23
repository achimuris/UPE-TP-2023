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
    public partial class FrmDetalleVenta : Form
    {
        public FrmDetalleVenta()
        {
            InitializeComponent();
        }

        private VehiculoEuropeo  _auto;

        public VehiculoEuropeo Vehiculo
        {
            get { return _auto; }
            set { _auto = value; }
        }

        private EmpresaImportadora _empresa;

        public EmpresaImportadora Empresa
        {
            get { return _empresa; }
            set { _empresa = value; }
        }



        private void FrmDetalleVenta_Load(object sender, EventArgs e)
        {
            dgvAdicionales.DataSource = Vehiculo.Adicionales;
            txtPrecioEnDolares.Text = Vehiculo.PrecioEnDolar().ToString();
            txtPrecioEnPesos.Text = (Vehiculo.PrecioEnDolar() * Empresa.CotizacionDelDia).ToString();
            txtValorFinalEnPesos.Text = Empresa.CalcularPrecio(Vehiculo).ToString();
        }
    }
}
