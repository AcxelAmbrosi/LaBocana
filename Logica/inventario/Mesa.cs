using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    public class Mesa
    {
        private int Id_Mesa;
        private string estado;

        public Mesa()
        {
        }

        public Mesa(int id_Mesa, string estado)
        {
            Id_Mesa1 = id_Mesa;
            this.Estado = estado;
        }

        public int Id_Mesa1 { get => Id_Mesa; set => Id_Mesa = value; }
        public string Estado { get => estado; set => estado = value; }
    }

}
