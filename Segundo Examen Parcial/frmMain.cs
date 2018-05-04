using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Segundo_Examen_Parcial
{
    public partial class frmMain : Form
    {
     

        public frmMain()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblRed_DoubleClick(object sender, EventArgs e)
        {
            frmDatosRed frm = new frmDatosRed();
            frm.Show();
        }

        private void lblRed_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (Globales.miRed == null)
                    MessageBox.Show("Debes Crear la Red antes de agregar Nodos");
                else
                {
                    Globales.miNodo = null;
                    frmNodos frm = new frmNodos();
                    frm.Show();
                }
            }
        }


        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void frmMain_Activated(object sender, EventArgs e)
        {
            if (Globales.miRed == null)
            {
                lblRed.Text = "Red No Creada";
            }
            else
            {
                lvwNodos.Items.Clear();
                lblRed.Text = Globales.miRed.RegresaDatos();
                ListViewItem lstgpo;
                foreach (Nodo nodo in Globales.miRed.ObtenNodos())
                {
                    lstgpo = new ListViewItem(nodo.Ip.ToString());
                    lstgpo.SubItems.Add(nodo.Tipo);
                    lstgpo.SubItems.Add(nodo.PAbiertos.ToString());
                    lstgpo.SubItems.Add(nodo.SObjetivo.ToString());
                    lstgpo.SubItems.Add(nodo.So);
                    lvwNodos.Items.Add(lstgpo);
                }
            }
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDe frm = new AcercaDe();
            frm.Show();
        }

        private void lvwNodos_DoubleClick(object sender, EventArgs e)
        {
            int pos = lvwNodos.FocusedItem.Index;
            Globales.miNodo = Globales.miRed.ObtenNodos()[pos];
            frmNodos frm = new frmNodos();
            frm.Show();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.Filter = "Archivos de Datos (.dat)|*.dat";
            openFileDialog1.FileName = "Selecciona Archivo";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string nombrearchivo = openFileDialog1.FileName;
                Globales.DesSerializar(nombrearchivo);
                frmMain_Activated(sender, e);
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globales.miRed == null)
            {
                MessageBox.Show("No hay datos que guardar, cree primero la red");
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
    }
}
