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
    public partial class Caja : UserControl
    {
        public Caja()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmAbrirCaja frm = new FrmAbrirCaja();
            frm.ShowDialog();
        }
    }
}
