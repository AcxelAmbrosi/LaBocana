using Datos.inventario;
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
    public partial class FrmMenu : Form
    {

        public static FrmMenu FrmMenuPadre;
        public FrmMenu()
        {
            InitializeComponent();
            FrmMenu.FrmMenuPadre = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmInsertarMenu frm = new FrmInsertarMenu();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dtgMenu.CurrentCell != null)
            {
                FrmEditarMenu frm = new FrmEditarMenu();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor Seleccione un menu a editar", "EDITAR MENU", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            MostrarMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BuscarMenu();
        }

        public void MostrarMenu()
        {
            DataTable table = new DataTable();
            MenuD funcion = new MenuD();
            funcion.MostrarMenu(ref table);
            dtgMenu.DataSource = table;
        }
        public void BuscarMenu()
        {
            DataTable table = new DataTable();
            MenuD funcion = new MenuD();

            funcion.BuscarMenu(table, txtBuscador.Text);
            dtgMenu.DataSource = table;
        }



    }
}
