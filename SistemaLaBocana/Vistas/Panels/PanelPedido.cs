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

        
        private void TraerIngresoDatos()
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
            TraerIngresoDatos();
        }

        private void btnOmelette_Click(object sender, EventArgs e)
        {
            idMenu = 2;
            TraerIngresoDatos();
        }

        private void btnHotcake_Click(object sender, EventArgs e)
        {
            idMenu = 3;
            TraerIngresoDatos();
        }

        private void btnHamburguesa_Click(object sender, EventArgs e)
        {
            idMenu = 4;
            TraerIngresoDatos();
        }

        private void btnParrillada_Click(object sender, EventArgs e)
        {
            idMenu = 5;
            TraerIngresoDatos();
        }

        private void btnPizza_Click(object sender, EventArgs e)
        {
            idMenu = 6;
            TraerIngresoDatos();
        }

        private void btnPasta_Click(object sender, EventArgs e)
        {
            idMenu = 7;
            TraerIngresoDatos();
        }

        private void btnLasagna_Click(object sender, EventArgs e)
        {
            idMenu = 8;
            TraerIngresoDatos();
        }

        private void btnBurrito_Click(object sender, EventArgs e)
        {
            idMenu = 9;
            TraerIngresoDatos();
        }

        private void btnGaseosas_Click(object sender, EventArgs e)
        {
            idMenu = 10;
            TraerIngresoDatos();
        }

        private void btnRefresco_Click(object sender, EventArgs e)
        {
            idMenu = 11;
            TraerIngresoDatos();
        }

        private void btnMalteadas_Click(object sender, EventArgs e)
        {
            idMenu = 12;
            TraerIngresoDatos();
        }

        private void btnCafe_Click(object sender, EventArgs e)
        {
            idMenu = 13;
            TraerIngresoDatos();
        }

        private void btnChocolate_Click(object sender, EventArgs e)
        {
            idMenu = 14;
            TraerIngresoDatos();
        }
    }
}
