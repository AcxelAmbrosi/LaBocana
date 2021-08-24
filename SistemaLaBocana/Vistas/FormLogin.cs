using SistemaLaBocana.Vistas;
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

namespace SistemaLaBocana
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        //Reemplaza un panel
        private void AbrirFrm(Object frmPanel)
        {
            if (this.PanelBase.Controls.Count > 0)
                this.PanelBase.Controls.RemoveAt(0);
            Form frm = frmPanel as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.PanelBase.Controls.Add(frm);
            this.PanelBase.Tag = frm;
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            Form frm = new PanelMesa();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonIniciar.Hide();
            AbrirFrm(new PanelSesion());
        }
    }
}
