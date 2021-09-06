using Datos;
using Datos.inventario;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ClienteLN
    {
        public List<Cliente> ViewCliente()
        {
            List<Cliente> Lista = new List<Cliente>();
            Cliente oc = null;
            try
            {
                List<CLIENTE> auxlista = ClienteCD.ListarCliente();
                foreach (CLIENTE olp in auxlista)
                {
                    oc = new Cliente(olp.Id_Cliente,olp.Cedula, olp.Nombres, olp.Apellidos, olp.Direccion, olp.Telefono, Convert.ToInt32(olp.Id_Mesa));
                    Lista.Add(oc);

                }
                return Lista;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error Mostrar en la logica el cliente"+ex);
            }

        }
        public bool CreateCliente(Cliente op)
        {
            try
            {
                ClienteCD.InsertarCliente(op);
                return true;

            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al insertar Cliente"+ex);
            }

        }

        public bool UpdateCliente(Cliente op)
        {
            try
            {
                ClienteCD.ActualizarCliente(op);
                return true;

            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error en el update del Cliente"+ ex);
            }

        }

        public bool DeleteCliente(Cliente op)
        {
            try
            {
                ClienteCD.EliminarCliente(op);
                return true;

            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error en el delete del Cliente"+ex);
            }

        }
    }
}
