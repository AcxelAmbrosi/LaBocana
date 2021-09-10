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
            if (!string.IsNullOrEmpty(txtCedula.Text) && !string.IsNullOrEmpty(txtNombre.Text)
                && !string.IsNullOrEmpty(txtApellido.Text) && !string.IsNullOrEmpty(txtDireccion.Text)
                && !string.IsNullOrEmpty(txtTelefono.Text))
            {
                InsertarCliente();
                InsertarOrden();
            }
            else
            {
                MessageBox.Show("Por favor,llene todos los campos","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
              
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

                MessageBox.Show("El cliente no se encuentra registrado", "CLIENTES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Clear();
                txtApellido.Clear();
                txtDireccion.Clear();
                txtTelefono.Clear();
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
                    MessageBox.Show("Vaya, eres nuevo. Se registro tu orden.");

                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Llene todos los campos");
            }

        }

        private void InsertarOrden()
        {
            if (!string.IsNullOrEmpty(txtCedula.Text) && !string.IsNullOrEmpty(txtNombre.Text)
                && !string.IsNullOrEmpty(txtApellido.Text) && !string.IsNullOrEmpty(txtDireccion.Text)
                && !string.IsNullOrEmpty(txtTelefono.Text))
            {

                Orden parametros = new Orden();
                OrdenD funcion = new OrdenD();

                parametros.Id_Menu1 = PanelPedido.idMenu;
                parametros.Id_Mesa1 = PanelMesa.NumMesaCarta;
                parametros.Id_Cliente1 = BuscarClienteParaOrden();
                parametros.Total = BuscarMenuParaPrecio();
                parametros.Sugerencia1 = txtSugerencia.Text;

                if (funcion.InsertarOrden(parametros) == true)
                {

                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Llene todos los campos");
            }

        }

        private int BuscarClienteParaOrden()
        {
            int id = 0;
            DataTable table = new DataTable();
            ClienteD funcion = new ClienteD();

            try
            {
                if (!string.IsNullOrEmpty(txtCedula.Text))
                {

                    funcion.BuscarCliente(table, txtCedula.Text);
                    id = Convert.ToInt32(table.Rows[0][0]);

                }
            }
            catch (Exception)
            {


            }
            return id;
        }

        private decimal BuscarMenuParaPrecio()
        {
            decimal precio = 0;
            DataTable table = new DataTable();
            MenuD funcion = new MenuD();

            try
            {


                funcion.BuscarMenu(table, PanelPedido.idMenu.ToString());
                precio = Convert.ToDecimal(table.Rows[0][2]);


            }
            catch (Exception)
            {

            }
            return precio;

        }

    }
}