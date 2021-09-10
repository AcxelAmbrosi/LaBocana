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
    public partial class FrmMesas : Form
    {
        public static int NumMesa;
        public static FrmMesas FrmMesasPadre;

        public FrmMesas()
        {
            InitializeComponent();
            FrmMesas.FrmMesasPadre = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
