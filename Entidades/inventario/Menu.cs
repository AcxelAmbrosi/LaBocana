using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Menu
    {
        private int Id_Menu;
        private string nombre;
        private decimal Precio;

        public Menu()
        {
        }

        public Menu(int id_Menu, string nombre, decimal precio)
        {
            Id_Menu1 = id_Menu;
            this.Nombre = nombre;
            Precio1 = precio;
        }

        public int Id_Menu1 { get => Id_Menu; set => Id_Menu = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public decimal Precio1 { get => Precio; set => Precio = value; }
    }
}
