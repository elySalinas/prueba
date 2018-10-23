using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class frmNuevaCita : Form
    {
        public frmNuevaCita()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarTratamiento_Click(object sender, EventArgs e)
        {
            frmAgregarTratamiento frmAgTrata = new frmAgregarTratamiento();
            frmAgTrata.ShowDialog();
        }

        private void btnAgregarPaquete_Click(object sender, EventArgs e)
        {
            frmAgregarPaquete frmPaquete = new frmAgregarPaquete();
            frmPaquete.ShowDialog();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha reservado satisfactoriamente la cita", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
