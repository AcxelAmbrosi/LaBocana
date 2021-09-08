using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.inventario
{
    public class Bases
    {
        private int idmesa;

        public Bases()
        {
        }

        public Bases(int idmesa)
        {
            this.Idmesa = idmesa;
        }

        public int Idmesa { get => idmesa; set => idmesa = value; }
    }
}
