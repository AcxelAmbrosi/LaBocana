using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    public class Cliente
    {
        private int IdCliente;
        private string Cedula;
        private string Nombres;
        private string Apellidos;
        private string Direccion;
        private string Telefono;
        private int IdMesa;

        public Cliente()
        {
        }

        public Cliente(int idCliente, string cedula, string nombres, string apellidos, string direccion, string telefono, int idMesa)
        {
            IdCliente1 = idCliente;
            Cedula1 = cedula;
            Nombres1 = nombres;
            Apellidos1 = apellidos;
            Direccion1 = direccion;
            Telefono1 = telefono;
            IdMesa1 = idMesa;
        }

        public int IdCliente1 { get => IdCliente; set => IdCliente = value; }
        public string Cedula1 { get => Cedula; set => Cedula = value; }
        public string Nombres1 { get => Nombres; set => Nombres = value; }
        public string Apellidos1 { get => Apellidos; set => Apellidos = value; }
        public string Direccion1 { get => Direccion; set => Direccion = value; }
        public string Telefono1 { get => Telefono; set => Telefono = value; }
        public int IdMesa1 { get => IdMesa; set => IdMesa = value; }
    }
}
