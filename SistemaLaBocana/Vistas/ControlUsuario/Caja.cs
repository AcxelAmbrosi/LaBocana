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
    public partial class Caja : UserControl
    {
        public Caja()
        {
            InitializeComponent();
        }

        CajaLN oppln = new CajaLN();
        public DataGridView dato;
        public Caja auxiliar;

        //Muestra la caja
        public void MostrarCaja()
        {
            dtgCaja.DataSource = oppln.ViewCaja();
        }

        //Agrega Nueva caja
        public void nuevo()
        {
            try
            {
                FrmAbrirCaja fec = new FrmAbrirCaja();
                fec.Text = "Ingresar Caja";
                fec.opc = 1;
                fec.ShowDialog();
                if (fec.DialogResult == DialogResult.OK)
                {
                    Caja op = fec.crearObjeto();
                    oppln.OpenCaja(op);
                    fec.Close();
                    MessageBox.Show("Se ha ingresado la caja...");
                }
                else
                {
                    fec.Close();
                    MessageBox.Show("Ingreso cancelado...");
                }
                MostrarCaja();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al insertar caja " + ex.Message);
            }
        }

        //Anula la caja
        public void Eliminar()
        {
            try
            {
                if (dtgCaja.CurrentCell != null)
                {
                    var res = MessageBox.Show("¿Esta seguro de Anular?", "Eliminar", MessageBoxButtons.YesNo);
                    if (res.ToString().Equals("Yes"))
                    {
                        CajaLN loc = new CajaLN();
                        Caja objeto = dtgCaja.CurrentRow.DataBoundItem as Caja;

                        loc.DeleteCaja(objeto);
                        MessageBox.Show("Se ha anulado la caja seleccionada");
                    }
                    else
                    {
                        MessageBox.Show("Anulacion cancelada");
                    }
                }

                MostrarCaja();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Cerrar caja

        public void CerrarCaja()
        {
            try
            {
                if (dtgCaja.CurrentCell != null)
                {
                    var res = MessageBox.Show("¿Esta seguro de Cerrar la caja?", "Cerrar", MessageBoxButtons.YesNo);
                    if (res.ToString().Equals("Yes"))
                    {
                        CajaLN loc = new CajaLN();
                        Caja objeto = dtgCaja.CurrentRow.DataBoundItem as Caja;

                        loc.CloseCaja(objeto);
                        MessageBox.Show("Se ha cerrado la caja seleccionada");
                    }
                    else
                    {
                        MessageBox.Show("No se cerro la caja seleccionada");
                    }
                }

                MostrarCaja();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmAbrirCaja frm = new FrmAbrirCaja();
            frm.ShowDialog();
        }
    }
}
