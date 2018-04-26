using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlEscolar
{
    public partial class frmDatosEscuela : Form
    {
        public frmDatosEscuela()
        {
            InitializeComponent();
        }

        private void frmDatosEscuela_Load(object sender, EventArgs e)
        {
            if (Globales.miEscuela != null)
            {
                txtNombre.Text = Globales.miEscuela.Nombre;
                txtReponsable.Text = Globales.miEscuela.Responsable;
                txtDireccion.Text = Globales.miEscuela.Direccion;
                txtTelefono.Text = Globales.miEscuela.Telefono;
            }
        }

        private void btnCrearEsc_Click(object sender, EventArgs e)
        {
            if (Globales.miEscuela == null)
                Globales.miEscuela = new Escuela();

            Globales.miEscuela.Nombre = txtNombre.Text;
            Globales.miEscuela.Responsable = txtReponsable.Text;
            Globales.miEscuela.Direccion = txtDireccion.Text;
            Globales.miEscuela.Telefono = txtTelefono.Text;
            this.Close();
        }
    }
}
