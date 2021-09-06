using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.inventario
{
    public class ClienteCD
    {
        public static List<CLIENTE> ListarCliente()
        {
            DBLaBocanaDataContext DB = null;
            try
            {
                using (DB = new DBLaBocanaDataContext())
                {
                    return DB.CLIENTE.ToList();
                }

            }
            catch (Exception ex)
            {

                throw new DatosExcepciones("Erro al listar el Cliente", ex);
            }
            finally
            {

                DB = null;
            }
        }
        public static void InsertarCliente(Cliente oc)
        {
            DBLaBocanaDataContext DB = null;
            try
            {
                using (DB = new DBLaBocanaDataContext())
                {
                    DB.InsertarCliente(oc.Cedula1, oc.Nombres1, oc.Apellidos1, oc.Direccion1, oc.Telefono1,oc.IdMesa1);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al insertar Cliente.", ex);
            }
            finally
            {
                DB = null;
            }

        }

        public static void ActualizarCliente(Cliente op)
        {
            DBLaBocanaDataContext DB = null;
            try
            {
                using (DB = new DBLaBocanaDataContext())
                {
                    DB.EditarCliente(op.IdCliente1, op.Cedula1, op.Nombres1, op.Apellidos1, op.Direccion1, op.Telefono1, op.IdMesa1);
                    DB.SubmitChanges();
                }

            }
            catch (Exception ex)
            {

                throw new DatosExcepciones("Error al modificar el cliente", ex);
            }
            finally
            {

                DB = null;
            }


        }
        public static void EliminarCliente(Cliente op)
        {
            DBLaBocanaDataContext DB = null;
            try
            {
                using (DB = new DBLaBocanaDataContext())
                {
                    DB.EliminarCliente(op.IdCliente1);
                    DB.SubmitChanges();
                }

            }
            catch (Exception ex)
            {

                throw new DatosExcepciones("Error al eliminar un cliente", ex);
            }
            finally
            {

                DB = null;
            }
        }
    }
}
