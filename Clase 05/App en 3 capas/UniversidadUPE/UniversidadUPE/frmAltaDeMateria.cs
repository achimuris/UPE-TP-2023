using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversidadUPE
{
    public partial class frmAltaDeMateria : Form
    {
        public frmAltaDeMateria()
        {
            InitializeComponent();
        }

        Carrera carrera  = new Carrera();
        private void frmAltaDeMateria_Load(object sender, EventArgs e)
        {
            cmbCarreras.DataSource = carrera.RetornarCarreras();
            cmbCarreras.DisplayMember = "Descripción";
            cmbCarreras.ValueMember = "Identificador";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Materia objMateria = new Materia();
            objMateria.Nombre = txtNombreDeMateria.Text;
            objMateria.Carrera = new Carrera();
            objMateria.Carrera.ID = int.Parse(cmbCarreras.SelectedValue.ToString());

            bool pudoAgregar = carrera.AgregarMateria(objMateria.Nombre, objMateria.Carrera.ID);

            if (pudoAgregar)
            {
                MessageBox.Show("La materia se ha creado perfectamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ha ocurrido algo inesperado!!!");
            }


        }
    }
}
