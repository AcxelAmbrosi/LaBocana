using Entidades.inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.inventario
{
    public class CajaCD
    {
        public static List<CAJA> MostrarCaja()
        {
            DBLaBocanaDataContext DB = null;
            try
            {
                using (DB = new DBLaBocanaDataContext())
                {
                    return DB.CAJA.ToList();
                }

            }
            catch (Exception ex)
            {

                throw new DatosExcepciones("Erro al listar la caja", ex);
            }
            finally
            {

                DB = null;
            }


        }
        public static void AbrirCaja(Caja cj)
        {
            DBLaBocanaDataContext DB = null;
            try
            {
                using (DB = new DBLaBocanaDataContext())
                {
                    DB.InsertarCaja( cj.SaldoApertura1, cj.SaldoCierre1, cj.SaldoActual1, cj.Observacion1, cj.Fecha1);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al Abrir Caja.", ex);
            }
            finally
            {
                DB = null;
            }

        }
        public static void AnularCaja(Caja op)
        {
            DBLaBocanaDataContext DB = null;
            try
            {
                using (DB = new DBLaBocanaDataContext())
                {
                    DB.AnularCaja(op.IdCaja1);
                    DB.SubmitChanges();
                }

            }
            catch (Exception ex)
            {

                throw new DatosExcepciones("Error al anular la caja", ex);
            }
            finally
            {

                DB = null;
            }
        }
        public static void CerrarCaja(Caja op)
        {
            DBLaBocanaDataContext DB = null;
            try
            {
                using (DB = new DBLaBocanaDataContext())
                {
                    DB.CerrarCaja(op.IdCaja1);
                    DB.SubmitChanges();
                }

            }
            catch (Exception ex)
            {

                throw new DatosExcepciones("Error al Cerrar la caja", ex);
            }
            finally
            {

                DB = null;
            }


        }
    }
}
