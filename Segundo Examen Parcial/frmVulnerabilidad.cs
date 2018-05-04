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
    public partial class frmVulnerabilidad : Form
    {
        public frmVulnerabilidad()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            grpDatos.Enabled = true;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            txtClave.Clear();
            txtVendedor.Clear();
            txtDesc.Clear();
            txtClave.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (Globales.miVul != null)
            {
                Globales.miVul.Clave = txtClave.Text;
                Globales.miVul.Vendedor = txtVendedor.Text;
                Globales.miVul.Descripcion = txtDesc.Text;
                Globales.miVul.Tipo = cboTipo.SelectedItem.ToString();
                Globales.miVul.Fecha = DateTime.Parse(dtpFecha.Text);
            }
            else
            {
                Vulnerabilidad nuevaVul = new Vulnerabilidad(
                        txtClave.Text,
                        txtVendedor.Text,
                        txtDesc.Text, 
                        cboTipo.SelectedItem.ToString(),
                        DateTime.Parse(dtpFecha.Text)
                        );
               
                Globales.miNodo.agregarVulnerabilidad(nuevaVul);
                Globales.miVul = nuevaVul;
            }
            grpDatos.Enabled = false;
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            txtClave.Focus();
        }

        private void frmVulnerabilidad_Load(object sender, EventArgs e)
        {
            grpDatos.Enabled = false;
            btnGuardar.Enabled = false;
        }

        private void frmVulnerabilidad_Activated(object sender, EventArgs e)
        {
            if (Globales.miVul != null)
            {
                txtClave.Text = Globales.miVul.Clave;
                txtVendedor.Text = Globales.miVul.Vendedor;
                txtDesc.Text = Globales.miVul.Descripcion;
                cboTipo.SelectedItem = Globales.miVul.Tipo;
                dtpFecha.Text = Globales.miVul.Fecha.ToString();
                btnNuevo.Enabled = false;
                grpDatos.Enabled = true;
                btnGuardar.Enabled = true;
            }
        }
    }
}
