// ***********************************************************************
// Assembly         : Presentacion
// Author           : USUARIO
// Created          : 02-20-2022
//
// Last Modified By : USUARIO
// Last Modified On : 02-20-2022
// ***********************************************************************
// <copyright file="ActualizarCliente.cs" company="">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************
using LogicaDeNegocios;
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace Presentacion.UsuarioCliente
{
    /// <summary>
    /// Class ActualizarCliente.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class ActualizarCliente : Form
    {
        /// <summary>
        /// The adm
        /// </summary>
        AdmClienteProcedimiento adm = new AdmClienteProcedimiento();
        /// <summary>
        /// The valida
        /// </summary>
        Validacion valida = new Validacion();
        /// <summary>
        /// The cedula
        /// </summary>
        private string cedula =null;


        /// <summary>
        /// Initializes a new instance of the <see cref="ActualizarCliente"/> class.
        /// </summary>
        /// <param name="cedula">The cedula.</param>
        public ActualizarCliente(string cedula)
        {
            InitializeComponent();
            this.cedula = cedula;
            //adm.Inicializar(txtCedula, txtNombre, Sexo, txtTelefono, txtCorreo, txtContraseña);
        }

        /// <summary>
        /// Handles the Click event of the btnActualizar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string cedula = txtCedula.Text.Trim(), nombre= txtNombre.Text, sexo = Sexo.Text, telefono = txtTelefono.Text.Trim(), correo = txtCorreo.Text.Trim(), contrasena = txtContraseña.Text.Trim();
            BorrarAlerta();

            if (validar())
            {
                //adm.Modificar(cedula,nombre, sexo, telefono, correo, contrasena);
                MessageBox.Show("Datos actualizados con exito.");
                Limpiar();
               // this.Hide();
            }
            else
            {
                MessageBox.Show("Existe un campo vacio");
            }
        }
        /// <summary>
        /// Validars this instance.
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="LogicaDeNegocios.ControlExcepcion">Datos no validos!</exception>
        private bool validar()
        {
                Validacion valida = new Validacion();
                bool campo = true;
                if (valida.ValidarCedula(txtCedula.Text) != true)
                {
                    campo = false;
                    errorProvider1.SetError(txtCedula, "Se esperaba 10 numeros.");
                }
                if (txtNombre.Text == "")
                {
                    campo = false;
                    errorProvider1.SetError(txtNombre, "Ingrese su nombre completo.");
                }
                if (valida.ValidarTelefono(txtTelefono.Text) != true)
                {
                    campo = false;
                    errorProvider1.SetError(txtTelefono, "Se esperaba 10 numeros.");
                }
                if (Sexo.Text =="")
                {
                    campo = false;
                    errorProvider1.SetError(Sexo, "Selecione un tipo de genero.");
                }
                if (valida.validarEmail(txtCorreo.Text) != true)
                {
                    campo = false;
                    errorProvider1.SetError(txtCorreo, "Ingrese su correo electronico.");
                }
                if (txtContraseña.Text == "")
                {
                    campo = false;
                    errorProvider1.SetError(txtContraseña, "Ingrese una contraseña.");
                }
                if (!campo)
                {
                    throw new ControlExcepcion("Datos no validos!");
                }

                if (!campo)
                {
                    throw new ControlExcepcion("Datos no validos!");
                }
                return campo;
        }
        /// <summary>
        /// Borrars the alerta.
        /// </summary>
        private void BorrarAlerta()
        {
            errorProvider1.SetError(txtCedula, "");
            errorProvider1.SetError(txtNombre, "");
            errorProvider1.SetError(txtTelefono, "");
        }
        /// <summary>
        /// Limpiars this instance.
        /// </summary>
        public void Limpiar()
        {
            txtCedula.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtContraseña.Clear();
        }

        /// <summary>
        /// Handles the Shown event of the ActualizarCliente control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ActualizarCliente_Shown(object sender, EventArgs e)
        {
            txtCedula.Text = cedula;
        }

        /// <summary>
        /// Handles the Click event of the btnSalir control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
