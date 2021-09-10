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
            if (PanelMesa.NumMesaCarta == 1)
            {
                PanelMesa.PanelMesaPadre.btnMesa1.BackColor = Color.Green;
                FrmMesas.FrmMesasPadre.button1.BackColor = Color.Green;

            }
            if (PanelMesa.NumMesaCarta == 2)
            {
                PanelMesa.PanelMesaPadre.btnMesa2.BackColor = Color.Green;
                FrmMesas.FrmMesasPadre.button2.BackColor = Color.Green;

            }
            if (PanelMesa.NumMesaCarta == 3)
            {
                PanelMesa.PanelMesaPadre.btnMesa3.BackColor = Color.Green;
                FrmMesas.FrmMesasPadre.button3.BackColor = Color.Green;

            }
            if (PanelMesa.NumMesaCarta == 4)
            {
                PanelMesa.PanelMesaPadre.btnMesa4.BackColor = Color.Green;
                FrmMesas.FrmMesasPadre.button4.BackColor = Color.Green;

            }
            if (PanelMesa.NumMesaCarta == 5)
            {
                PanelMesa.PanelMesaPadre.btnMesa5.BackColor = Color.Green;
                FrmMesas.FrmMesasPadre.button5.BackColor = Color.Green;

            }
            if (PanelMesa.NumMesaCarta == 6)
            {
                PanelMesa.PanelMesaPadre.btnMesa6.BackColor = Color.Green;
                FrmMesas.FrmMesasPadre.button6.BackColor = Color.Green;

            }
            if (PanelMesa.NumMesaCarta == 7)
            {
                PanelMesa.PanelMesaPadre.btnMesa7.BackColor = Color.Green;
                FrmMesas.FrmMesasPadre.button7.BackColor = Color.Green;

            }
            if (PanelMesa.NumMesaCarta == 8)
            {
                PanelMesa.PanelMesaPadre.btnMesa8.BackColor = Color.Green;
                FrmMesas.FrmMesasPadre.button8.BackColor = Color.Green;

            }
            if (PanelMesa.NumMesaCarta == 9)
            {
                PanelMesa.PanelMesaPadre.btnMesa9.BackColor = Color.Green;
                FrmMesas.FrmMesasPadre.button9.BackColor = Color.Green;

            }
            if (PanelMesa.NumMesaCarta == 10)
            {
                PanelMesa.PanelMesaPadre.btnMesa10.BackColor = Color.Green;
                FrmMesas.FrmMesasPadre.button10.BackColor = Color.Green;

            }
            if (PanelMesa.NumMesaCarta == 11)
            {
                PanelMesa.PanelMesaPadre.btnMesa11.BackColor = Color.Green;
                FrmMesas.FrmMesasPadre.button11.BackColor = Color.Green;

            }
            if (PanelMesa.NumMesaCarta == 12)
            {
                PanelMesa.PanelMesaPadre.btnMesa12.BackColor = Color.Green;
                FrmMesas.FrmMesasPadre.button12.BackColor = Color.Green;

            }
            if (PanelMesa.NumMesaCarta == 13)
            {
                PanelMesa.PanelMesaPadre.btnMesa13.BackColor = Color.Green;
                FrmMesas.FrmMesasPadre.button13.BackColor = Color.Green;

            }
            if (PanelMesa.NumMesaCarta == 14)
            {
                PanelMesa.PanelMesaPadre.btnMesa14.BackColor = Color.Green;
                FrmMesas.FrmMesasPadre.button14.BackColor = Color.Green;

            }
            if (PanelMesa.NumMesaCarta == 15)
            {
                PanelMesa.PanelMesaPadre.btnMesa15.BackColor = Color.Green;
                FrmMesas.FrmMesasPadre.button15.BackColor = Color.Green;

            }
            if (PanelMesa.NumMesaCarta == 16)
            {
                PanelMesa.PanelMesaPadre.btnMesa16.BackColor = Color.Green;
                FrmMesas.FrmMesasPadre.button16.BackColor = Color.Green;

            }
            if (PanelMesa.NumMesaCarta == 17)
            {
                PanelMesa.PanelMesaPadre.btnMesa17.BackColor = Color.Green;
                FrmMesas.FrmMesasPadre.button17.BackColor = Color.Green;

            }
            if (PanelMesa.NumMesaCarta == 18)
            {
                PanelMesa.PanelMesaPadre.btnMesa18.BackColor = Color.Green;
                FrmMesas.FrmMesasPadre.button18.BackColor = Color.Green;

            }
            if (PanelMesa.NumMesaCarta == 19)
            {
                PanelMesa.PanelMesaPadre.btnMesa19.BackColor = Color.Green;
                FrmMesas.FrmMesasPadre.button19.BackColor = Color.Green;

            }
            TrearPanelPedido();
            this.Close();
        }
        private void TrearPanelPedido()
        {
            PanelPedido frm = new PanelPedido();
            frm.ShowDialog();
        }
    }
}
