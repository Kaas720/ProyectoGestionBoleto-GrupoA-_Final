// ***********************************************************************
// Assembly         : Presentacion
// Author           : USUARIO
// Created          : 02-20-2022
//
// Last Modified By : USUARIO
// Last Modified On : 02-20-2022
// ***********************************************************************
// <copyright file="RegistrarClienteporAdmin.Designer.cs" company="">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Presentacion.SGA_Administrador
{
    /// <summary>
    /// Class RegistrarClienteporAdmin.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class RegistrarClienteporAdmin
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
            this.components = new System.ComponentModel.Container();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.txtContraseña = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCorreo = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbSexo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtTelefono = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCedula = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoRoundedCorners = true;
            this.btnGuardar.BorderRadius = 21;
            this.btnGuardar.CheckedState.Parent = this.btnGuardar;
            this.btnGuardar.CustomImages.Parent = this.btnGuardar;
            this.btnGuardar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGuardar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGuardar.DisabledState.Parent = this.btnGuardar;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.HoverState.Parent = this.btnGuardar;
            this.btnGuardar.Location = new System.Drawing.Point(264, 336);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.ShadowDecoration.Parent = this.btnGuardar;
            this.btnGuardar.Size = new System.Drawing.Size(144, 45);
            this.btnGuardar.TabIndex = 48;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.AutoRoundedCorners = true;
            this.txtContraseña.BackColor = System.Drawing.Color.Transparent;
            this.txtContraseña.BorderRadius = 12;
            this.txtContraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContraseña.DefaultText = "";
            this.txtContraseña.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtContraseña.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtContraseña.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContraseña.DisabledState.Parent = this.txtContraseña;
            this.txtContraseña.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContraseña.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContraseña.FocusedState.Parent = this.txtContraseña;
            this.txtContraseña.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtContraseña.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContraseña.HoverState.Parent = this.txtContraseña;
            this.txtContraseña.Location = new System.Drawing.Point(434, 150);
            this.txtContraseña.MaxLength = 9;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.PlaceholderText = "Ingresar la contraseña del cliente";
            this.txtContraseña.SelectedText = "";
            this.txtContraseña.ShadowDecoration.Parent = this.txtContraseña;
            this.txtContraseña.Size = new System.Drawing.Size(227, 27);
            this.txtContraseña.TabIndex = 47;
            // 
            // txtCorreo
            // 
            this.txtCorreo.AutoRoundedCorners = true;
            this.txtCorreo.BackColor = System.Drawing.Color.Transparent;
            this.txtCorreo.BorderRadius = 12;
            this.txtCorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCorreo.DefaultText = "";
            this.txtCorreo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCorreo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCorreo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCorreo.DisabledState.Parent = this.txtCorreo;
            this.txtCorreo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCorreo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCorreo.FocusedState.Parent = this.txtCorreo;
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCorreo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCorreo.HoverState.Parent = this.txtCorreo;
            this.txtCorreo.Location = new System.Drawing.Point(434, 61);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.PasswordChar = '\0';
            this.txtCorreo.PlaceholderText = "Ingresar el correo del cliente";
            this.txtCorreo.SelectedText = "";
            this.txtCorreo.ShadowDecoration.Parent = this.txtCorreo;
            this.txtCorreo.Size = new System.Drawing.Size(227, 27);
            this.txtCorreo.TabIndex = 46;
            // 
            // cmbSexo
            // 
            this.cmbSexo.AutoRoundedCorners = true;
            this.cmbSexo.BackColor = System.Drawing.Color.Transparent;
            this.cmbSexo.BorderRadius = 17;
            this.cmbSexo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSexo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSexo.FocusedState.Parent = this.cmbSexo;
            this.cmbSexo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbSexo.HoverState.Parent = this.cmbSexo;
            this.cmbSexo.ItemHeight = 30;
            this.cmbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbSexo.ItemsAppearance.Parent = this.cmbSexo;
            this.cmbSexo.Location = new System.Drawing.Point(95, 237);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.ShadowDecoration.Parent = this.cmbSexo;
            this.cmbSexo.Size = new System.Drawing.Size(227, 36);
            this.cmbSexo.TabIndex = 45;
            // 
            // txtTelefono
            // 
            this.txtTelefono.AutoRoundedCorners = true;
            this.txtTelefono.BackColor = System.Drawing.Color.Transparent;
            this.txtTelefono.BorderRadius = 12;
            this.txtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefono.DefaultText = "";
            this.txtTelefono.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTelefono.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTelefono.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelefono.DisabledState.Parent = this.txtTelefono;
            this.txtTelefono.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelefono.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelefono.FocusedState.Parent = this.txtTelefono;
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTelefono.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelefono.HoverState.Parent = this.txtTelefono;
            this.txtTelefono.Location = new System.Drawing.Point(434, 246);
            this.txtTelefono.MaxLength = 10;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.PlaceholderText = "Ingresar el télefono del cliente";
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.ShadowDecoration.Parent = this.txtTelefono;
            this.txtTelefono.Size = new System.Drawing.Size(227, 27);
            this.txtTelefono.TabIndex = 44;
            // 
            // txtNombre
            // 
            this.txtNombre.AutoRoundedCorners = true;
            this.txtNombre.BackColor = System.Drawing.Color.Transparent;
            this.txtNombre.BorderRadius = 12;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.DefaultText = "";
            this.txtNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombre.DisabledState.Parent = this.txtNombre;
            this.txtNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombre.FocusedState.Parent = this.txtNombre;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombre.HoverState.Parent = this.txtNombre;
            this.txtNombre.Location = new System.Drawing.Point(95, 150);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.PlaceholderText = "Ingresar el nombre del cliente";
            this.txtNombre.SelectedText = "";
            this.txtNombre.ShadowDecoration.Parent = this.txtNombre;
            this.txtNombre.Size = new System.Drawing.Size(227, 27);
            this.txtNombre.TabIndex = 43;
            // 
            // txtCedula
            // 
            this.txtCedula.AutoRoundedCorners = true;
            this.txtCedula.BackColor = System.Drawing.Color.Transparent;
            this.txtCedula.BorderRadius = 12;
            this.txtCedula.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCedula.DefaultText = "";
            this.txtCedula.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCedula.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCedula.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCedula.DisabledState.Parent = this.txtCedula;
            this.txtCedula.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCedula.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCedula.FocusedState.Parent = this.txtCedula;
            this.txtCedula.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCedula.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCedula.HoverState.Parent = this.txtCedula;
            this.txtCedula.Location = new System.Drawing.Point(95, 61);
            this.txtCedula.MaxLength = 10;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.PasswordChar = '\0';
            this.txtCedula.PlaceholderText = "Ingresar la cédula del cliente";
            this.txtCedula.SelectedText = "";
            this.txtCedula.ShadowDecoration.Parent = this.txtCedula;
            this.txtCedula.Size = new System.Drawing.Size(227, 27);
            this.txtCedula.TabIndex = 42;
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(343, 150);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(84, 24);
            this.guna2HtmlLabel8.TabIndex = 41;
            this.guna2HtmlLabel8.Text = "Contraseña:";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(343, 64);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(53, 24);
            this.guna2HtmlLabel5.TabIndex = 40;
            this.guna2HtmlLabel5.Text = "Correo:";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(343, 249);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(64, 24);
            this.guna2HtmlLabel4.TabIndex = 39;
            this.guna2HtmlLabel4.Text = "Telefono:";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(25, 249);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(39, 24);
            this.guna2HtmlLabel3.TabIndex = 38;
            this.guna2HtmlLabel3.Text = "Sexo:";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(25, 150);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(64, 24);
            this.guna2HtmlLabel2.TabIndex = 37;
            this.guna2HtmlLabel2.Text = "Nombre:";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(25, 64);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(55, 24);
            this.guna2HtmlLabel1.TabIndex = 36;
            this.guna2HtmlLabel1.Text = "Cedula:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // RegistrarClienteporAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(675, 433);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.guna2HtmlLabel8);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarClienteporAdmin";
            this.Opacity = 0.9D;
            this.Text = "RegistrarClienteporAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /// <summary>
        /// The BTN guardar
        /// </summary>
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        /// <summary>
        /// The text contraseña
        /// </summary>
        private Guna.UI2.WinForms.Guna2TextBox txtContraseña;
        /// <summary>
        /// The text correo
        /// </summary>
        private Guna.UI2.WinForms.Guna2TextBox txtCorreo;
        /// <summary>
        /// The CMB sexo
        /// </summary>
        private Guna.UI2.WinForms.Guna2ComboBox cmbSexo;
        /// <summary>
        /// The text telefono
        /// </summary>
        private Guna.UI2.WinForms.Guna2TextBox txtTelefono;
        /// <summary>
        /// The text nombre
        /// </summary>
        private Guna.UI2.WinForms.Guna2TextBox txtNombre;
        /// <summary>
        /// The text cedula
        /// </summary>
        private Guna.UI2.WinForms.Guna2TextBox txtCedula;
        /// <summary>
        /// The guna2 HTML label8
        /// </summary>
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        /// <summary>
        /// The guna2 HTML label5
        /// </summary>
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        /// <summary>
        /// The guna2 HTML label4
        /// </summary>
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        /// <summary>
        /// The guna2 HTML label3
        /// </summary>
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        /// <summary>
        /// The guna2 HTML label2
        /// </summary>
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        /// <summary>
        /// The guna2 HTML label1
        /// </summary>
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        /// <summary>
        /// The error provider1
        /// </summary>
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}