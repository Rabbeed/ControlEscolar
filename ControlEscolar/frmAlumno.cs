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

        private void frmAlumno_Load(object sender, EventArgs e)
        {
            grpAlumno.Enabled = false;
            btnGuardar.Enabled = false;
        }

        private void frmAlumno_Activated(object sender, EventArgs e)
        {
            if (Globales.miAlumno != null)
            {
                txtNombre.Text = Globales.miAlumno.Nombre;
                txtEdad.Text = Globales.miAlumno.Edad.ToString();
                cboCalifs.Items.Clear();
                foreach (float calif in Globales.miAlumno.ObtenCalifs()) cboCalifs.Items.Add(calif);
                btnNuevo.Enabled = false;
                grpAlumno.Enabled = true;
                btnGuardar.Enabled = true;
            }
        }

        private void cboCalifs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                float cal = float.Parse(cboCalifs.Text);
                if (cboCalifs.Text.Length != 0 && (cal >= 10.00f && cal <= 100.00f))
                    cboCalifs.Items.Add(float.Parse(cboCalifs.Text));
            }
            else
                if (e.KeyChar == 8)
                    if (cboCalifs.SelectedIndex != -1)
                        cboCalifs.Items.RemoveAt(cboCalifs.SelectedIndex);
        }

        private void cboCalifs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboCalifs_Click(object sender, EventArgs e)
        {
            
        }
    }
}
