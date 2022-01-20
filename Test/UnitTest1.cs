using LogicaDeNegocios;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PruebaInicioSeccion()
        {
            ConsultasProcedimientos consultasProcedimientos = new ConsultasProcedimientos();
            bool result = consultasProcedimientos.Login("Kaas7520@hotmail.com", "1234", 1);
            Assert.AreEqual(true, result);
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
