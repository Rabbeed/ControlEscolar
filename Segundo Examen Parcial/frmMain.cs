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
           /* if (e.Button == MouseButtons.Right)
            {
                if (Globales.miEscuela == null)
                    MessageBox.Show("Debes Crear la escuela antes de agregar grupos");
                else
                {
                    Globales.miGrupo = null;
                    frmGrupos frm = new frmGrupos();
                    frm.Show();
                }
            }*/
        }
    }
}
