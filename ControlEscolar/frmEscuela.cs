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
    public partial class frmEscuela : Form
    {
        public frmEscuela()
        {
            InitializeComponent();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDe frm = new AcercaDe();
            frm.Show();
        }

        private void lblCrear_DoubleClick(object sender, EventArgs e)
        {
            frmDatosEscuela frm = new frmDatosEscuela();
            frm.Show();
        }

        private void lvwGrupos_DoubleClick(object sender, EventArgs e)
        {
            frmGrupos frm = new frmGrupos();
            frm.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }


        private void lblCrear_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (Globales.miEscuela == null
                )
                    MessageBox.Show("Debes Crear la escuela antes de agregar grupos");
                else
                {
                    Globales.miGrupo = null ;
                    frmGrupos frm = new frmGrupos();
                    frm.Show();
                }
            }
        }

        private void abrirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.Filter = "Archivos de Datos (.dat)|*.dat";
            openFileDialog1.FileName = "Selecciona Archivo";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string nombrearchivo = openFileDialog1.FileName;
                Globales.DesSerializar(nombrearchivo);
                frmEscuela_Activated(sender, e);
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globales.miEscuela == null)
            {
                MessageBox.Show("No hay datos que guardar, cree primero la escuela");
            }
            else
            {
                saveFileDialog1.InitialDirectory = Application.StartupPath;
                saveFileDialog1.Filter = "Archivos de Datos (.dat)|*.dat";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string nombrearchivo = saveFileDialog1.FileName;
                    Globales.Serializar(nombrearchivo);
                }
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void frmEscuela_Activated(object sender, EventArgs e)
        {
            if(Globales.miEscuela == null)
            {
                lblEscuela.Text = "Escuela No Creada" ;
            }
            else
            {
                lvwGrupos.Items.Clear();
                lblEscuela.Text = Globales.miEscuela.RegresaDatos();
                ListViewItem lstgpo;
                foreach (Grupo gpo in Globales.miEscuela.ObtenGrupos())
                {
                    lstgpo = new ListViewItem(gpo.NombreProfesor);
                    lstgpo.SubItems.Add(gpo.Grado.ToString());
                    lstgpo.SubItems.Add(gpo.ObtenAlumnos().Count.ToString());
                    lstgpo.SubItems.Add(gpo.MediaGeneral().ToString());
                    lvwGrupos.Items.Add(lstgpo);
                }
            }
        }

        private void label2_DoubleClick(object sender, EventArgs e)
        {
            int pos = lvwGrupos.FocusedItem.Index;
            Globales.miGrupo = Globales.miEscuela.ObtenGrupos()[pos];
            frmGrupos frm = new frmGrupos();
            frm.Show();
        }
    }
}
