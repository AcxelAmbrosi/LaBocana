using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.inventario
{
    public class MenuCD
    {
        public static void InsertarMenu(Menu oc)
        {
            DBLaBocanaDataContext DB = null;
            try
            {
                using (DB = new DBLaBocanaDataContext())
                {
                    DB.InsertarMenu(oc.Nombre, oc.Precio1);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al insertar Menu.", ex);
            }
            finally
            {
                DB = null;
            }

        }
        public static void ActualizarMenu(Menu op)
        {
            DBLaBocanaDataContext DB = null;
            try
            {
                using (DB = new DBLaBocanaDataContext())
                {
                    DB.EditarMenu(op.Id_Menu1, op.Nombre, op.Precio1);
                    DB.SubmitChanges();
                }

            }
            catch (Exception ex)
            {

                throw new DatosExcepciones("Error al modificar el menu", ex);
            }
            finally
            {

                DB = null;
            }


        }
        public static void EliminarMenu(Menu op)
        {
            DBLaBocanaDataContext DB = null;
            try
            {
                using (DB = new DBLaBocanaDataContext())
                {
                    DB.EliminarMenu(op.Id_Menu1);
                    DB.SubmitChanges();
                }

            }
            catch (Exception ex)
            {

                throw new DatosExcepciones("Error al eliminar el menu", ex);
            }
            finally
            {

                DB = null;
            }


        }
    }
}
