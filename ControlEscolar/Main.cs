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
    public partial class Main : Form
    {
        public Main()
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

        private void lblEscuela_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void lblCrear_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                frmGrupos frm = new frmGrupos();
                frm.Show();
            }
        }
    }
}
