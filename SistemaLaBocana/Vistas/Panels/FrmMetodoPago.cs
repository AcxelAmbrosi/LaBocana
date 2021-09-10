using Datos.inventario;
using Logica;
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
    public partial class FrmMetodoPago : Form
    {
        public FrmMetodoPago()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {


                if (PanelMesa.NumMesaCarta == 1)
                {
                    FrmMesas.FrmMesasPadre.button1.BackColor = Color.Green;

                    PanelMesa.PanelMesaPadre.btnMesa1.BackColor = Color.Green;
                    CambiarEstadoPreparacion();


                }
                if (PanelMesa.NumMesaCarta == 2)
                {
                    FrmMesas.FrmMesasPadre.button2.BackColor = Color.Green;
                    PanelMesa.PanelMesaPadre.btnMesa2.BackColor = Color.Green;
                    CambiarEstadoPreparacion();
                }
                if (PanelMesa.NumMesaCarta == 3)
                {
                    FrmMesas.FrmMesasPadre.button3.BackColor = Color.Green;
                    PanelMesa.PanelMesaPadre.btnMesa3.BackColor = Color.Green;
                    CambiarEstadoPreparacion();
                }
                if (PanelMesa.NumMesaCarta == 4)
                {
                    FrmMesas.FrmMesasPadre.button4.BackColor = Color.Green;
                    PanelMesa.PanelMesaPadre.btnMesa4.BackColor = Color.Green;
                    CambiarEstadoPreparacion();
                }
                if (PanelMesa.NumMesaCarta == 5)
                {
                    FrmMesas.FrmMesasPadre.button5.BackColor = Color.Green;
                    PanelMesa.PanelMesaPadre.btnMesa5.BackColor = Color.Green;
                    CambiarEstadoPreparacion();
                }
                if (PanelMesa.NumMesaCarta == 6)
                {
                    FrmMesas.FrmMesasPadre.button6.BackColor = Color.Green;
                    PanelMesa.PanelMesaPadre.btnMesa6.BackColor = Color.Green;
                    CambiarEstadoPreparacion();
                }
                if (PanelMesa.NumMesaCarta == 7)
                {
                    FrmMesas.FrmMesasPadre.button7.BackColor = Color.Green;
                    PanelMesa.PanelMesaPadre.btnMesa7.BackColor = Color.Green;
                    CambiarEstadoPreparacion();
                }
                if (PanelMesa.NumMesaCarta == 8)
                {
                    FrmMesas.FrmMesasPadre.button8.BackColor = Color.Green;
                    PanelMesa.PanelMesaPadre.btnMesa8.BackColor = Color.Green;
                    CambiarEstadoPreparacion();
                }
                if (PanelMesa.NumMesaCarta == 9)
                {
                    FrmMesas.FrmMesasPadre.button9.BackColor = Color.Green;
                    PanelMesa.PanelMesaPadre.btnMesa9.BackColor = Color.Green;
                    CambiarEstadoPreparacion();
                }
                if (PanelMesa.NumMesaCarta == 10)
                {
                    FrmMesas.FrmMesasPadre.button10.BackColor = Color.Green;
                    PanelMesa.PanelMesaPadre.btnMesa10.BackColor = Color.Green;
                    CambiarEstadoPreparacion();
                }
                if (PanelMesa.NumMesaCarta == 11)
                {
                    FrmMesas.FrmMesasPadre.button11.BackColor = Color.Green;
                    PanelMesa.PanelMesaPadre.btnMesa11.BackColor = Color.Green;
                    CambiarEstadoPreparacion();
                }
                if (PanelMesa.NumMesaCarta == 12)
                {
                    FrmMesas.FrmMesasPadre.button12.BackColor = Color.Green;
                    PanelMesa.PanelMesaPadre.btnMesa12.BackColor = Color.Green;
                    CambiarEstadoPreparacion();
                }
                if (PanelMesa.NumMesaCarta == 13)
                {
                    FrmMesas.FrmMesasPadre.button13.BackColor = Color.Green;
                    PanelMesa.PanelMesaPadre.btnMesa13.BackColor = Color.Green;
                    CambiarEstadoPreparacion();
                }
                if (PanelMesa.NumMesaCarta == 14)
                {
                    FrmMesas.FrmMesasPadre.button14.BackColor = Color.Green;
                    PanelMesa.PanelMesaPadre.btnMesa14.BackColor = Color.Green;
                    CambiarEstadoPreparacion();
                }
                if (PanelMesa.NumMesaCarta == 15)
                {
                    FrmMesas.FrmMesasPadre.button15.BackColor = Color.Green;
                    PanelMesa.PanelMesaPadre.btnMesa15.BackColor = Color.Green;
                    CambiarEstadoPreparacion();
                }
                if (PanelMesa.NumMesaCarta == 16)
                {
                    FrmMesas.FrmMesasPadre.button16.BackColor = Color.Green;
                    PanelMesa.PanelMesaPadre.btnMesa16.BackColor = Color.Green;
                    CambiarEstadoPreparacion();
                }
                if (PanelMesa.NumMesaCarta == 17)
                {
                    FrmMesas.FrmMesasPadre.button17.BackColor = Color.Green;
                    PanelMesa.PanelMesaPadre.btnMesa17.BackColor = Color.Green;
                    CambiarEstadoPreparacion();
                }
                if (PanelMesa.NumMesaCarta == 18)
                {
                    FrmMesas.FrmMesasPadre.button18.BackColor = Color.Green;
                    PanelMesa.PanelMesaPadre.btnMesa18.BackColor = Color.Green;
                    CambiarEstadoPreparacion();
                }
                if (PanelMesa.NumMesaCarta == 19)
                {
                    FrmMesas.FrmMesasPadre.button19.BackColor = Color.Green;
                    PanelMesa.PanelMesaPadre.btnMesa19.BackColor = Color.Green;
                    CambiarEstadoPreparacion();
                }

                TrearPanelPedido();
                this.Close();

            }
            catch (Exception)
            {

                MessageBox.Show("Por favor, ingrese al panel administrativo para iniciar el sistema correctamente.", 
                    "ADVERTENCIA",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }
        private void TrearPanelPedido()
        {
            PanelPedido frm = new PanelPedido();
            frm.ShowDialog();
        }

        private void CambiarEstadoPreparacion()
        {
            Mesa parametros = new Mesa();
            MesaD funcion = new MesaD();

            parametros.Id_Mesa1 = PanelMesa.NumMesaCarta;
            parametros.Estado = "Preparacio";

            funcion.CambiarEstado(parametros);

        }
    }
}
