using LogicaNegocio;
using Modelo;
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
    public partial class frmPaquetesCrear : Form
    {
        private PaqueteBL paquetesBL;
        public frmPaquetesCrear()
        {
            InitializeComponent();
            paquetesBL = new PaqueteBL();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                String nombre = txtNombre.Text;
                double precio = Double.Parse(txtPrecio.Text);
                int numSesiones = Int32.Parse(txtNumSesiones.Text);


                Paquete paquete = new Paquete(0, nombre, precio, numSesiones);

                if (paquete.Precio <= 0 || paquete.CantSesion <= 0)
                {
                    MessageBox.Show("Ingrese Numeros válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //BindingList<Tratamiento> tratamientos = new BindingList<Tratamiento>();
                //tratamientos.Add(t);

                paquetesBL.RegistrarPaquete(paquete); //,tratamientos);

                MessageBox.Show("Se ha registrado el paquete correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Ha ocurrido un error en la base de datos", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }
    }
}
