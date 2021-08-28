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
            TraerForm();
        }

        private void btnOmelette_Click(object sender, EventArgs e)
        {
            TraerForm();
        }

        private void btnHotcake_Click(object sender, EventArgs e)
        {
            TraerForm();
        }

        private void btnHamburguesa_Click(object sender, EventArgs e)
        {
            TraerForm();
        }

        private void btnParrillada_Click(object sender, EventArgs e)
        {
            TraerForm();
        }

        private void btnPizza_Click(object sender, EventArgs e)
        {
            TraerForm();
        }

        private void btnPasta_Click(object sender, EventArgs e)
        {
            TraerForm();
        }

        private void btnLasagna_Click(object sender, EventArgs e)
        {
            TraerForm();
        }

        private void btnBurrito_Click(object sender, EventArgs e)
        {
            TraerForm();
        }

        private void btnGaseosas_Click(object sender, EventArgs e)
        {
            TraerForm();
        }

        private void btnRefresco_Click(object sender, EventArgs e)
        {
            TraerForm();
        }

        private void btnMalteadas_Click(object sender, EventArgs e)
        {
            TraerForm();
        }

        private void btnCafe_Click(object sender, EventArgs e)
        {
            TraerForm();
        }

        private void btnChocolate_Click(object sender, EventArgs e)
        {
            TraerForm();
        }
    }
}
