﻿
using Presentacion;

namespace Presentacion
{
    partial class VentanaAdministrador
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
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.Fecha_Sistema = new System.Windows.Forms.Label();
            this.GneralPanelOpciones = new Guna.UI2.WinForms.Guna2Panel();
            this.PanelEliminar = new Guna.UI2.WinForms.Guna2Panel();
            this.PanelRegistro = new Guna.UI2.WinForms.Guna2Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Hora_Sistema = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Fecha_Hora_Sistema = new System.Windows.Forms.Timer(this.components);
            this.PanelPrincipalContenedor = new Guna.UI2.WinForms.Guna2Panel();
            this.Salir = new FontAwesome.Sharp.IconButton();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Exit = new FontAwesome.Sharp.IconButton();
            this.Reporte = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.Eliminar = new FontAwesome.Sharp.IconButton();
            this.Vendedor = new FontAwesome.Sharp.IconButton();
            this.Chofer = new FontAwesome.Sharp.IconButton();
            this.RegistrarCooperativa = new FontAwesome.Sharp.IconButton();
            this.RegistrarCliente = new FontAwesome.Sharp.IconButton();
            this.BotonregistrasAdmin = new FontAwesome.Sharp.IconButton();
            this.Home = new FontAwesome.Sharp.IconButton();
            this.BotonParaMinimizarVentana = new FontAwesome.Sharp.IconPictureBox();
            this.BotonCierreDeAplicacion = new FontAwesome.Sharp.IconPictureBox();
            this.PanelSuperior.SuspendLayout();
            this.GneralPanelOpciones.SuspendLayout();
            this.PanelEliminar.SuspendLayout();
            this.PanelRegistro.SuspendLayout();
            this.panel4.SuspendLayout();
            this.PanelPrincipalContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonParaMinimizarVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonCierreDeAplicacion)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.PanelSuperior.Controls.Add(this.Fecha_Sistema);
            this.PanelSuperior.Controls.Add(this.BotonParaMinimizarVentana);
            this.PanelSuperior.Controls.Add(this.BotonCierreDeAplicacion);
            this.PanelSuperior.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.PanelSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(919, 35);
            this.PanelSuperior.TabIndex = 0;
            this.PanelSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelSuperior_MouseMove);
            // 
            // Fecha_Sistema
            // 
            this.Fecha_Sistema.AutoSize = true;
            this.Fecha_Sistema.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.Fecha_Sistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha_Sistema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.Fecha_Sistema.Location = new System.Drawing.Point(372, 11);
            this.Fecha_Sistema.Name = "Fecha_Sistema";
            this.Fecha_Sistema.Size = new System.Drawing.Size(60, 20);
            this.Fecha_Sistema.TabIndex = 2;
            this.Fecha_Sistema.Text = "LABEL";
            this.Fecha_Sistema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GneralPanelOpciones
            // 
            this.GneralPanelOpciones.AutoScroll = true;
            this.GneralPanelOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(78)))), ((int)(((byte)(0)))));
            this.GneralPanelOpciones.Controls.Add(this.Exit);
            this.GneralPanelOpciones.Controls.Add(this.Reporte);
            this.GneralPanelOpciones.Controls.Add(this.PanelEliminar);
            this.GneralPanelOpciones.Controls.Add(this.Eliminar);
            this.GneralPanelOpciones.Controls.Add(this.PanelRegistro);
            this.GneralPanelOpciones.Controls.Add(this.BotonregistrasAdmin);
            this.GneralPanelOpciones.Controls.Add(this.Home);
            this.GneralPanelOpciones.Location = new System.Drawing.Point(0, 77);
            this.GneralPanelOpciones.Name = "GneralPanelOpciones";
            this.GneralPanelOpciones.ShadowDecoration.Parent = this.GneralPanelOpciones;
            this.GneralPanelOpciones.Size = new System.Drawing.Size(205, 390);
            this.GneralPanelOpciones.TabIndex = 2;
            // 
            // PanelEliminar
            // 
            this.PanelEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PanelEliminar.Controls.Add(this.iconButton2);
            this.PanelEliminar.Controls.Add(this.iconButton3);
            this.PanelEliminar.Controls.Add(this.iconButton4);
            this.PanelEliminar.Controls.Add(this.iconButton5);
            this.PanelEliminar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelEliminar.Location = new System.Drawing.Point(0, 446);
            this.PanelEliminar.Name = "PanelEliminar";
            this.PanelEliminar.ShadowDecoration.Parent = this.PanelEliminar;
            this.PanelEliminar.Size = new System.Drawing.Size(188, 212);
            this.PanelEliminar.TabIndex = 6;
            this.PanelEliminar.Visible = false;
            // 
            // PanelRegistro
            // 
            this.PanelRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PanelRegistro.Controls.Add(this.Vendedor);
            this.PanelRegistro.Controls.Add(this.Chofer);
            this.PanelRegistro.Controls.Add(this.RegistrarCooperativa);
            this.PanelRegistro.Controls.Add(this.RegistrarCliente);
            this.PanelRegistro.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelRegistro.Location = new System.Drawing.Point(0, 156);
            this.PanelRegistro.Name = "PanelRegistro";
            this.PanelRegistro.ShadowDecoration.Parent = this.PanelRegistro;
            this.PanelRegistro.Size = new System.Drawing.Size(188, 212);
            this.PanelRegistro.TabIndex = 1;
            this.PanelRegistro.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.panel4.Controls.Add(this.guna2Panel1);
            this.panel4.Controls.Add(this.guna2PictureBox1);
            this.panel4.Controls.Add(this.Hora_Sistema);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(0, 35);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(922, 42);
            this.panel4.TabIndex = 3;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Location = new System.Drawing.Point(207, 40);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(712, 522);
            this.guna2Panel1.TabIndex = 4;
            // 
            // Hora_Sistema
            // 
            this.Hora_Sistema.AutoSize = true;
            this.Hora_Sistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hora_Sistema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.Hora_Sistema.Location = new System.Drawing.Point(832, 9);
            this.Hora_Sistema.Name = "Hora_Sistema";
            this.Hora_Sistema.Size = new System.Drawing.Size(80, 24);
            this.Hora_Sistema.TabIndex = 1;
            this.Hora_Sistema.Text = "17:51:10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.label4.Location = new System.Drawing.Point(89, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "BIENVENIDO A VIAJEROS S.A";
            // 
            // Fecha_Hora_Sistema
            // 
            this.Fecha_Hora_Sistema.Enabled = true;
            this.Fecha_Hora_Sistema.Tick += new System.EventHandler(this.Fecha_Hora_Sistema_Tick);
            // 
            // PanelPrincipalContenedor
            // 
            this.PanelPrincipalContenedor.BackColor = System.Drawing.Color.White;
            this.PanelPrincipalContenedor.Controls.Add(this.Salir);
            this.PanelPrincipalContenedor.Location = new System.Drawing.Point(205, 77);
            this.PanelPrincipalContenedor.Name = "PanelPrincipalContenedor";
            this.PanelPrincipalContenedor.ShadowDecoration.Parent = this.PanelPrincipalContenedor;
            this.PanelPrincipalContenedor.Size = new System.Drawing.Size(713, 389);
            this.PanelPrincipalContenedor.TabIndex = 4;
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(78)))), ((int)(((byte)(95)))));
            this.Salir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.Salir.FlatAppearance.BorderSize = 0;
            this.Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.ForeColor = System.Drawing.Color.Transparent;
            this.Salir.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.Salir.IconColor = System.Drawing.Color.White;
            this.Salir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Salir.IconSize = 55;
            this.Salir.Location = new System.Drawing.Point(151, 421);
            this.Salir.Margin = new System.Windows.Forms.Padding(2);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(188, 89);
            this.Salir.TabIndex = 5;
            this.Salir.Text = "Salir";
            this.Salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Salir.UseVisualStyleBackColor = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Presentacion.Properties.Resources.pngtree_blue_big_car_illustration_cartoon_shuttle_blue_bus_gray_glass_png_image_4543101;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(17, 2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(66, 37);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 6;
            this.guna2PictureBox1.TabStop = false;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(121)))), ((int)(((byte)(158)))));
            this.Exit.Dock = System.Windows.Forms.DockStyle.Top;
            this.Exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.Exit.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.Exit.IconColor = System.Drawing.Color.White;
            this.Exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Exit.IconSize = 40;
            this.Exit.Location = new System.Drawing.Point(0, 736);
            this.Exit.Margin = new System.Windows.Forms.Padding(2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(188, 78);
            this.Exit.TabIndex = 8;
            this.Exit.Text = "CERRAR SESION";
            this.Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Exit.UseVisualStyleBackColor = false;
            // 
            // Reporte
            // 
            this.Reporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(121)))), ((int)(((byte)(158)))));
            this.Reporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.Reporte.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.Reporte.FlatAppearance.BorderSize = 0;
            this.Reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.Reporte.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.Reporte.IconColor = System.Drawing.Color.White;
            this.Reporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Reporte.IconSize = 40;
            this.Reporte.Location = new System.Drawing.Point(0, 658);
            this.Reporte.Margin = new System.Windows.Forms.Padding(2);
            this.Reporte.Name = "Reporte";
            this.Reporte.Size = new System.Drawing.Size(188, 78);
            this.Reporte.TabIndex = 7;
            this.Reporte.Text = "REPORTE";
            this.Reporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Reporte.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 55;
            this.iconButton2.Location = new System.Drawing.Point(0, 159);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(188, 53);
            this.iconButton2.TabIndex = 4;
            this.iconButton2.Text = "VENDEDOR";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 55;
            this.iconButton3.Location = new System.Drawing.Point(0, 106);
            this.iconButton3.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(188, 53);
            this.iconButton3.TabIndex = 3;
            this.iconButton3.Text = "CHOFER";
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = false;
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.iconButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 55;
            this.iconButton4.Location = new System.Drawing.Point(0, 53);
            this.iconButton4.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(188, 53);
            this.iconButton4.TabIndex = 2;
            this.iconButton4.Text = "COOPERATIVA";
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = false;
            // 
            // iconButton5
            // 
            this.iconButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.iconButton5.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconButton5.IconColor = System.Drawing.Color.White;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 55;
            this.iconButton5.Location = new System.Drawing.Point(0, 0);
            this.iconButton5.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(188, 53);
            this.iconButton5.TabIndex = 1;
            this.iconButton5.Text = "CLIENTE";
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton5.UseVisualStyleBackColor = false;
            // 
            // Eliminar
            // 
            this.Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(121)))), ((int)(((byte)(158)))));
            this.Eliminar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Eliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.Eliminar.FlatAppearance.BorderSize = 0;
            this.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.Eliminar.IconChar = FontAwesome.Sharp.IconChar.UsersSlash;
            this.Eliminar.IconColor = System.Drawing.Color.White;
            this.Eliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Eliminar.IconSize = 40;
            this.Eliminar.Location = new System.Drawing.Point(0, 368);
            this.Eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(188, 78);
            this.Eliminar.TabIndex = 5;
            this.Eliminar.Text = "ELIMINAR";
            this.Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Eliminar.UseVisualStyleBackColor = false;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Vendedor
            // 
            this.Vendedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(196)))), ((int)(((byte)(214)))));
            this.Vendedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.Vendedor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.Vendedor.FlatAppearance.BorderSize = 0;
            this.Vendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Vendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vendedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.Vendedor.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.Vendedor.IconColor = System.Drawing.Color.White;
            this.Vendedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Vendedor.IconSize = 55;
            this.Vendedor.Location = new System.Drawing.Point(0, 159);
            this.Vendedor.Margin = new System.Windows.Forms.Padding(2);
            this.Vendedor.Name = "Vendedor";
            this.Vendedor.Size = new System.Drawing.Size(188, 53);
            this.Vendedor.TabIndex = 4;
            this.Vendedor.Text = "VENDEDOR";
            this.Vendedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Vendedor.UseVisualStyleBackColor = false;
            // 
            // Chofer
            // 
            this.Chofer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(196)))), ((int)(((byte)(214)))));
            this.Chofer.Dock = System.Windows.Forms.DockStyle.Top;
            this.Chofer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.Chofer.FlatAppearance.BorderSize = 0;
            this.Chofer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Chofer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chofer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.Chofer.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.Chofer.IconColor = System.Drawing.Color.White;
            this.Chofer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Chofer.IconSize = 55;
            this.Chofer.Location = new System.Drawing.Point(0, 106);
            this.Chofer.Margin = new System.Windows.Forms.Padding(2);
            this.Chofer.Name = "Chofer";
            this.Chofer.Size = new System.Drawing.Size(188, 53);
            this.Chofer.TabIndex = 3;
            this.Chofer.Text = "CHOFER";
            this.Chofer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Chofer.UseVisualStyleBackColor = false;
            // 
            // RegistrarCooperativa
            // 
            this.RegistrarCooperativa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(196)))), ((int)(((byte)(214)))));
            this.RegistrarCooperativa.Dock = System.Windows.Forms.DockStyle.Top;
            this.RegistrarCooperativa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.RegistrarCooperativa.FlatAppearance.BorderSize = 0;
            this.RegistrarCooperativa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistrarCooperativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrarCooperativa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.RegistrarCooperativa.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.RegistrarCooperativa.IconColor = System.Drawing.Color.White;
            this.RegistrarCooperativa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RegistrarCooperativa.IconSize = 55;
            this.RegistrarCooperativa.Location = new System.Drawing.Point(0, 53);
            this.RegistrarCooperativa.Margin = new System.Windows.Forms.Padding(2);
            this.RegistrarCooperativa.Name = "RegistrarCooperativa";
            this.RegistrarCooperativa.Size = new System.Drawing.Size(188, 53);
            this.RegistrarCooperativa.TabIndex = 2;
            this.RegistrarCooperativa.Text = "COOPERATIVA";
            this.RegistrarCooperativa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RegistrarCooperativa.UseVisualStyleBackColor = false;
            // 
            // RegistrarCliente
            // 
            this.RegistrarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(196)))), ((int)(((byte)(214)))));
            this.RegistrarCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.RegistrarCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.RegistrarCliente.FlatAppearance.BorderSize = 0;
            this.RegistrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.RegistrarCliente.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.RegistrarCliente.IconColor = System.Drawing.Color.White;
            this.RegistrarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RegistrarCliente.IconSize = 55;
            this.RegistrarCliente.Location = new System.Drawing.Point(0, 0);
            this.RegistrarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.RegistrarCliente.Name = "RegistrarCliente";
            this.RegistrarCliente.Size = new System.Drawing.Size(188, 53);
            this.RegistrarCliente.TabIndex = 1;
            this.RegistrarCliente.Text = "CLIENTE";
            this.RegistrarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RegistrarCliente.UseVisualStyleBackColor = false;
            // 
            // BotonregistrasAdmin
            // 
            this.BotonregistrasAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(121)))), ((int)(((byte)(158)))));
            this.BotonregistrasAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.BotonregistrasAdmin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.BotonregistrasAdmin.FlatAppearance.BorderSize = 0;
            this.BotonregistrasAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonregistrasAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonregistrasAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.BotonregistrasAdmin.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.BotonregistrasAdmin.IconColor = System.Drawing.Color.White;
            this.BotonregistrasAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BotonregistrasAdmin.IconSize = 40;
            this.BotonregistrasAdmin.Location = new System.Drawing.Point(0, 78);
            this.BotonregistrasAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.BotonregistrasAdmin.Name = "BotonregistrasAdmin";
            this.BotonregistrasAdmin.Size = new System.Drawing.Size(188, 78);
            this.BotonregistrasAdmin.TabIndex = 0;
            this.BotonregistrasAdmin.Text = "REGISTRAR";
            this.BotonregistrasAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BotonregistrasAdmin.UseVisualStyleBackColor = false;
            this.BotonregistrasAdmin.Click += new System.EventHandler(this.BotonregistrasAdmin_Click);
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(121)))), ((int)(((byte)(158)))));
            this.Home.Dock = System.Windows.Forms.DockStyle.Top;
            this.Home.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.Home.FlatAppearance.BorderSize = 0;
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.Home.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.Home.IconColor = System.Drawing.Color.White;
            this.Home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Home.IconSize = 40;
            this.Home.Location = new System.Drawing.Point(0, 0);
            this.Home.Margin = new System.Windows.Forms.Padding(2);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(188, 78);
            this.Home.TabIndex = 1;
            this.Home.Text = "Principal";
            this.Home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Home.UseVisualStyleBackColor = false;
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
            this.BotonParaMinimizarVentana.Click += new System.EventHandler(this.BotonParaMinimizarVentana_Click);
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
            this.BotonCierreDeAplicacion.Location = new System.Drawing.Point(874, 5);
            this.BotonCierreDeAplicacion.Name = "BotonCierreDeAplicacion";
            this.BotonCierreDeAplicacion.Size = new System.Drawing.Size(41, 37);
            this.BotonCierreDeAplicacion.TabIndex = 0;
            this.BotonCierreDeAplicacion.TabStop = false;
            this.BotonCierreDeAplicacion.Click += new System.EventHandler(this.BotonCierreDeAplicacion_Click);
            // 
            // VentanaAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(245)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(919, 467);
            this.Controls.Add(this.PanelPrincipalContenedor);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.GneralPanelOpciones);
            this.Controls.Add(this.PanelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.MinimizeBox = false;
            this.Name = "VentanaAdministrador";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIAJEROS S.A";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.PanelSuperior.ResumeLayout(false);
            this.PanelSuperior.PerformLayout();
            this.GneralPanelOpciones.ResumeLayout(false);
            this.PanelEliminar.ResumeLayout(false);
            this.PanelRegistro.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.PanelPrincipalContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonParaMinimizarVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonCierreDeAplicacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelSuperior;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconPictureBox BotonCierreDeAplicacion;
        private FontAwesome.Sharp.IconPictureBox BotonParaMinimizarVentana;
        private FontAwesome.Sharp.IconButton BotonregistrasAdmin;
        private System.Windows.Forms.Label Fecha_Sistema;
        private System.Windows.Forms.Label Hora_Sistema;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer Fecha_Hora_Sistema;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel PanelPrincipalContenedor;
        private Guna.UI2.WinForms.Guna2Panel PanelRegistro;
        private FontAwesome.Sharp.IconButton Vendedor;
        private FontAwesome.Sharp.IconButton Chofer;
        private FontAwesome.Sharp.IconButton RegistrarCooperativa;
        private FontAwesome.Sharp.IconButton RegistrarCliente;
        private FontAwesome.Sharp.IconButton Salir;
        private Guna.UI2.WinForms.Guna2Panel GneralPanelOpciones;
        private FontAwesome.Sharp.IconButton Home;
        private Guna.UI2.WinForms.Guna2Panel PanelEliminar;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton Eliminar;
        private FontAwesome.Sharp.IconButton Exit;
        private FontAwesome.Sharp.IconButton Reporte;
    }
}

