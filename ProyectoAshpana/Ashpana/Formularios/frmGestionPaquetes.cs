﻿using LogicaNegocio;
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
    public partial class frmGestionPaquetes : Form
    {
        private Paquete paquete;
        private PaqueteBL paqueteBL;
        private BindingList<Paquete> paquetes;

        public Paquete Paquete { get => paquete; set => paquete = value; }


        public frmGestionPaquetes()
        {
            InitializeComponent();
            dgvPaquetes.AutoGenerateColumns = false;
            paqueteBL = new PaqueteBL();
            CargarDGV();
        }
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {

            Paquete = (Paquete)dgvPaquetes.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvPaquetes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un Paquete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            paquete = new Paquete();
            paquete = (Paquete)dgvPaquetes.CurrentRow.DataBoundItem;

            frmPaquetesModificar fb = new frmPaquetesModificar(paquete);
            if (fb.ShowDialog() == DialogResult.OK)
            {
                CargarDGV();
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmPaquetesCrear fb = new frmPaquetesCrear();
            if (fb.ShowDialog() == DialogResult.OK)
            {
            }
            CargarDGV();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnSeleccionar_Click_1(object sender, EventArgs e)
        {

        }
        

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvPaquetes.DataSource = paqueteBL.BuscarPaquete(txtboxBuscarPaquetes.Text);
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dgvPaquetes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un Paquete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            paquete = new Paquete();
            paquete = (Paquete)dgvPaquetes.CurrentRow.DataBoundItem;

            paqueteBL.eliminar(paquete);

            MessageBox.Show("Paquete eliminado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarDGV();
        }
    }
}
