using Entidades.inventario;
using Logica.inventario;
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
    public partial class FrmAbrirCaja : Form
    {
        public FrmAbrirCaja()
        {
            InitializeComponent();
        }

        public int opc;
        CajaLN mln = new CajaLN();
        private bool validarDatos()
        {
            bool verificar = true;
            if (txtMonto.Text.Trim().Length == 0 && txtObservacion.Text.Trim().Length == 0)
            {
                verificar = false;
            }
            return verificar;
        }
        public Caja crearObjeto()
        {
            decimal saldoApertura = Convert.ToDecimal(txtMonto.Text);
            decimal saldoActual = Convert.ToDecimal(txtMonto.Text);
            string observacion = txtObservacion.Text;
            DateTime fecha = DateTime.Now;
            Caja op = new Caja(23,saldoApertura, 0, saldoActual, observacion, fecha);
            return op;
        }

        private void guardar()
        {
            try
            {
                if (validarDatos())
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("Los campos con(*) son obligatorios");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void nuevo()
        {
            Caja op = crearObjeto();
            mln.OpenCaja(op);
        }
        private void FrmAbrirCaja_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            guardar();
        }
    }
}
