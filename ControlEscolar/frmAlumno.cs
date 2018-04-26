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
    public partial class frmAlumno : Form
    {
        public frmAlumno()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            grpAlumno.Enabled = true;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            txtNombre.Clear();
            txtEdad.Clear();
            cboCalifs.Items.Clear();
            txtNombre.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Globales.miAlumno != null)
            {
                Globales.miAlumno.Nombre = txtNombre.Text;
                Globales.miAlumno.Edad = int.Parse(txtEdad.Text);
                Globales.miAlumno.ObtenCalifs().Clear();
                foreach (float cal in cboCalifs.Items)
                    Globales.miAlumno.AgregaCalif(cal);
            }
            else
            {
                Alumno nuevoAlumno = new Alumno(txtNombre.Text, int.Parse(txtEdad.Text));
                foreach (float cal in cboCalifs.Items)
                    nuevoAlumno.AgregaCalif(cal);
                Globales.miGrupo.AgregaAlumno(nuevoAlumno);
                Globales.miAlumno = nuevoAlumno;
            }
            grpAlumno.Enabled = false;
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            txtNombre.Focus();
        }
    }
}
