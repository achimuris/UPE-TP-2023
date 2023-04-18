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
    public partial class FormularioIniciarSesion : Form
    {
        public FormularioIniciarSesion()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            
            EntidadNegocio.Usuario objUsuario = new EntidadNegocio.Usuario();
            Negocio.Usuario gestorUsuario = new Negocio.Usuario();

            try
            {
                objUsuario = gestorUsuario.ValidarUsuario(txtNombreDeUsuario.Text, txtPassword.Text);
            }
            catch (EntidadNegocio.Excepciones.ExcepcionDeNegocio excepcionPersonalizada)
            {
                objUsuario = null;
                MessageBox.Show(excepcionPersonalizada.Mensaje);
            }
            catch (Exception ex)
            {
                objUsuario = null;
                MessageBox.Show("Ocurrió una Exception: " + ex.Message);
            }


            if (objUsuario==null)
            {
                MessageBox.Show("Usuario o clave es invalido");
            }
            else
            {
                const int idPerfilProfesor = 1;
                const int idPerfilAdminisrativo = 2;
                const int idPerfilAlumno = 3;

                Form formularioDeUsuario;


                switch (objUsuario.Perfil.ID)
                {
                    case idPerfilProfesor:
                        formularioDeUsuario = new FormularioProfesor();
                        this.Hide();
                        formularioDeUsuario.ShowDialog();
                        break;

                    case idPerfilAdminisrativo:
                        formularioDeUsuario = new OtroFormulario();
                        this.Hide();
                        formularioDeUsuario.ShowDialog();
                        break;

                    case idPerfilAlumno:
                        formularioDeUsuario = new OtroFormulario();
                        this.Hide();
                        formularioDeUsuario.ShowDialog();
                        break;
                    default:
                        formularioDeUsuario = new OtroFormulario();
                        this.Hide();
                        formularioDeUsuario.ShowDialog();
                        break;
                }
            }
        }
    }
}
