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
    public partial class FormularioMostrarObjetosDelCamion : Form
    {
        public FormularioMostrarObjetosDelCamion()
        {
            InitializeComponent();
        }

        private MedioDeTransporte _medioDeTransporte;

        public MedioDeTransporte MedioDeTransporte
        {
            get { return _medioDeTransporte; }
            set { _medioDeTransporte = value; }
        }


        private void MostrarObjetosDelCamion_Load(object sender, EventArgs e)
        {
            this.grillaDeObjetosDelCamion.DataSource = _medioDeTransporte.ObjetosFragiles;
        }
    }
}
