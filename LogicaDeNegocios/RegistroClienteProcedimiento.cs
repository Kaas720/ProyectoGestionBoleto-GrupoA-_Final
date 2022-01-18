using LogicaDeNegocios.Procedimientos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios.Modulo_Procedimiento_Registro
{
    public class RegistroClienteProcedimiento
    {

        RegistrarClienteProcesosBaseDatos registrarClienteBD = new RegistrarClienteProcesosBaseDatos();
        public void RegistrarCliente(CredencialUsuario credencial)
        {
            registrarClienteBD.RegistroClientesEnProcedimientos(credencial);
        }
    }
}
