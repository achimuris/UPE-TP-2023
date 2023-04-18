using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormularioProfesor : Form
    {
        public FormularioProfesor()
        {
            InitializeComponent();
        }

        private void FormularioProfesor_Load(object sender, EventArgs e)
        {
            Negocio.Usuario usuario = new Negocio.Usuario();

            dgvUsuarios.DataSource = usuario.Usuarios();
        }
    }
}
