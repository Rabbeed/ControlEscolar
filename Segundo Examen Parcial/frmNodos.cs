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
    public partial class frmNodos : Form
    {
        public frmNodos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Globales.miVul = null;
            frmVulnerabilidad al = new frmVulnerabilidad();
            al.Show();
        }

   

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            grpDatos.Enabled = true;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            txtIP.Clear();
            txtPuertosA.Clear();
            txtSaltosO.Clear();
            txtIP.Focus();
            Globales.miNodo = null;
        }

        private void frmNodos_Load(object sender, EventArgs e)
        {
            if (Globales.miNodo != null)
            {
                txtIP.Text = Globales.miNodo.Ip;
                cboTipo.SelectedItem = Globales.miNodo.Tipo;
                txtPuertosA.Text = Globales.miNodo.PAbiertos.ToString();
                txtSaltosO.Text = Globales.miNodo.SObjetivo.ToString();
                cboSO.SelectedItem = Globales.miNodo.So;
              
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
            if (Globales.miNodo != null)
            {
                Globales.miNodo.Ip = txtIP.Text;
                Globales.miNodo.Tipo = cboTipo.SelectedItem.ToString();
                Globales.miNodo.PAbiertos = int.Parse(txtPuertosA.Text);
                Globales.miNodo.SObjetivo = int.Parse(txtSaltosO.Text);
                Globales.miNodo.So = cboSO.SelectedItem.ToString();
            }
            else
            {
                Nodo nuevonodo = new Nodo(
                    txtIP.Text,
                    cboTipo.SelectedItem.ToString(),
                    int.Parse(txtPuertosA.Text),
                    int.Parse(txtSaltosO.Text),
                    cboSO.SelectedItem.ToString()
                    );
                Globales.miRed.AgregarNodo(nuevonodo);
                Globales.miNodo = nuevonodo;
            }
            grpDatos.Enabled = false;
            btnGuardar.Enabled = false;
            btnNuevo.Enabled = true;
            btnAgregar.Enabled = true;
        }

        private void frmNodos_Activated(object sender, EventArgs e)
        {
            if (Globales.miNodo != null)
            {
                lvwVuln.BackColor = Color.Green;
                ListViewItem lsau;
                lvwVuln.Items.Clear();
                foreach (Vulnerabilidad vul in Globales.miNodo.obtenVulnerabilidades())
                {
                    lsau = new ListViewItem(vul.Clave);
                    lsau.SubItems.Add(vul.Vendedor);
                    lsau.SubItems.Add(vul.Descripcion);
                    lsau.SubItems.Add(vul.Tipo);
                    lsau.SubItems.Add(vul.Fecha.ToString());
                    lvwVuln.Items.Add(lsau);
                }
                btnAgregar.Enabled = true;
            }
            else lvwVuln.BackColor = Color.Red;
        }

        private void lvwVuln_DoubleClick(object sender, EventArgs e)
        {
            int pos = lvwVuln.FocusedItem.Index;
            Globales.miVul = Globales.miNodo.obtenVulnerabilidades()[pos];
            frmVulnerabilidad frm = new frmVulnerabilidad();
            frm.Show();
        }
    }
}
