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
    public partial class FrmEditarCliente : Form
    {
        public FrmEditarCliente()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditarCliente();
            MostrarCliente();
        }

        private void FrmEditarCliente_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            if (FrmCliente.FrmClientePadre.dtgCliente.CurrentCell != null)
            {
                txtCedula.Text = Convert.ToString(FrmCliente.FrmClientePadre.dtgCliente.SelectedCells[1].Value);
                txtNombres.Text = Convert.ToString(FrmCliente.FrmClientePadre.dtgCliente.SelectedCells[2].Value);
                txtApellidos.Text = Convert.ToString(FrmCliente.FrmClientePadre.dtgCliente.SelectedCells[3].Value);
                txtDireccion.Text = Convert.ToString(FrmCliente.FrmClientePadre.dtgCliente.SelectedCells[4].Value);
                txtTelefono.Text = Convert.ToString(FrmCliente.FrmClientePadre.dtgCliente.SelectedCells[5].Value);
                cmbMesa.Text = Convert.ToString(FrmCliente.FrmClientePadre.dtgCliente.SelectedCells[6].Value);
            }
            else
            {
                MessageBox.Show("Por favor Seleccione un cliente a editar", "EDITAR CLIENTE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void EditarCliente()
        {
            Cliente parametros = new Cliente();
            ClienteD funcion = new ClienteD();

            if (FrmCliente.FrmClientePadre.dtgCliente.CurrentCell != null)
            {
                parametros.IdCliente1 = Convert.ToInt32(FrmCliente.FrmClientePadre.dtgCliente.SelectedCells[0].Value);
                parametros.Cedula1 = txtCedula.Text;
                parametros.Nombres1 = txtNombres.Text;
                parametros.Apellidos1 = txtApellidos.Text;
                parametros.Direccion1 = txtDireccion.Text;
                parametros.Telefono1 = txtTelefono.Text;
                parametros.IdMesa1 = Convert.ToInt32(cmbMesa.Text);

                if (funcion.EditarCliente(parametros) == true)
                {
                    MessageBox.Show("Se ha modificado correctamente el cliente Seleccionado");
                    this.Hide();

                }

            }
            else
            {
                MessageBox.Show("Por favor Seleccione un cliente a modificar", "EDITAR CLIENTE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        public void MostrarCliente()
        {
            DataTable table = new DataTable();
            ClienteD funcion = new ClienteD();
            funcion.MostrarCliente(ref table);
            FrmCliente.FrmClientePadre.dtgCliente.DataSource = table;
        }
    }
}
