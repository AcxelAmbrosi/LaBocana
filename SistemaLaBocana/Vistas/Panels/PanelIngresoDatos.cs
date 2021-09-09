using Datos.inventario;
using Logica;
using SistemaLaBocana.Vistas.ControlUsuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaBocana.Vistas.Panels
{
    public partial class PanelIngresoDatos : Form
    {
        public PanelIngresoDatos()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InsertarCliente();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        private void BuscarCliente()
        {

                DataTable table = new DataTable();
                ClienteD funcion = new ClienteD();

            try
            {
                if (!string.IsNullOrEmpty(txtCedula.Text))
                {

                    funcion.BuscarCliente(table, txtCedula.Text);
                    txtNombre.Text = table.Rows[0][2].ToString();
                    txtApellido.Text = table.Rows[0][3].ToString();
                    txtDireccion.Text = table.Rows[0][4].ToString();
                    txtTelefono.Text = table.Rows[0][5].ToString();
                }
            }
            catch (Exception)
            {

               MessageBox.Show("El cliente no se encuentra registrado","CLIENTES",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            
            }
            
            
            


        }

        private void InsertarCliente()
        {

            if (!string.IsNullOrEmpty(txtCedula.Text) && !string.IsNullOrEmpty(txtNombre.Text)
                && !string.IsNullOrEmpty(txtApellido.Text) && !string.IsNullOrEmpty(txtDireccion.Text)
                && !string.IsNullOrEmpty(txtTelefono.Text))
            {

                Cliente parametros = new Cliente();
                ClienteD funcion = new ClienteD();

                parametros.Cedula1 = txtCedula.Text;
                parametros.Nombres1 = txtNombre.Text;
                parametros.Apellidos1 = txtApellido.Text;
                parametros.Direccion1 = txtDireccion.Text;
                parametros.Telefono1 = txtTelefono.Text;
                parametros.IdMesa1 = PanelMesa.NumMesaCarta;

                if (funcion.InsertarCliente(parametros) == true)
                {
                    MessageBox.Show("Se Ingreso un nuevo cliente");

                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Llene todos los campos");
            }

        }


    }
}
