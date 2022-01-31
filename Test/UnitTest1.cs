using LogicaDeNegocios;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test
{
    [TestClass]
    public class UnitTest1 {

        AdmClienteProcedimiento cliente = new AdmClienteProcedimiento();
        /// <summary>
        /// CP-004
        /// </summary>
        /// 

        [TestMethod]
        public void RegistroCliente()
        {
            Cliente client = new Cliente("1234567890", "Jorge Velez", "Masculino", "0987765432", "jorge@gmail.com", "velez123",4);
            var resultadoEsperado = cliente.RegistrarCliente(client);
            var resultadoObtenido = true;
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

        [TestMethod]
        public void PruebaInicioSeccion()
        {
            ConsultasProcedimientos consultasProcedimientos = new ConsultasProcedimientos();
            int result = consultasProcedimientos.Login("Kaas7520@hotmail.com", "1234");
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void PruebaValidacionCedula()
        {
            Validacion validacion = new Validacion();
            bool result = validacion.ValidarCedula("0302527742");
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void PruebaValidacionTelefono()
        {
            Validacion validacion = new Validacion();
            bool result = validacion.ValidarTelefono("0991887965");
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void PruebaValidacioCorreo()
        {
            Validacion validacion = new Validacion();
            bool result = validacion.validarEmail("Kevin7520@hotmail.com");
            Assert.AreEqual(true, result);
        }
    }
}
