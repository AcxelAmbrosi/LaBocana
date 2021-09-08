using Datos.inventario;
using Logica;
using SistemaLaBocana.Vistas.Panels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaBocana.Vistas.ControlUsuario
{
    public partial class FrmCliente : Form
    {
        public static FrmCliente FrmClientePadre;
        public FrmCliente()
        {
            InitializeComponent();
            FrmCliente.FrmClientePadre = this;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (FrmCliente.FrmClientePadre.dtgCliente.CurrentCell != null)
            {
                FrmEditarCliente frm = new FrmEditarCliente();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor Seleccione un cliente a editar", "EDITAR CLIENTE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            MostrarCliente();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            EliminarCliente();
            MostrarCliente();
        }

        public void MostrarCliente()
        {
            DataTable table = new DataTable();
            ClienteD funcion = new ClienteD();
            funcion.MostrarCliente(ref table);
            dtgCliente.DataSource = table;
        }

        public void EliminarCliente()
        {

            Cliente parametros = new Cliente();
            ClienteD funcion = new ClienteD();

            if (dtgCliente.CurrentCell != null)
            {
                var res = MessageBox.Show("¿Esta seguro de eliminar el cliente seleccionadO?", "ELIMINAR CLIENTE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res.ToString().Equals("Yes"))
                {
                    parametros.IdCliente1 = Convert.ToInt32(dtgCliente.SelectedCells[0].Value);

                    if (funcion.EliminarCliente(parametros) == true)
                    {
                        MessageBox.Show("Se ha Eliminado correctamente el cliente Seleccionado", "ELIMINAR CLIENTE");
                    }
                }

            }
            else
            {
                MessageBox.Show("Por favor Seleccione un cliente a eliminar", "ELIMINAR CLIENTE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }
    }
}
