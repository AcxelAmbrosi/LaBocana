using Datos.inventario;
using Logica.inventario;
using SistemaLaBocana.Vistas.ControlUsuario;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaLaBocana.Vistas.Panels
{
    public partial class FrmAbrirCaja : Form
    {
        public FrmAbrirCaja()
        {
            InitializeComponent();
        }
       
        private void FrmAbrirCaja_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            InsertarCaja();
            MostrarCaja();
           
        }

        private void InsertarCaja()
        {

            if (!string.IsNullOrEmpty(txtMonto.Text))
            {
                DateTime fechaActual = DateTime.Now;

                Caja parametros = new Caja();
                CajaD funcion = new CajaD();

                parametros.SaldoApertura1 = Convert.ToDecimal(txtMonto.Text);
                parametros.SaldoCierre1 = 0;
                parametros.SaldoActual1 = Convert.ToDecimal(txtMonto.Text);
                parametros.Observacion1 = txtObservacion.Text;
                parametros.Fecha1 = fechaActual;

                if (funcion.InsertarCaja(parametros) == true)
                {
                    MessageBox.Show("Se Ingreso una nueva caja");
                    this.Hide();

                }
            }
            else
            {
                MessageBox.Show("Ingrese un monto para continuar");
            }
           
        }
        public void MostrarCaja()
        {
            DataTable table = new DataTable();
            CajaD funcion = new CajaD();
            funcion.MostrarCaja(ref table);
            FrmCaja.FormPadre.dtgCaja.DataSource = table;
        }

        
       
    }
}
