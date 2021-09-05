using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Mesa
    {
        private int Id_Mesa;
        private string estado;
        private int Id_Orden;

        public Mesa()
        {
        }

        public Mesa(int id_Mesa, string estado, int id_Orden)
        {
            Id_Mesa1 = id_Mesa;
            this.Estado = estado;
            Id_Orden1 = id_Orden;
        }

        public int Id_Mesa1 { get => Id_Mesa; set => Id_Mesa = value; }
        public string Estado { get => estado; set => estado = value; }
        public int Id_Orden1 { get => Id_Orden; set => Id_Orden = value; }
    }

}
