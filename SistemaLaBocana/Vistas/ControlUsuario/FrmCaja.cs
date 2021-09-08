using Datos.inventario;
using Logica.inventario;
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
    public partial class FrmCaja : Form
    {
        public static FrmCaja FormPadre;
        public FrmCaja()
        {

            InitializeComponent();
            FrmCaja.FormPadre = this;
        }

        int idCaja;

        private void button5_Click(object sender, EventArgs e)
        {
            FrmAbrirCaja frm = new FrmAbrirCaja();
            frm.ShowDialog();


        }

        private void FrmCaja_Load(object sender, EventArgs e)
        {
            MostrarCaja();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            CerrarCaja();
            MostrarCaja();
        }

        public void MostrarCaja()
        {

            DataTable table = new DataTable();
            CajaD funcion = new CajaD();
            funcion.MostrarCaja(ref table);
            dtgCaja.DataSource = table;
        }
        public void CerrarCaja()
        {

            Caja parametros = new Caja();
            CajaD funcion = new CajaD();

            if(dtgCaja.CurrentCell != null)
            {  
                var res = MessageBox.Show("¿Esta seguro de Cerrar la caja seleccionada?", "CERRAR CAJA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res.ToString().Equals("Yes"))
                {
                    idCaja = Convert.ToInt32(dtgCaja.SelectedCells[0].Value);
                    parametros.IdCaja1 = idCaja;

                    if (funcion.CerrarCaja(parametros) == true)
                    {
                        MessageBox.Show("Se ha cerrado correctamente la caja Seleccionada");

                    }
                }
                else
                {
                    MessageBox.Show("La Operacion de caja fue cancelada");
                }

            }
            
        }
        public void AnularCaja()
        {

            Caja parametros = new Caja();
            CajaD funcion = new CajaD();

            if (dtgCaja.CurrentCell != null)
            {
                

                var res = MessageBox.Show("¿Esta seguro de Anular la caja seleccionada?", "ANULAR CAJA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res.ToString().Equals("Yes"))
                {
                    idCaja = Convert.ToInt32(dtgCaja.SelectedCells[0].Value);
                    parametros.IdCaja1 = idCaja;

                    if (funcion.AnularCaja(parametros) == true)
                    {
                        MessageBox.Show("Se Anulo correctamente la caja Seleccionada");

                    }
                }
                else
                {
                    MessageBox.Show("La Anulacion de caja fue cancelada");
                }

            }

        }

        private void dtgCaja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dtgCaja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AnularCaja();
            MostrarCaja();
        }
    }
}
