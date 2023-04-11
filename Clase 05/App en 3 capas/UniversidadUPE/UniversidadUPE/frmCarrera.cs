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

        Carrera carrera = new Carrera();

        private void frmCarrera_Load(object sender, EventArgs e)
        {
            this.Text = "Universidad Provincial de Ezeiza";
            

            

            cmbCarreras.DataSource = carrera.RetornarCarreras();
            cmbCarreras.DisplayMember = "Descripción";
            cmbCarreras.ValueMember = "Identificador";

            dgvMaterias.DataSource = carrera.RetonarMaterias(1);

        }

        private void btnMostrarID_Click(object sender, EventArgs e)
        {
            string textoPersonalizado = string.Format("{0} - {1}", cmbCarreras.SelectedValue.ToString(), cmbCarreras.Text);
            MessageBox.Show(textoPersonalizado);
        }

        private void cmbCarreras_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int idCarrera = int.Parse(cmbCarreras.SelectedValue.ToString());
                dgvMaterias.DataSource = carrera.RetonarMaterias(idCarrera);
            }
            catch (Exception)
            {

                
            }
        }

        private void btnCrearMateria_Click(object sender, EventArgs e)
        {
            frmAltaDeMateria formularioDeNuevaMateria = new frmAltaDeMateria();
            formularioDeNuevaMateria.ShowDialog();
        }
    }
}
