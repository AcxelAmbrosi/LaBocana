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

namespace SistemaLaBocana.Vistas
{
    public partial class Transicion : Form
    {
        public Transicion()
        {
            InitializeComponent();
        }

        private void buttonOrdenar_Click(object sender, EventArgs e)
        {
            Form frm = new PanelMesa();
            frm.Show();
        }
    }
}
