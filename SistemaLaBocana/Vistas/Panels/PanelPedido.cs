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
    public partial class PanelPedido : Form
    {
        public static int idMenu;
        public PanelPedido()
        {
            InitializeComponent();
        }

        private void TraerForm()
        {
            PanelIngresoDatos frm = new PanelIngresoDatos();
            frm.ShowDialog();
        }
        private void PanelPedido_Load(object sender, EventArgs e)
        {

        }

        private void btnHuevos_Click(object sender, EventArgs e)
        {
            idMenu = 1;
            TraerForm();
        }

        private void btnOmelette_Click(object sender, EventArgs e)
        {
            idMenu = 2;
            TraerForm();
        }

        private void btnHotcake_Click(object sender, EventArgs e)
        {
            idMenu = 3;
            TraerForm();
        }

        private void btnHamburguesa_Click(object sender, EventArgs e)
        {
            idMenu = 4;
            TraerForm();
        }

        private void btnParrillada_Click(object sender, EventArgs e)
        {
            idMenu = 5;
            TraerForm();
        }

        private void btnPizza_Click(object sender, EventArgs e)
        {
            idMenu = 6;
            TraerForm();
        }

        private void btnPasta_Click(object sender, EventArgs e)
        {
            idMenu = 7;
            TraerForm();
        }

        private void btnLasagna_Click(object sender, EventArgs e)
        {
            idMenu = 8;
            TraerForm();
        }

        private void btnBurrito_Click(object sender, EventArgs e)
        {
            idMenu = 9;
            TraerForm();
        }

        private void btnGaseosas_Click(object sender, EventArgs e)
        {
            idMenu = 10;
            TraerForm();
        }

        private void btnRefresco_Click(object sender, EventArgs e)
        {
            idMenu = 11;
            TraerForm();
        }

        private void btnMalteadas_Click(object sender, EventArgs e)
        {
            idMenu = 12;
            TraerForm();
        }

        private void btnCafe_Click(object sender, EventArgs e)
        {
            idMenu = 13;
            TraerForm();
        }

        private void btnChocolate_Click(object sender, EventArgs e)
        {
            idMenu = 14;
            TraerForm();
        }
    }
}
