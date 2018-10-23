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
    public partial class frmNuevoCliente : Form
    {
        private Cliente clienteNuevo;

        public Cliente ClienteNuevo { get => clienteNuevo; set => clienteNuevo = value; }

        public frmNuevoCliente()
        {
            InitializeComponent();
            clienteNuevo = new Cliente();
        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Cliente t = new Cliente();
            t.Dni = txtDni.Text;
            t.Nombres = txtNombre.Text;
            t.ApPaterno = txtApPaterno.Text;
            t.ApMaterno = txtApMaterno.Text;
            if (rbMasculino.Checked == true)
                t.Sexo = 'M';
            else if (rbFemenino.Checked == true)
                t.Sexo = 'F';
            t.FechaNac = dtpFechaNac.Value;
            t.Correo = txtEmail.Text;
            t.Telefono = txtTelefono.Text;
            t.Direccion = txtDireccion.Text;
            
            ClienteBL clienteBL = new ClienteBL();
            clienteBL.registrarCliente(t);
            this.DialogResult = DialogResult.OK;
            MessageBox.Show("Se ha registrado con exito.",
                "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmGestionPacientes fc = new frmGestionPacientes();
            fc.ShowDialog();
        }

        private void frmNuevoCliente_Load(object sender, EventArgs e)
        {

        }

        private void lblDni_Click(object sender, EventArgs e)
        {

        }

        private void lblApPaterno_Click(object sender, EventArgs e)
        {

        }

        private void lblApMaterno_Click(object sender, EventArgs e)
        {

        }

        private void lblNombres_Click(object sender, EventArgs e)
        {

        }

        private void lblSexo_Click(object sender, EventArgs e)
        {

        }

        private void lblFechaNac_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblNuevoCliente_Click(object sender, EventArgs e)
        {

        }

        private void lblTelefono_Click(object sender, EventArgs e)
        {

        }

        private void lblDireccion_Click(object sender, EventArgs e)
        {

        }

        private void lblCondMedicas_Click(object sender, EventArgs e)
        {

        }
    }
}
