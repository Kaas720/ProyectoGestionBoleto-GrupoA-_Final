﻿
namespace Presentacion
{
    partial class Principal_Usuario
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.DataGridInf = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Cooperativa_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora_Salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo_pasaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Boton_DatGrid = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cbDestino = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbOrigen = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbCooperativa = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.botonRegistroUsuario = new FontAwesome.Sharp.IconButton();
            this.BotonInicioSesion = new FontAwesome.Sharp.IconButton();
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.Fecha_Sistema = new System.Windows.Forms.Label();
            this.BotonParaMinimizarVentana = new FontAwesome.Sharp.IconPictureBox();
            this.BotonCierreDeAplicacion = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Hora_Sistema = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel4.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridInf)).BeginInit();
            this.panel2.SuspendLayout();
            this.PanelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BotonParaMinimizarVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonCierreDeAplicacion)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.guna2GroupBox1);
            this.panel4.Controls.Add(this.cbDestino);
            this.panel4.Controls.Add(this.cbOrigen);
            this.panel4.Controls.Add(this.guna2HtmlLabel6);
            this.panel4.Controls.Add(this.guna2HtmlLabel5);
            this.panel4.Controls.Add(this.cbCooperativa);
            this.panel4.Controls.Add(this.guna2HtmlLabel3);
            this.panel4.Location = new System.Drawing.Point(215, 75);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(712, 394);
            this.panel4.TabIndex = 29;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderRadius = 15;
            this.guna2GroupBox1.Controls.Add(this.DataGridInf);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(26, 145);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(658, 235);
            this.guna2GroupBox1.TabIndex = 14;
            this.guna2GroupBox1.Text = "ELEGIR RUTA";
            // 
            // DataGridInf
            // 
            this.DataGridInf.AllowUserToAddRows = false;
            this.DataGridInf.AllowUserToDeleteRows = false;
            this.DataGridInf.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridInf.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.DataGridInf.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridInf.BackgroundColor = System.Drawing.Color.White;
            this.DataGridInf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridInf.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridInf.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridInf.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.DataGridInf.ColumnHeadersHeight = 21;
            this.DataGridInf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cooperativa_nombre,
            this.Hora_Salida,
            this.FechaSalida,
            this.Costo_pasaje,
            this.Boton_DatGrid});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridInf.DefaultCellStyle = dataGridViewCellStyle11;
            this.DataGridInf.EnableHeadersVisualStyles = false;
            this.DataGridInf.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridInf.Location = new System.Drawing.Point(15, 50);
            this.DataGridInf.MultiSelect = false;
            this.DataGridInf.Name = "DataGridInf";
            this.DataGridInf.ReadOnly = true;
            this.DataGridInf.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridInf.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.DataGridInf.RowHeadersVisible = false;
            this.DataGridInf.RowHeadersWidth = 62;
            this.DataGridInf.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridInf.Size = new System.Drawing.Size(629, 170);
            this.DataGridInf.TabIndex = 13;
            this.DataGridInf.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridInf.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridInf.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridInf.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridInf.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridInf.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridInf.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridInf.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Teal;
            this.DataGridInf.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridInf.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridInf.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridInf.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridInf.ThemeStyle.HeaderStyle.Height = 21;
            this.DataGridInf.ThemeStyle.ReadOnly = true;
            this.DataGridInf.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridInf.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridInf.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DataGridInf.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.DataGridInf.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridInf.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridInf.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridInf.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridInf_CellContentClick);
            // 
            // Cooperativa_nombre
            // 
            this.Cooperativa_nombre.HeaderText = "Cooperativa";
            this.Cooperativa_nombre.MinimumWidth = 8;
            this.Cooperativa_nombre.Name = "Cooperativa_nombre";
            this.Cooperativa_nombre.ReadOnly = true;
            // 
            // Hora_Salida
            // 
            this.Hora_Salida.HeaderText = "Hora de salida";
            this.Hora_Salida.MinimumWidth = 8;
            this.Hora_Salida.Name = "Hora_Salida";
            this.Hora_Salida.ReadOnly = true;
            // 
            // FechaSalida
            // 
            this.FechaSalida.HeaderText = "Fecha Salida";
            this.FechaSalida.MinimumWidth = 8;
            this.FechaSalida.Name = "FechaSalida";
            this.FechaSalida.ReadOnly = true;
            // 
            // Costo_pasaje
            // 
            this.Costo_pasaje.HeaderText = "Precio";
            this.Costo_pasaje.MinimumWidth = 8;
            this.Costo_pasaje.Name = "Costo_pasaje";
            this.Costo_pasaje.ReadOnly = true;
            // 
            // Boton_DatGrid
            // 
            this.Boton_DatGrid.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Boton_DatGrid.HeaderText = "Seleccionar";
            this.Boton_DatGrid.Name = "Boton_DatGrid";
            this.Boton_DatGrid.ReadOnly = true;
            // 
            // cbDestino
            // 
            this.cbDestino.AutoRoundedCorners = true;
            this.cbDestino.BackColor = System.Drawing.Color.Transparent;
            this.cbDestino.BorderRadius = 17;
            this.cbDestino.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDestino.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDestino.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDestino.FocusedState.Parent = this.cbDestino;
            this.cbDestino.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbDestino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbDestino.HoverState.Parent = this.cbDestino;
            this.cbDestino.ItemHeight = 30;
            this.cbDestino.ItemsAppearance.Parent = this.cbDestino;
            this.cbDestino.Location = new System.Drawing.Point(255, 84);
            this.cbDestino.Name = "cbDestino";
            this.cbDestino.ShadowDecoration.Parent = this.cbDestino;
            this.cbDestino.Size = new System.Drawing.Size(171, 36);
            this.cbDestino.TabIndex = 11;
            this.cbDestino.SelectedIndexChanged += new System.EventHandler(this.cbDestino_SelectedIndexChanged);
            // 
            // cbOrigen
            // 
            this.cbOrigen.AutoRoundedCorners = true;
            this.cbOrigen.BackColor = System.Drawing.Color.Transparent;
            this.cbOrigen.BorderRadius = 17;
            this.cbOrigen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrigen.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbOrigen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbOrigen.FocusedState.Parent = this.cbOrigen;
            this.cbOrigen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbOrigen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbOrigen.HoverState.Parent = this.cbOrigen;
            this.cbOrigen.ItemHeight = 30;
            this.cbOrigen.ItemsAppearance.Parent = this.cbOrigen;
            this.cbOrigen.Location = new System.Drawing.Point(26, 84);
            this.cbOrigen.Name = "cbOrigen";
            this.cbOrigen.ShadowDecoration.Parent = this.cbOrigen;
            this.cbOrigen.Size = new System.Drawing.Size(157, 36);
            this.cbOrigen.TabIndex = 10;
            this.cbOrigen.SelectedIndexChanged += new System.EventHandler(this.cbOrigen_SelectedIndexChanged);
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(265, 48);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(144, 26);
            this.guna2HtmlLabel6.TabIndex = 9;
            this.guna2HtmlLabel6.Text = "Lugar de destino";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(35, 48);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(137, 26);
            this.guna2HtmlLabel5.TabIndex = 7;
            this.guna2HtmlLabel5.Text = "Lugar de origen";
            // 
            // cbCooperativa
            // 
            this.cbCooperativa.AutoRoundedCorners = true;
            this.cbCooperativa.BackColor = System.Drawing.Color.Transparent;
            this.cbCooperativa.BorderRadius = 17;
            this.cbCooperativa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCooperativa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCooperativa.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCooperativa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCooperativa.FocusedState.Parent = this.cbCooperativa;
            this.cbCooperativa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbCooperativa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbCooperativa.HoverState.Parent = this.cbCooperativa;
            this.cbCooperativa.ItemHeight = 30;
            this.cbCooperativa.ItemsAppearance.Parent = this.cbCooperativa;
            this.cbCooperativa.Location = new System.Drawing.Point(467, 84);
            this.cbCooperativa.Name = "cbCooperativa";
            this.cbCooperativa.ShadowDecoration.Parent = this.cbCooperativa;
            this.cbCooperativa.Size = new System.Drawing.Size(217, 36);
            this.cbCooperativa.TabIndex = 6;
            this.cbCooperativa.SelectedIndexChanged += new System.EventHandler(this.cbCooperativa_SelectedIndexChanged);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(517, 48);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(108, 26);
            this.guna2HtmlLabel3.TabIndex = 5;
            this.guna2HtmlLabel3.Text = "Cooperativa:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(78)))), ((int)(((byte)(95)))));
            this.panel2.Controls.Add(this.guna2HtmlLabel2);
            this.panel2.Controls.Add(this.botonRegistroUsuario);
            this.panel2.Controls.Add(this.BotonInicioSesion);
            this.panel2.Location = new System.Drawing.Point(0, 75);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 392);
            this.panel2.TabIndex = 30;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(10, 371);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(195, 18);
            this.guna2HtmlLabel2.TabIndex = 13;
            this.guna2HtmlLabel2.Text = "Copyright © 2022 VIAJEROS S.A";
            // 
            // botonRegistroUsuario
            // 
            this.botonRegistroUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(78)))), ((int)(((byte)(95)))));
            this.botonRegistroUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonRegistroUsuario.FlatAppearance.BorderSize = 0;
            this.botonRegistroUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRegistroUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRegistroUsuario.ForeColor = System.Drawing.SystemColors.Info;
            this.botonRegistroUsuario.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.botonRegistroUsuario.IconColor = System.Drawing.Color.White;
            this.botonRegistroUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.botonRegistroUsuario.IconSize = 55;
            this.botonRegistroUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonRegistroUsuario.Location = new System.Drawing.Point(0, 120);
            this.botonRegistroUsuario.Name = "botonRegistroUsuario";
            this.botonRegistroUsuario.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.botonRegistroUsuario.Size = new System.Drawing.Size(217, 120);
            this.botonRegistroUsuario.TabIndex = 11;
            this.botonRegistroUsuario.Text = "REGISTRATE";
            this.botonRegistroUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonRegistroUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botonRegistroUsuario.UseVisualStyleBackColor = false;
            this.botonRegistroUsuario.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // BotonInicioSesion
            // 
            this.BotonInicioSesion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BotonInicioSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(78)))), ((int)(((byte)(95)))));
            this.BotonInicioSesion.Dock = System.Windows.Forms.DockStyle.Top;
            this.BotonInicioSesion.FlatAppearance.BorderSize = 0;
            this.BotonInicioSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonInicioSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonInicioSesion.ForeColor = System.Drawing.SystemColors.Info;
            this.BotonInicioSesion.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.BotonInicioSesion.IconColor = System.Drawing.Color.White;
            this.BotonInicioSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BotonInicioSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotonInicioSesion.Location = new System.Drawing.Point(0, 0);
            this.BotonInicioSesion.Name = "BotonInicioSesion";
            this.BotonInicioSesion.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BotonInicioSesion.Size = new System.Drawing.Size(217, 120);
            this.BotonInicioSesion.TabIndex = 12;
            this.BotonInicioSesion.Text = "INICIAR SESIÓN";
            this.BotonInicioSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotonInicioSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BotonInicioSesion.UseVisualStyleBackColor = false;
            this.BotonInicioSesion.Click += new System.EventHandler(this.BotonInicioSesion_Click);
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.PanelSuperior.Controls.Add(this.Fecha_Sistema);
            this.PanelSuperior.Controls.Add(this.BotonParaMinimizarVentana);
            this.PanelSuperior.Controls.Add(this.BotonCierreDeAplicacion);
            this.PanelSuperior.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.PanelSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(927, 35);
            this.PanelSuperior.TabIndex = 31;
            this.PanelSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelSuperior_MouseMove);
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
            this.BotonParaMinimizarVentana.Location = new System.Drawing.Point(840, 7);
            this.BotonParaMinimizarVentana.Name = "BotonParaMinimizarVentana";
            this.BotonParaMinimizarVentana.Size = new System.Drawing.Size(39, 34);
            this.BotonParaMinimizarVentana.TabIndex = 1;
            this.BotonParaMinimizarVentana.TabStop = false;
            this.BotonParaMinimizarVentana.Click += new System.EventHandler(this.BotonParaMinimizarVentana_Click_1);
            // 
            // BotonCierreDeAplicacion
            // 
            this.BotonCierreDeAplicacion.BackColor = System.Drawing.Color.Transparent;
            this.BotonCierreDeAplicacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonCierreDeAplicacion.ForeColor = System.Drawing.Color.Yellow;
            this.BotonCierreDeAplicacion.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.BotonCierreDeAplicacion.IconColor = System.Drawing.Color.Yellow;
            this.BotonCierreDeAplicacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BotonCierreDeAplicacion.IconSize = 37;
            this.BotonCierreDeAplicacion.Location = new System.Drawing.Point(855, 4);
            this.BotonCierreDeAplicacion.Name = "BotonCierreDeAplicacion";
            this.BotonCierreDeAplicacion.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BotonCierreDeAplicacion.Size = new System.Drawing.Size(64, 37);
            this.BotonCierreDeAplicacion.TabIndex = 0;
            this.BotonCierreDeAplicacion.TabStop = false;
            this.BotonCierreDeAplicacion.Click += new System.EventHandler(this.BotonCierreDeAplicacion_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.guna2HtmlLabel9);
            this.panel1.Controls.Add(this.guna2PictureBox1);
            this.panel1.Controls.Add(this.Hora_Sistema);
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 42);
            this.panel1.TabIndex = 32;
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.guna2HtmlLabel9.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(79, 12);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(304, 20);
            this.guna2HtmlLabel9.TabIndex = 6;
            this.guna2HtmlLabel9.Text = "Sistema de Gestion de Boletos de AutoBuses";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Presentacion.Properties.Resources.pngtree_blue_big_car_illustration_cartoon_shuttle_blue_bus_gray_glass_png_image_4543101;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(17, 5);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(66, 31);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            // 
            // Hora_Sistema
            // 
            this.Hora_Sistema.AutoSize = true;
            this.Hora_Sistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hora_Sistema.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Hora_Sistema.Location = new System.Drawing.Point(832, 9);
            this.Hora_Sistema.Name = "Hora_Sistema";
            this.Hora_Sistema.Size = new System.Drawing.Size(80, 24);
            this.Hora_Sistema.TabIndex = 1;
            this.Hora_Sistema.Text = "17:51:10";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Principal_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 467);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelSuperior);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.TopMost = true;
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridInf)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.PanelSuperior.ResumeLayout(false);
            this.PanelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BotonParaMinimizarVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonCierreDeAplicacion)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton botonRegistroUsuario;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2ComboBox cbDestino;
        private Guna.UI2.WinForms.Guna2ComboBox cbOrigen;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2ComboBox cbCooperativa;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PanelSuperior;
        private System.Windows.Forms.Label Fecha_Sistema;
        private FontAwesome.Sharp.IconPictureBox BotonParaMinimizarVentana;
        private FontAwesome.Sharp.IconPictureBox BotonCierreDeAplicacion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Hora_Sistema;
        private FontAwesome.Sharp.IconButton BotonInicioSesion;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridInf;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cooperativa_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora_Salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo_pasaje;
        private System.Windows.Forms.DataGridViewButtonColumn Boton_DatGrid;
    }
}

