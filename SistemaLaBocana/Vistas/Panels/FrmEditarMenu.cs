using Datos.inventario;
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
    public partial class FrmEditarMenu : Form
    {
        public FrmEditarMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditarMenu();
            MostrarMenu();
        }
        private void EditarMenu()
        {
            Logica.Menu parametros = new Logica.Menu();
            MenuD funcion = new MenuD();

            if (FrmMenu.FrmMenuPadre.dtgMenu.CurrentCell != null)
            {
                parametros.Id_Menu1 = Convert.ToInt32(FrmMenu.FrmMenuPadre.dtgMenu.SelectedCells[0].Value);
                parametros.Nombre = txtNombre.Text;
                parametros.Precio1 = Convert.ToDecimal(txtPrecio.Text);
              

                if (funcion.EditarMenu(parametros) == true)
                {
                    MessageBox.Show("Se ha modificado correctamente el menu Seleccionado");
                    this.Hide();

                }

            }
            else
            {
                MessageBox.Show("Por favor Seleccione un menu a modificar", "EDITAR MENU", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void FrmEditarMenu_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void CargarDatos()
        {
            if (FrmMenu.FrmMenuPadre.dtgMenu.CurrentCell != null)
            {
                txtNombre.Text = Convert.ToString(FrmMenu.FrmMenuPadre.dtgMenu.SelectedCells[1].Value);
                txtPrecio.Text = Convert.ToString(FrmMenu.FrmMenuPadre.dtgMenu.SelectedCells[2].Value);
                
            }
            else
            {
                MessageBox.Show("Por favor Seleccione un menu a editar", "EDITAR MENU", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        public void MostrarMenu()
        {
            DataTable table = new DataTable();
            MenuD funcion = new MenuD();
            funcion.MostrarMenu(ref table);
            FrmMenu.FrmMenuPadre.dtgMenu.DataSource = table;
        }

    }
}
