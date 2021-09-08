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
            this.Close();
        }

        /// <summary>
        /// Revisar el codigo
        /// </summary>
        //private void InsertarCliente()
        //{

        //    if (!string.IsNullOrEmpty(txtCedula.Text) && !string.IsNullOrEmpty(txtNombres.Text)
        //        && !string.IsNullOrEmpty(txtApellidos.Text) && !string.IsNullOrEmpty(txtDireccion.Text)
        //        && !string.IsNullOrEmpty(txtTelefono.Text))
        //    {

        //        Cliente parametros = new Cliente();
        //        ClienteD funcion = new ClienteD();

        //        parametros.Cedula1 = txtCedula.Text;
        //        parametros.Nombres1 = txtNombres.Text;
        //        parametros.Apellidos1 = txtApellidos.Text;
        //        parametros.Direccion1 = txtDireccion.Text;
        //        parametros.Telefono1 = txtTelefono.Text;
        //        parametros.IdMesa1 = FrmMesas.NumMesa;

        //        if (funcion.InsertarCliente(parametros) == true)
        //        {
        //            MessageBox.Show("Se Ingreso una nueva caja");
        //            this.Hide();

        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Ingrese un monto para continuar");
        //    }

        //}
    }
}
