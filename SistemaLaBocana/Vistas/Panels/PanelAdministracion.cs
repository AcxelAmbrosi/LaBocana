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
    public partial class PanelAdministracion : Form
    {
        public PanelAdministracion()
        {
            InitializeComponent();
        }

        private void PanelAdministracion_Load(object sender, EventArgs e)
        {
            panel2.Dock = DockStyle.Fill;
        }

        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            Caja control = new Caja();
            panel2.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panel2.Controls.Add(control);
        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            ControlCliente control = new ControlCliente();
            panel2.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panel2.Controls.Add(control);
        }

        private void buttonMesas_Click(object sender, EventArgs e)
        {
            ControlMesas control = new ControlMesas();
            panel2.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panel2.Controls.Add(control);
        }

        private void buttonPlatillos_Click(object sender, EventArgs e)
        {
            ControlPlatillos control = new ControlPlatillos();
            panel2.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panel2.Controls.Add(control);
        }
    }
}
