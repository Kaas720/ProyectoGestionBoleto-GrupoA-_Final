// ***********************************************************************
// Assembly         : Presentacion
// Author           : USUARIO
// Created          : 02-20-2022
//
// Last Modified By : USUARIO
// Last Modified On : 02-20-2022
// ***********************************************************************
// <copyright file="RegistroChofer.Designer.cs" company="">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Presentacion
{
    /// <summary>
    /// Class RegistroChofer.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class RegistroChofer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtCedula = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTelefono = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbSexo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtCorreo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtContraseña = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvCliente = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtSueldo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLicencia = new Guna.UI2.WinForms.Guna2TextBox();
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.BotonRetroceder = new FontAwesome.Sharp.IconButton();
            this.Fecha_Sistema = new System.Windows.Forms.Label();
            this.BotonParaMinimizarVentana = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Hora_Sistema = new System.Windows.Forms.Label();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.FechaHora = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.PanelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BotonParaMinimizarVentana)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(28, 86);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(55, 24);
            this.guna2HtmlLabel1.TabIndex = 18;
            this.guna2HtmlLabel1.Text = "Cedula:";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(28, 152);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(64, 24);
            this.guna2HtmlLabel2.TabIndex = 19;
            this.guna2HtmlLabel2.Text = "Nombre:";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(28, 219);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(39, 24);
            this.guna2HtmlLabel3.TabIndex = 20;
            this.guna2HtmlLabel3.Text = "Sexo:";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(361, 222);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(64, 24);
            this.guna2HtmlLabel4.TabIndex = 21;
            this.guna2HtmlLabel4.Text = "Telefono:";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(361, 86);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(53, 24);
            this.guna2HtmlLabel5.TabIndex = 22;
            this.guna2HtmlLabel5.Text = "Correo:";
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(361, 158);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(84, 24);
            this.guna2HtmlLabel8.TabIndex = 25;
            this.guna2HtmlLabel8.Text = "Contraseña:";
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
            this.txtCedula.Location = new System.Drawing.Point(114, 86);
            this.txtCedula.MaxLength = 10;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.PasswordChar = '\0';
            this.txtCedula.PlaceholderText = "";
            this.txtCedula.SelectedText = "";
            this.txtCedula.ShadowDecoration.Parent = this.txtCedula;
            this.txtCedula.Size = new System.Drawing.Size(227, 27);
            this.txtCedula.TabIndex = 26;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
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
            this.txtNombre.Location = new System.Drawing.Point(114, 152);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.PlaceholderText = "";
            this.txtNombre.SelectedText = "";
            this.txtNombre.ShadowDecoration.Parent = this.txtNombre;
            this.txtNombre.Size = new System.Drawing.Size(227, 27);
            this.txtNombre.TabIndex = 27;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
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
            this.txtTelefono.Location = new System.Drawing.Point(461, 219);
            this.txtTelefono.MaxLength = 10;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.PlaceholderText = "";
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.ShadowDecoration.Parent = this.txtTelefono;
            this.txtTelefono.Size = new System.Drawing.Size(227, 27);
            this.txtTelefono.TabIndex = 28;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
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
            this.cmbSexo.Location = new System.Drawing.Point(114, 214);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.ShadowDecoration.Parent = this.cmbSexo;
            this.cmbSexo.Size = new System.Drawing.Size(227, 36);
            this.cmbSexo.TabIndex = 29;
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
            this.txtCorreo.Location = new System.Drawing.Point(461, 86);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.PasswordChar = '\0';
            this.txtCorreo.PlaceholderText = "";
            this.txtCorreo.SelectedText = "";
            this.txtCorreo.ShadowDecoration.Parent = this.txtCorreo;
            this.txtCorreo.Size = new System.Drawing.Size(227, 27);
            this.txtCorreo.TabIndex = 30;
            this.txtCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCorreo_KeyPress);
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
            this.txtContraseña.Location = new System.Drawing.Point(461, 155);
            this.txtContraseña.MaxLength = 9;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.PlaceholderText = "";
            this.txtContraseña.SelectedText = "";
            this.txtContraseña.ShadowDecoration.Parent = this.txtContraseña;
            this.txtContraseña.Size = new System.Drawing.Size(227, 27);
            this.txtContraseña.TabIndex = 33;
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvCliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCliente.BackgroundColor = System.Drawing.Color.White;
            this.dgvCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCliente.ColumnHeadersHeight = 21;
            this.dgvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cedula,
            this.Nombre,
            this.Sexo,
            this.Telefono,
            this.Correo,
            this.Ciudad,
            this.Usuario,
            this.Contraseña});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCliente.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCliente.EnableHeadersVisualStyles = false;
            this.dgvCliente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCliente.Location = new System.Drawing.Point(12, 389);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.RowHeadersVisible = false;
            this.dgvCliente.RowHeadersWidth = 62;
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(879, 46);
            this.dgvCliente.TabIndex = 34;
            this.dgvCliente.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCliente.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCliente.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCliente.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCliente.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCliente.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCliente.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCliente.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvCliente.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCliente.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvCliente.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCliente.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCliente.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvCliente.ThemeStyle.ReadOnly = true;
            this.dgvCliente.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCliente.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCliente.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvCliente.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCliente.ThemeStyle.RowsStyle.Height = 22;
            this.dgvCliente.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCliente.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Cedula
            // 
            this.Cedula.HeaderText = "Cedula";
            this.Cedula.MaxInputLength = 10;
            this.Cedula.MinimumWidth = 8;
            this.Cedula.Name = "Cedula";
            this.Cedula.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MaxInputLength = 60;
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.MaxInputLength = 30;
            this.Sexo.MinimumWidth = 8;
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MaxInputLength = 10;
            this.Telefono.MinimumWidth = 8;
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.MaxInputLength = 20;
            this.Correo.MinimumWidth = 8;
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // Ciudad
            // 
            this.Ciudad.HeaderText = "Ciudad";
            this.Ciudad.MaxInputLength = 20;
            this.Ciudad.MinimumWidth = 8;
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.ReadOnly = true;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.MaxInputLength = 20;
            this.Usuario.MinimumWidth = 8;
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            // 
            // Contraseña
            // 
            this.Contraseña.HeaderText = "Contraseña";
            this.Contraseña.MaxInputLength = 20;
            this.Contraseña.MinimumWidth = 8;
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.ReadOnly = true;
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
            this.btnGuardar.Location = new System.Drawing.Point(301, 327);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.ShadowDecoration.Parent = this.btnGuardar;
            this.btnGuardar.Size = new System.Drawing.Size(144, 45);
            this.btnGuardar.TabIndex = 35;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(28, 278);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(53, 24);
            this.guna2HtmlLabel6.TabIndex = 36;
            this.guna2HtmlLabel6.Text = "Sueldo:";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(361, 278);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(63, 24);
            this.guna2HtmlLabel7.TabIndex = 37;
            this.guna2HtmlLabel7.Text = "Licencia:";
            // 
            // txtSueldo
            // 
            this.txtSueldo.AutoRoundedCorners = true;
            this.txtSueldo.BackColor = System.Drawing.Color.Transparent;
            this.txtSueldo.BorderRadius = 12;
            this.txtSueldo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSueldo.DefaultText = "";
            this.txtSueldo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSueldo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSueldo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSueldo.DisabledState.Parent = this.txtSueldo;
            this.txtSueldo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSueldo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSueldo.FocusedState.Parent = this.txtSueldo;
            this.txtSueldo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSueldo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSueldo.HoverState.Parent = this.txtSueldo;
            this.txtSueldo.Location = new System.Drawing.Point(114, 278);
            this.txtSueldo.MaxLength = 100000;
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.PasswordChar = '\0';
            this.txtSueldo.PlaceholderText = "";
            this.txtSueldo.SelectedText = "";
            this.txtSueldo.ShadowDecoration.Parent = this.txtSueldo;
            this.txtSueldo.Size = new System.Drawing.Size(227, 27);
            this.txtSueldo.TabIndex = 38;
            this.txtSueldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSueldo_KeyPress);
            // 
            // txtLicencia
            // 
            this.txtLicencia.AutoRoundedCorners = true;
            this.txtLicencia.BackColor = System.Drawing.Color.Transparent;
            this.txtLicencia.BorderRadius = 12;
            this.txtLicencia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLicencia.DefaultText = "";
            this.txtLicencia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLicencia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLicencia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLicencia.DisabledState.Parent = this.txtLicencia;
            this.txtLicencia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLicencia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLicencia.FocusedState.Parent = this.txtLicencia;
            this.txtLicencia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLicencia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLicencia.HoverState.Parent = this.txtLicencia;
            this.txtLicencia.Location = new System.Drawing.Point(461, 278);
            this.txtLicencia.MaxLength = 10;
            this.txtLicencia.Name = "txtLicencia";
            this.txtLicencia.PasswordChar = '\0';
            this.txtLicencia.PlaceholderText = "";
            this.txtLicencia.SelectedText = "";
            this.txtLicencia.ShadowDecoration.Parent = this.txtLicencia;
            this.txtLicencia.Size = new System.Drawing.Size(227, 27);
            this.txtLicencia.TabIndex = 39;
            this.txtLicencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLicencia_KeyPress);
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.PanelSuperior.Controls.Add(this.BotonRetroceder);
            this.PanelSuperior.Controls.Add(this.Fecha_Sistema);
            this.PanelSuperior.Controls.Add(this.BotonParaMinimizarVentana);
            this.PanelSuperior.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.PanelSuperior.Location = new System.Drawing.Point(0, 1);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(720, 35);
            this.PanelSuperior.TabIndex = 40;
            // 
            // BotonRetroceder
            // 
            this.BotonRetroceder.BackColor = System.Drawing.Color.Transparent;
            this.BotonRetroceder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonRetroceder.FlatAppearance.BorderSize = 0;
            this.BotonRetroceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BotonRetroceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BotonRetroceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonRetroceder.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            this.BotonRetroceder.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BotonRetroceder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BotonRetroceder.IconSize = 37;
            this.BotonRetroceder.Location = new System.Drawing.Point(3, 4);
            this.BotonRetroceder.Name = "BotonRetroceder";
            this.BotonRetroceder.Size = new System.Drawing.Size(59, 31);
            this.BotonRetroceder.TabIndex = 39;
            this.BotonRetroceder.UseVisualStyleBackColor = false;
            this.BotonRetroceder.Click += new System.EventHandler(this.BotonRetroceder_Click);
            // 
            // Fecha_Sistema
            // 
            this.Fecha_Sistema.AutoSize = true;
            this.Fecha_Sistema.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.Fecha_Sistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha_Sistema.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Fecha_Sistema.Location = new System.Drawing.Point(372, 11);
            this.Fecha_Sistema.Name = "Fecha_Sistema";
            this.Fecha_Sistema.Size = new System.Drawing.Size(60, 20);
            this.Fecha_Sistema.TabIndex = 2;
            this.Fecha_Sistema.Text = "LABEL";
            this.Fecha_Sistema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BotonParaMinimizarVentana
            // 
            this.BotonParaMinimizarVentana.BackColor = System.Drawing.Color.Transparent;
            this.BotonParaMinimizarVentana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonParaMinimizarVentana.ForeColor = System.Drawing.Color.Yellow;
            this.BotonParaMinimizarVentana.IconChar = FontAwesome.Sharp.IconChar.MinusSquare;
            this.BotonParaMinimizarVentana.IconColor = System.Drawing.Color.Yellow;
            this.BotonParaMinimizarVentana.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BotonParaMinimizarVentana.IconSize = 34;
            this.BotonParaMinimizarVentana.Location = new System.Drawing.Point(672, 4);
            this.BotonParaMinimizarVentana.Name = "BotonParaMinimizarVentana";
            this.BotonParaMinimizarVentana.Size = new System.Drawing.Size(39, 34);
            this.BotonParaMinimizarVentana.TabIndex = 1;
            this.BotonParaMinimizarVentana.TabStop = false;
            this.BotonParaMinimizarVentana.Click += new System.EventHandler(this.BotonParaMinimizarVentana_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.guna2PictureBox1);
            this.panel1.Controls.Add(this.Hora_Sistema);
            this.panel1.Controls.Add(this.guna2HtmlLabel9);
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 42);
            this.panel1.TabIndex = 41;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Presentacion.Properties.Resources.pngtree_blue_big_car_illustration_cartoon_shuttle_blue_bus_gray_glass_png_image_4543101;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(17, 5);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(66, 37);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            // 
            // Hora_Sistema
            // 
            this.Hora_Sistema.AutoSize = true;
            this.Hora_Sistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hora_Sistema.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Hora_Sistema.Location = new System.Drawing.Point(630, 13);
            this.Hora_Sistema.Name = "Hora_Sistema";
            this.Hora_Sistema.Size = new System.Drawing.Size(80, 24);
            this.Hora_Sistema.TabIndex = 1;
            this.Hora_Sistema.Text = "17:51:10";
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.guna2HtmlLabel9.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(89, 13);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(304, 20);
            this.guna2HtmlLabel9.TabIndex = 5;
            this.guna2HtmlLabel9.Text = "Sistema de Gestion de Boletos de AutoBuses";
            // 
            // FechaHora
            // 
            this.FechaHora.Enabled = true;
            this.FechaHora.Tick += new System.EventHandler(this.FechaHora_Tick);
            // 
            // RegistroChofer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Presentacion.Properties.Resources.salvapantallas_textura_elegante_blanco_23_2148421855;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(718, 386);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelSuperior);
            this.Controls.Add(this.txtLicencia);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.guna2HtmlLabel7);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvCliente);
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
            this.Name = "RegistroChofer";
            this.Text = "RegistroCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.PanelSuperior.ResumeLayout(false);
            this.PanelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BotonParaMinimizarVentana)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        /// The text contraseña
        /// </summary>
        private Guna.UI2.WinForms.Guna2TextBox txtContraseña;
        /// <summary>
        /// The text correo
        /// </summary>
        private Guna.UI2.WinForms.Guna2TextBox txtCorreo;
        /// <summary>
        /// The DGV cliente
        /// </summary>
        private Guna.UI2.WinForms.Guna2DataGridView dgvCliente;
        /// <summary>
        /// The cedula
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        /// <summary>
        /// The nombre
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        /// <summary>
        /// The sexo
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        /// <summary>
        /// The telefono
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        /// <summary>
        /// The correo
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        /// <summary>
        /// The ciudad
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        /// <summary>
        /// The usuario
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        /// <summary>
        /// The contraseña
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn Contraseña;
        /// <summary>
        /// The BTN guardar
        /// </summary>
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        /// <summary>
        /// The error provider1
        /// </summary>
        private System.Windows.Forms.ErrorProvider errorProvider1;
        /// <summary>
        /// The guna2 HTML label6
        /// </summary>
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        /// <summary>
        /// The text licencia
        /// </summary>
        private Guna.UI2.WinForms.Guna2TextBox txtLicencia;
        /// <summary>
        /// The text sueldo
        /// </summary>
        private Guna.UI2.WinForms.Guna2TextBox txtSueldo;
        /// <summary>
        /// The guna2 HTML label7
        /// </summary>
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        /// <summary>
        /// The panel superior
        /// </summary>
        private System.Windows.Forms.Panel PanelSuperior;
        /// <summary>
        /// The boton retroceder
        /// </summary>
        private FontAwesome.Sharp.IconButton BotonRetroceder;
        /// <summary>
        /// The fecha sistema
        /// </summary>
        private System.Windows.Forms.Label Fecha_Sistema;
        /// <summary>
        /// The boton para minimizar ventana
        /// </summary>
        private FontAwesome.Sharp.IconPictureBox BotonParaMinimizarVentana;
        /// <summary>
        /// The panel1
        /// </summary>
        private System.Windows.Forms.Panel panel1;
        /// <summary>
        /// The guna2 picture box1
        /// </summary>
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        /// <summary>
        /// The hora sistema
        /// </summary>
        private System.Windows.Forms.Label Hora_Sistema;
        /// <summary>
        /// The guna2 HTML label9
        /// </summary>
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        /// <summary>
        /// The fecha hora
        /// </summary>
        private System.Windows.Forms.Timer FechaHora;
    }
}