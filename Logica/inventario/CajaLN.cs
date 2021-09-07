using Datos;
using Datos.inventario;
using Entidades.inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.inventario
{
    public class CajaLN
    {
        public List<Caja> ViewCaja()
        {
            List<Caja> Lista = new List<Caja>();
            Caja oc = null;
            try
            {
                List<CAJA> auxlista = CajaCD.MostrarCaja();
                foreach (CAJA olp in auxlista)
                {
                    oc = new Caja(olp.Id_Caja, Convert.ToDecimal(olp.SaldoApertura), Convert.ToDecimal(olp.SaldoCierre), Convert.ToDecimal(olp.SaldoActual), olp.Observacion, Convert.ToDateTime(olp.Fecha));
                    Lista.Add(oc);

                }
                return Lista;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error Mostrar en la logica la categoria" +ex);
            }

        }
        public bool OpenCaja(Caja cj)
        {
            try
            {
                CajaCD.AbrirCaja(cj);
                return true;

            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al abrir caja" + ex);
            }

        }
        public bool DeleteCaja(Caja op)
        {
            try
            {
                CajaCD.AnularCaja(op);
                return true;

            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al anular caja " + ex);
            }

        }
        public bool CloseCaja(Caja op)
        {
            try
            {
                CajaCD.CerrarCaja(op);
                return true;

            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error en el cerrar caja" + ex);
            }

        }

        public void DeleteCaja(global::SistemaLaBocana.Vistas.ControlUsuario.Caja objeto)
        {
            throw new NotImplementedException();
        }
    }
}
