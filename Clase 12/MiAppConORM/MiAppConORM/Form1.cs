using Entidades;

namespace MiAppConORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            dgvMaterias.DataSource = new LogicaNegocio.Materia().ListaDeMaterias();
        }

        private void btnObtenerMateriaPorId_Click(object sender, EventArgs e)
        {
            LogicaNegocio.Materia gestorMateria = new LogicaNegocio.Materia();


            Materium entidadMateria = gestorMateria.GetMateriaPorId(int.Parse(txtIdMateria.Text));
            if (entidadMateria == null)
            {
                MessageBox.Show("No existe la materia buscada");
            }
            else
            {
                MessageBox.Show(entidadMateria.Descripcion);
            }
        }

        private void btnAgregaNuevaMateria_Click(object sender, EventArgs e)
        {
            LogicaNegocio.Materia gestorMateria = new LogicaNegocio.Materia();
            gestorMateria.AgregarEntidad();
            ActualizarGrilla();
        }
    }
}