using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.inventario
{
    public class Caja
    {
        private int IdCaja;
        private decimal SaldoApertura;
        private decimal SaldoCierre;
        private decimal SaldoActual;
        private string Observacion;
        private DateTime Fecha;

        public Caja()
        {
        }

        public Caja(int idCaja, decimal saldoApertura, decimal saldoCierre, decimal saldoActual, string observacion, DateTime fecha)
        {
            IdCaja1 = idCaja;
            SaldoApertura1 = saldoApertura;
            SaldoCierre1 = saldoCierre;
            SaldoActual1 = saldoActual;
            Observacion1 = observacion;
            Fecha1 = fecha;
        }

        public int IdCaja1 { get => IdCaja; set => IdCaja = value; }
        public decimal SaldoApertura1 { get => SaldoApertura; set => SaldoApertura = value; }
        public decimal SaldoCierre1 { get => SaldoCierre; set => SaldoCierre = value; }
        public decimal SaldoActual1 { get => SaldoActual; set => SaldoActual = value; }
        public string Observacion1 { get => Observacion; set => Observacion = value; }
        public DateTime Fecha1 { get => Fecha; set => Fecha = value; }
    }
}
