
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
            this.BotonParaMinimizarVentana = new FontAwesome.Sharp.IconPictureBox();
            this.BotonCierreDeAplicacion = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.BotonEliminarAdmin = new FontAwesome.Sharp.IconButton();
            this.BotonregistrasAdmin = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Hora_Sistema = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Fecha_Hora_Sistema = new System.Windows.Forms.Timer(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.PanelPrincipalContenedor = new Guna.UI2.WinForms.Guna2Panel();
            this.PanelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BotonParaMinimizarVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonCierreDeAplicacion)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.PanelSuperior.Size = new System.Drawing.Size(919, 35);
            this.PanelSuperior.TabIndex = 0;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(78)))), ((int)(((byte)(95)))));
            this.panel2.Controls.Add(this.guna2CirclePictureBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(205, 168);
            this.panel2.TabIndex = 1;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::Presentacion.Properties.Resources.c82646ff36e2523350d01fff093938f6;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(68, 46);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(82, 73);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 4;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(83, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(46, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "ADMINISTRADOR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "KEVIN ARÉVALO S";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(78)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.iconButton4);
            this.panel3.Controls.Add(this.iconButton3);
            this.panel3.Controls.Add(this.BotonEliminarAdmin);
            this.panel3.Controls.Add(this.BotonregistrasAdmin);
            this.panel3.Location = new System.Drawing.Point(0, 241);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(205, 360);
            this.panel3.TabIndex = 2;
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(78)))), ((int)(((byte)(95)))));
            this.iconButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 55;
            this.iconButton4.Location = new System.Drawing.Point(0, 269);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(205, 87);
            this.iconButton4.TabIndex = 3;
            this.iconButton4.Text = "CERRAR SESIÓN";
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = false;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(78)))), ((int)(((byte)(95)))));
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 55;
            this.iconButton3.Location = new System.Drawing.Point(0, 179);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(205, 90);
            this.iconButton3.TabIndex = 2;
            this.iconButton3.Text = "REPORTE";
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = false;
            // 
            // BotonEliminarAdmin
            // 
            this.BotonEliminarAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(78)))), ((int)(((byte)(95)))));
            this.BotonEliminarAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.BotonEliminarAdmin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.BotonEliminarAdmin.FlatAppearance.BorderSize = 0;
            this.BotonEliminarAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonEliminarAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonEliminarAdmin.ForeColor = System.Drawing.Color.Transparent;
            this.BotonEliminarAdmin.IconChar = FontAwesome.Sharp.IconChar.UserAltSlash;
            this.BotonEliminarAdmin.IconColor = System.Drawing.Color.White;
            this.BotonEliminarAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BotonEliminarAdmin.IconSize = 55;
            this.BotonEliminarAdmin.Location = new System.Drawing.Point(0, 89);
            this.BotonEliminarAdmin.Name = "BotonEliminarAdmin";
            this.BotonEliminarAdmin.Size = new System.Drawing.Size(205, 90);
            this.BotonEliminarAdmin.TabIndex = 1;
            this.BotonEliminarAdmin.Text = "ELIMINAR";
            this.BotonEliminarAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BotonEliminarAdmin.UseVisualStyleBackColor = false;
            this.BotonEliminarAdmin.Click += new System.EventHandler(this.BotonEliminarAdmin_Click);
            // 
            // BotonregistrasAdmin
            // 
            this.BotonregistrasAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(78)))), ((int)(((byte)(95)))));
            this.BotonregistrasAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.BotonregistrasAdmin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.BotonregistrasAdmin.FlatAppearance.BorderSize = 0;
            this.BotonregistrasAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonregistrasAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonregistrasAdmin.ForeColor = System.Drawing.Color.Transparent;
            this.BotonregistrasAdmin.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.BotonregistrasAdmin.IconColor = System.Drawing.Color.White;
            this.BotonregistrasAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BotonregistrasAdmin.IconSize = 55;
            this.BotonregistrasAdmin.Location = new System.Drawing.Point(0, 0);
            this.BotonregistrasAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.BotonregistrasAdmin.Name = "BotonregistrasAdmin";
            this.BotonregistrasAdmin.Size = new System.Drawing.Size(205, 89);
            this.BotonregistrasAdmin.TabIndex = 0;
            this.BotonregistrasAdmin.Text = "REGISTRAR";
            this.BotonregistrasAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BotonregistrasAdmin.UseVisualStyleBackColor = false;
            this.BotonregistrasAdmin.Click += new System.EventHandler(this.BotonregistrasAdmin_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
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
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 20;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 40;
            // 
            // PanelPrincipalContenedor
            // 
            this.PanelPrincipalContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.PanelPrincipalContenedor.Location = new System.Drawing.Point(205, 77);
            this.PanelPrincipalContenedor.Name = "PanelPrincipalContenedor";
            this.PanelPrincipalContenedor.ShadowDecoration.Parent = this.PanelPrincipalContenedor;
            this.PanelPrincipalContenedor.Size = new System.Drawing.Size(713, 520);
            this.PanelPrincipalContenedor.TabIndex = 4;
            // 
            // VentanaAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(245)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(919, 598);
            this.Controls.Add(this.PanelPrincipalContenedor);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PanelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VentanaAdministrador";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIAJEROS S.A";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.PanelSuperior.ResumeLayout(false);
            this.PanelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BotonParaMinimizarVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonCierreDeAplicacion)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelSuperior;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconPictureBox BotonCierreDeAplicacion;
        private FontAwesome.Sharp.IconPictureBox BotonParaMinimizarVentana;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton BotonEliminarAdmin;
        private FontAwesome.Sharp.IconButton BotonregistrasAdmin;
        private System.Windows.Forms.Label Fecha_Sistema;
        private System.Windows.Forms.Label Hora_Sistema;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer Fecha_Hora_Sistema;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel PanelPrincipalContenedor;
    }
}

