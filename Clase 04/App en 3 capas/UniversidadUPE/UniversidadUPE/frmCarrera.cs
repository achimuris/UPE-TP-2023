using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace UniversidadUPE
{
    public partial class frmCarrera : Form
    {
        public frmCarrera()
        {
            InitializeComponent();
        }

        private void frmCarrera_Load(object sender, EventArgs e)
        {
            this.Text = "Universidad Provincial de Ezeiza";
            Carrera carrera = new Carrera();

            dgvCarreras.DataSource = carrera.RetornarCarreras();

            cmbCarreras.DataSource = carrera.RetornarCarreras();
            cmbCarreras.DisplayMember = "Descripción";
            cmbCarreras.ValueMember = "Identificador";

        }

        private void btnMostrarID_Click(object sender, EventArgs e)
        {
            string textoPersonalizado = string.Format("{0} - {1}", cmbCarreras.SelectedValue.ToString(), cmbCarreras.Text);
            MessageBox.Show(textoPersonalizado);
        }
    }
}
