﻿namespace Formularios
{
    partial class frmModificarCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.lblCondMedicas = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.txtApMaterno = new System.Windows.Forms.TextBox();
            this.lblApMaterno = new System.Windows.Forms.Label();
            this.txtApPaterno = new System.Windows.Forms.TextBox();
            this.lblApPaterno = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNac.Location = new System.Drawing.Point(62, 332);
            this.lblFechaNac.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(183, 21);
            this.lblFechaNac.TabIndex = 44;
            this.lblFechaNac.Text = "Fecha de Nacimiento:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(62, 277);
            this.lblSexo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(50, 21);
            this.lblSexo.TabIndex = 42;
            this.lblSexo.Text = "Sexo:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Location = new System.Drawing.Point(432, 931);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(230, 61);
            this.btnCancelar.TabIndex = 41;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegistrar.Location = new System.Drawing.Point(72, 931);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(5);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(238, 61);
            this.btnRegistrar.TabIndex = 40;
            this.btnRegistrar.Text = "Guardar Cambios";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Rosácea",
            "Hernias",
            "Diabetes",
            "Embarazo"});
            this.checkedListBox1.Location = new System.Drawing.Point(169, 689);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(5);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(372, 92);
            this.checkedListBox1.TabIndex = 39;
            // 
            // lblCondMedicas
            // 
            this.lblCondMedicas.AutoSize = true;
            this.lblCondMedicas.Location = new System.Drawing.Point(62, 633);
            this.lblCondMedicas.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCondMedicas.Name = "lblCondMedicas";
            this.lblCondMedicas.Size = new System.Drawing.Size(378, 21);
            this.lblCondMedicas.TabIndex = 38;
            this.lblCondMedicas.Text = "Seleccione las Condiciones Médicas que posee:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(255, 498);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(5);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(424, 27);
            this.txtDireccion.TabIndex = 37;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(62, 498);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(87, 21);
            this.lblDireccion.TabIndex = 36;
            this.lblDireccion.Text = "Dirección:";
            this.lblDireccion.Click += new System.EventHandler(this.lblDireccion_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(255, 427);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(5);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(424, 27);
            this.txtTelefono.TabIndex = 35;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(62, 427);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(80, 21);
            this.lblTelefono.TabIndex = 34;
            this.lblTelefono.Text = "Teléfono:";
            this.lblTelefono.Click += new System.EventHandler(this.lblTelefono_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(255, 377);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(5);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(424, 27);
            this.txtCorreo.TabIndex = 33;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(63, 377);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(67, 21);
            this.lblEmail.TabIndex = 32;
            this.lblEmail.Text = "Correo:";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(255, 221);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(424, 27);
            this.txtNombre.TabIndex = 31;
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.Location = new System.Drawing.Point(63, 229);
            this.lblNombres.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(83, 21);
            this.lblNombres.TabIndex = 30;
            this.lblNombres.Text = "Nombres:";
            // 
            // txtApMaterno
            // 
            this.txtApMaterno.Location = new System.Drawing.Point(255, 184);
            this.txtApMaterno.Margin = new System.Windows.Forms.Padding(5);
            this.txtApMaterno.Name = "txtApMaterno";
            this.txtApMaterno.Size = new System.Drawing.Size(424, 27);
            this.txtApMaterno.TabIndex = 29;
            // 
            // lblApMaterno
            // 
            this.lblApMaterno.AutoSize = true;
            this.lblApMaterno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApMaterno.Location = new System.Drawing.Point(62, 186);
            this.lblApMaterno.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblApMaterno.Name = "lblApMaterno";
            this.lblApMaterno.Size = new System.Drawing.Size(150, 21);
            this.lblApMaterno.TabIndex = 28;
            this.lblApMaterno.Text = "Apellido Materno:";
            // 
            // txtApPaterno
            // 
            this.txtApPaterno.Location = new System.Drawing.Point(255, 141);
            this.txtApPaterno.Margin = new System.Windows.Forms.Padding(5);
            this.txtApPaterno.Name = "txtApPaterno";
            this.txtApPaterno.Size = new System.Drawing.Size(424, 27);
            this.txtApPaterno.TabIndex = 27;
            // 
            // lblApPaterno
            // 
            this.lblApPaterno.AutoSize = true;
            this.lblApPaterno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApPaterno.Location = new System.Drawing.Point(63, 147);
            this.lblApPaterno.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblApPaterno.Name = "lblApPaterno";
            this.lblApPaterno.Size = new System.Drawing.Size(144, 21);
            this.lblApPaterno.TabIndex = 26;
            this.lblApPaterno.Text = "Apellido Paterno:";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(255, 104);
            this.txtDni.Margin = new System.Windows.Forms.Padding(5);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(278, 27);
            this.txtDni.TabIndex = 25;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(63, 107);
            this.lblDni.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(43, 21);
            this.lblDni.TabIndex = 24;
            this.lblDni.Text = "DNI:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 84);
            this.panel1.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(291, 36);
            this.label4.TabIndex = 22;
            this.label4.Text = "MODIFICAR CLIENTE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 555);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 47;
            this.label1.Text = "Estado:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(169, 680);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 27);
            this.textBox1.TabIndex = 48;
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cboEstado.Location = new System.Drawing.Point(255, 555);
            this.cboEstado.Margin = new System.Windows.Forms.Padding(5);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(221, 29);
            this.cboEstado.TabIndex = 49;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(491, 847);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 36);
            this.button1.TabIndex = 51;
            this.button1.Text = "CANCELAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.Location = new System.Drawing.Point(87, 847);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(125, 36);
            this.btnGuardar.TabIndex = 50;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(408, 273);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(106, 25);
            this.rbMasculino.TabIndex = 53;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Location = new System.Drawing.Point(255, 273);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(104, 25);
            this.rbFemenino.TabIndex = 52;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Location = new System.Drawing.Point(255, 332);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(424, 27);
            this.dtpFechaNac.TabIndex = 54;
            // 
            // frmModificarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 927);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.rbMasculino);
            this.Controls.Add(this.rbFemenino);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblFechaNac);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.lblCondMedicas);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.txtApMaterno);
            this.Controls.Add(this.lblApMaterno);
            this.Controls.Add(this.txtApPaterno);
            this.Controls.Add(this.lblApPaterno);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lblDni);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmModificarCliente";
            this.Text = "Modificar Cliente";
            this.Load += new System.EventHandler(this.frmModificarCliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label lblCondMedicas;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.TextBox txtApMaterno;
        private System.Windows.Forms.Label lblApMaterno;
        private System.Windows.Forms.TextBox txtApPaterno;
        private System.Windows.Forms.Label lblApPaterno;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
    }
}