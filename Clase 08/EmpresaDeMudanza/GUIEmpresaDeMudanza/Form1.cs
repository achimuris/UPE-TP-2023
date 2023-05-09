using MisClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIEmpresaDeMudanza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private EmpresaDeMudanza objEmpresaDeMudanza;

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Camion camion1 = new Camion("Camión 1");
            Camion camion2 = new Camion("Camión 2");
            Flete flete = new Flete("Flete");

            

            Empleado cadete1 = new Empleado();

            cadete1.Nombre = "Juan";
            cadete1.ToleranciaPeso = 70;

            Empleado cadete2 = new Empleado();

            cadete2.Nombre = "Roberto Sanchez";
            cadete2.ToleranciaPeso = 50;

            List<Empleado> listaDeEmpleados = new List<Empleado>();
            listaDeEmpleados.Add(cadete1);
            listaDeEmpleados.Add(cadete2);
            

            objEmpresaDeMudanza = new EmpresaDeMudanza(listaDeEmpleados);


            objEmpresaDeMudanza.MediosDeTransportes.Add(camion1);
            objEmpresaDeMudanza.MediosDeTransportes.Add(camion2);
            objEmpresaDeMudanza.MediosDeTransportes.Add(flete);

            lboxMediosDeTransportes.DataSource = objEmpresaDeMudanza.MediosDeTransportes;
            lboxMediosDeTransportes.DisplayMember = "Patente";

            lboxEmpleados.DataSource = objEmpresaDeMudanza.Empleados;
            //lboxEmpleados.DisplayMember = "Nombre";


        }

        private void btnAgregarAlCamion_Click(object sender, EventArgs e)
        {
            ObjetoDeMudanza objeto = new ObjetoDeMudanza();
            objeto.EsFragil = cboxEsFragil.Checked;
            objeto.Largo = (int)nudLargo.Value;
            objeto.Ancho = (int)nudAncho.Value;
            objeto.Alto = (int)nudAlto.Value;
            objeto.Peso = (double)nudPeso.Value;
            objeto.Nombre = txtNombreObjeto.Text;

            Empleado empleadoSeleccionado = (Empleado) lboxEmpleados.SelectedValue;

            MedioDeTransporte medioDeTransporte = (MedioDeTransporte)lboxMediosDeTransportes.SelectedValue;

            try
            {
                empleadoSeleccionado.SubirObjeto(objeto, medioDeTransporte);
            }
            catch (ExcepcionPorPeso objException)
            {

                MessageBox.Show(objException.Mensaje);
            }



        }

        private void btnMostrarObjetosDelCamion_Click(object sender, EventArgs e)
        {
            FormularioMostrarObjetosDelCamion formularioMostrarGrilla = new FormularioMostrarObjetosDelCamion();


            formularioMostrarGrilla.MedioDeTransporte = (MedioDeTransporte)lboxMediosDeTransportes.SelectedValue;
            formularioMostrarGrilla.ShowDialog();
        }
    }
}
