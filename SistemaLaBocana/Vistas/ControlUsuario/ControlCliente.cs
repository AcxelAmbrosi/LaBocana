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
    public partial class ControlCliente : UserControl
    {
        public ControlCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmEditarCliente frm = new FrmEditarCliente();
            frm.ShowDialog();
        }
    }
}
