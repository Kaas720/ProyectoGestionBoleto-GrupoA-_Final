
namespace Presentacion
{
    partial class InicioSeccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSeccion));
            this.NombreUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.Contrasenausuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.botonInicioSesion = new Guna.UI2.WinForms.Guna2Button();
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.BotonRetroceder = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.Fecha_Sistema = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Hora_Sistema = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Fecha_Hora_Sistema = new System.Windows.Forms.Timer(this.components);
            this.TextoInicioSesion = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.PanelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NombreUsuario.DefaultText = "";
            this.NombreUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NombreUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NombreUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NombreUsuario.DisabledState.Parent = this.NombreUsuario;
            this.NombreUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NombreUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NombreUsuario.FocusedState.Parent = this.NombreUsuario;
            this.NombreUsuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NombreUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NombreUsuario.HoverState.Parent = this.NombreUsuario;
            this.NombreUsuario.Location = new System.Drawing.Point(270, 188);
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.PasswordChar = '\0';
            this.NombreUsuario.PlaceholderText = "Correo electronico";
            this.NombreUsuario.SelectedText = "";
            this.NombreUsuario.ShadowDecoration.Parent = this.NombreUsuario;
            this.NombreUsuario.Size = new System.Drawing.Size(200, 36);
            this.NombreUsuario.TabIndex = 0;
            // 
            // Contrasenausuario
            // 
            this.Contrasenausuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Contrasenausuario.DefaultText = "";
            this.Contrasenausuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Contrasenausuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Contrasenausuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Contrasenausuario.DisabledState.Parent = this.Contrasenausuario;
            this.Contrasenausuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Contrasenausuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Contrasenausuario.FocusedState.Parent = this.Contrasenausuario;
            this.Contrasenausuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Contrasenausuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Contrasenausuario.HoverState.Parent = this.Contrasenausuario;
            this.Contrasenausuario.Location = new System.Drawing.Point(270, 256);
            this.Contrasenausuario.Name = "Contrasenausuario";
            this.Contrasenausuario.PasswordChar = '*';
            this.Contrasenausuario.PlaceholderText = "Contraseña";
            this.Contrasenausuario.SelectedText = "";
            this.Contrasenausuario.ShadowDecoration.Parent = this.Contrasenausuario;
            this.Contrasenausuario.Size = new System.Drawing.Size(200, 36);
            this.Contrasenausuario.TabIndex = 1;
            // 
            // botonInicioSesion
            // 
            this.botonInicioSesion.CheckedState.Parent = this.botonInicioSesion;
            this.botonInicioSesion.CustomImages.Parent = this.botonInicioSesion;
            this.botonInicioSesion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.botonInicioSesion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.botonInicioSesion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.botonInicioSesion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.botonInicioSesion.DisabledState.Parent = this.botonInicioSesion;
            this.botonInicioSesion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.botonInicioSesion.ForeColor = System.Drawing.Color.White;
            this.botonInicioSesion.HoverState.Parent = this.botonInicioSesion;
            this.botonInicioSesion.Location = new System.Drawing.Point(270, 327);
            this.botonInicioSesion.Name = "botonInicioSesion";
            this.botonInicioSesion.ShadowDecoration.Parent = this.botonInicioSesion;
            this.botonInicioSesion.Size = new System.Drawing.Size(200, 45);
            this.botonInicioSesion.TabIndex = 3;
            this.botonInicioSesion.Text = "LOGIN";
            this.botonInicioSesion.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.PanelSuperior.Controls.Add(this.BotonRetroceder);
            this.PanelSuperior.Controls.Add(this.iconPictureBox1);
            this.PanelSuperior.Controls.Add(this.iconPictureBox2);
            this.PanelSuperior.Controls.Add(this.Fecha_Sistema);
            this.PanelSuperior.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.PanelSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(707, 37);
            this.PanelSuperior.TabIndex = 8;
            this.PanelSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelSuperior_MouseMove);
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
            this.BotonRetroceder.Location = new System.Drawing.Point(0, 3);
            this.BotonRetroceder.Name = "BotonRetroceder";
            this.BotonRetroceder.Size = new System.Drawing.Size(59, 32);
            this.BotonRetroceder.TabIndex = 40;
            this.BotonRetroceder.UseVisualStyleBackColor = false;
            this.BotonRetroceder.Click += new System.EventHandler(this.BotonRetroceder_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Yellow;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MinusSquare;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Yellow;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 34;
            this.iconPictureBox1.Location = new System.Drawing.Point(629, 2);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(39, 34);
            this.iconPictureBox1.TabIndex = 4;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.Yellow;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconPictureBox2.IconColor = System.Drawing.Color.Yellow;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 37;
            this.iconPictureBox2.Location = new System.Drawing.Point(663, 0);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(41, 37);
            this.iconPictureBox2.TabIndex = 3;
            this.iconPictureBox2.TabStop = false;
            this.iconPictureBox2.Click += new System.EventHandler(this.iconPictureBox2_Click);
            // 
            // Fecha_Sistema
            // 
            this.Fecha_Sistema.AutoSize = true;
            this.Fecha_Sistema.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.Fecha_Sistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha_Sistema.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Fecha_Sistema.Location = new System.Drawing.Point(280, 9);
            this.Fecha_Sistema.Name = "Fecha_Sistema";
            this.Fecha_Sistema.Size = new System.Drawing.Size(60, 20);
            this.Fecha_Sistema.TabIndex = 2;
            this.Fecha_Sistema.Text = "LABEL";
            this.Fecha_Sistema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.panel4.Controls.Add(this.guna2PictureBox2);
            this.panel4.Controls.Add(this.Hora_Sistema);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(0, 32);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(707, 42);
            this.panel4.TabIndex = 9;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = global::Presentacion.Properties.Resources.pngtree_blue_big_car_illustration_cartoon_shuttle_blue_bus_gray_glass_png_image_4543101;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(26, 0);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(68, 42);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 12;
            this.guna2PictureBox2.TabStop = false;
            // 
            // Hora_Sistema
            // 
            this.Hora_Sistema.AutoSize = true;
            this.Hora_Sistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hora_Sistema.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Hora_Sistema.Location = new System.Drawing.Point(624, 8);
            this.Hora_Sistema.Name = "Hora_Sistema";
            this.Hora_Sistema.Size = new System.Drawing.Size(80, 24);
            this.Hora_Sistema.TabIndex = 10;
            this.Hora_Sistema.Text = "17:51:10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(100, 12);
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
            // TextoInicioSesion
            // 
            this.TextoInicioSesion.BackColor = System.Drawing.Color.Transparent;
            this.TextoInicioSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TextoInicioSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoInicioSesion.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.TextoInicioSesion.Location = new System.Drawing.Point(270, 114);
            this.TextoInicioSesion.Name = "TextoInicioSesion";
            this.TextoInicioSesion.Size = new System.Drawing.Size(190, 33);
            this.TextoInicioSesion.TabIndex = 2;
            this.TextoInicioSesion.Text = "Inicio de secion";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // InicioSeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Presentacion.Properties.Resources.salvapantallas_textura_elegante_blanco_23_2148421855;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(705, 400);
            this.Controls.Add(this.TextoInicioSesion);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.botonInicioSesion);
            this.Controls.Add(this.Contrasenausuario);
            this.Controls.Add(this.NombreUsuario);
            this.Controls.Add(this.PanelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InicioSeccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InicioSeccion";
            this.PanelSuperior.ResumeLayout(false);
            this.PanelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox NombreUsuario;
        private Guna.UI2.WinForms.Guna2TextBox Contrasenausuario;
        private Guna.UI2.WinForms.Guna2Button botonInicioSesion;
        private System.Windows.Forms.Panel PanelSuperior;
        private System.Windows.Forms.Label Fecha_Sistema;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Hora_Sistema;
        private System.Windows.Forms.Timer Fecha_Hora_Sistema;
        private Guna.UI2.WinForms.Guna2HtmlLabel TextoInicioSesion;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private FontAwesome.Sharp.IconButton BotonRetroceder;
    }
}