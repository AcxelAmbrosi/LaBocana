using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    public class Orden
    {
        private int Id_Orden;
        private int Id_Menu;
        private decimal total;
        private string Sugerencia;

        public Orden()
        {
        }

        public Orden(int id_Orden, int id_Menu, decimal total, string sugerencia)
        {
            Id_Orden1 = id_Orden;
            Id_Menu1 = id_Menu;
            this.Total = total;
            Sugerencia1 = sugerencia;
        }

        public int Id_Orden1 { get => Id_Orden; set => Id_Orden = value; }
        public int Id_Menu1 { get => Id_Menu; set => Id_Menu = value; }
        public decimal Total { get => total; set => total = value; }
        public string Sugerencia1 { get => Sugerencia; set => Sugerencia = value; }
    }
}
