using LogicaNegocio;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class frmRegistroTratamientos : Form
    {
        private TratamientoBL tratamientoBL;
        public frmRegistroTratamientos()
        {
            InitializeComponent();
            tratamientoBL = new TratamientoBL();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Tratamiento trat = new Tratamiento();
            if (txtNombreTrat.Text.Trim() == "")
            {
                MessageBox.Show("Por favor ingrese un nombre", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            trat.NombreTrat = txtNombreTrat.Text.Trim();

            if (rbtnFacial.Checked == true)
                trat.TipoTrat = 1;
            else
                trat.TipoTrat = 0;

            try
            {
                trat.DuracionTrat = double.Parse(txtDuracion.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor ingrese correctamente la duracion en minutos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                trat.PrecioTrat = double.Parse(txtPrecio.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor ingrese correctamente el precio en soles", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (tratamientoBL.registrarTratamiento(trat) != 0)
            {
                MessageBox.Show("Se ha registrado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //estadoComponentes(Estado.Guardar);
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            
            this.DialogResult = DialogResult.OK;
           
        }

   
    }
}
