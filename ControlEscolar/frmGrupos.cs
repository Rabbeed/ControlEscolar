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
    public partial class frmGrupos : Form
    {
        public frmGrupos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Globales.miAlumno = null;
            frmAlumno al = new frmAlumno();
            al.Show();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            grpDatos.Enabled = true;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            txtGrado.Clear();
            txtProfesor.Clear();
            txtProfesor.Focus();
            Globales.miGrupo = null;
        }

        private void frmGrupos_Load(object sender, EventArgs e)
        {
            if(Globales.miGrupo != null)
            {
                txtProfesor.Text = Globales.miGrupo.NombreProfesor;
                txtGrado.Text = Globales.miGrupo.Grado.ToString();
            }
            grpDatos.Enabled = false;
            btnAgregar.Enabled = false;
            btnGuardar.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Globales.miGrupo != null)
            {
                Globales.miGrupo.NombreProfesor = txtProfesor.Text;
                Globales.miGrupo.Grado = int.Parse(txtGrado.Text);
            }
            else
            {
                Grupo nuevogrupo = new Grupo(txtProfesor.Text, int.Parse(txtGrado.Text));
                Globales.miEscuela.AgregaGrupo(nuevogrupo);
                Globales.miGrupo = nuevogrupo;
            }
            grpDatos.Enabled = false;
            btnGuardar.Enabled = false;
            btnNuevo.Enabled = true;
            btnAgregar.Enabled = true;
        }

        private void frmGrupos_Activated(object sender, EventArgs e)
        {
            if(Globales.miGrupo != null)
            {
                lvwAlumnos.BackColor = Color.Green;
                ListViewItem lsau;
                lvwAlumnos.Items.Clear();
                foreach (Alumno al in Globales.miGrupo.ObtenAlumnos())
                {
                    lsau = new ListViewItem(al.Nombre);
                    lsau.SubItems.Add(al.Edad.ToString());
                    lsau.SubItems.Add(al.DespliegaCalifs());
                    lsau.SubItems.Add(al.Promedio().ToString());
                    lvwAlumnos.Items.Add(lsau);
                }
                btnAgregar.Enabled = true;
            }
            else lvwAlumnos.BackColor = Color.Red;
        }

        private void lvwAlumnos_DoubleClick(object sender, EventArgs e)
        {
            int pos = lvwAlumnos.FocusedItem.Index;
            Globales.miAlumno = Globales.miGrupo.ObtenAlumnos()[pos];
            frmAlumno frm = new frmAlumno();
            frm.Show();
        }
    }
}
