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
    public partial class frmDatosRed : Form
    {
        public frmDatosRed()
        {
            InitializeComponent();
        }

        private void btnCrearRed_Click(object sender, EventArgs e)
        {
            if (Globales.miRed == null)
                Globales.miRed = new Red();

            Globales.miRed.Empresa = txtEmpresa.Text;
            Globales.miRed.Propietario = txtPropietario.Text;
            Globales.miRed.Domicilio = txtDomicilio.Text;
           
            this.Close();
        }

        private void frmDatosRed_Load(object sender, EventArgs e)
        {
            if (Globales.miRed != null)
            {
                txtEmpresa.Text = Globales.miRed.Empresa;
                txtPropietario.Text = Globales.miRed.Propietario;
                txtDomicilio.Text = Globales.miRed.Domicilio;
            }
        }
    }
}
