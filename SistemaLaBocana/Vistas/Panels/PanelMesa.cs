using Datos.inventario;
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
    public partial class PanelMesa : Form
    {
        public static int NumMesaCarta;
        public static PanelMesa PanelMesaPadre;
        public PanelMesa()
        {
            InitializeComponent();
            PanelMesa.PanelMesaPadre = this;
        }

        private void PanelMesa_Load(object sender, EventArgs e)
        {
           
            if (MostrarEstado("1") == "Preparacio")
            {
                FrmMesas.FrmMesasPadre.button1.BackColor = Color.Green;

                PanelMesa.PanelMesaPadre.btnMesa1.BackColor = Color.Green;
            }
            if (MostrarEstado("2") == "Preparacio")
            {
                FrmMesas.FrmMesasPadre.button2.BackColor = Color.Green;

                PanelMesa.PanelMesaPadre.btnMesa2.BackColor = Color.Green;
            }
            if (MostrarEstado("3") == "Preparacio")
            {
                FrmMesas.FrmMesasPadre.button3.BackColor = Color.Green;

                PanelMesa.PanelMesaPadre.btnMesa3.BackColor = Color.Green;
            }
            if (MostrarEstado("4") == "Preparacio")
            {
                FrmMesas.FrmMesasPadre.button4.BackColor = Color.Green;

                PanelMesa.PanelMesaPadre.btnMesa4.BackColor = Color.Green;
            }
            if (MostrarEstado("5") == "Preparacio")
            {
                FrmMesas.FrmMesasPadre.button5.BackColor = Color.Green;

                PanelMesa.PanelMesaPadre.btnMesa5.BackColor = Color.Green;
            }
            if (MostrarEstado("6") == "Preparacio")
            {
                FrmMesas.FrmMesasPadre.button6.BackColor = Color.Green;

                PanelMesa.PanelMesaPadre.btnMesa6.BackColor = Color.Green;
            }
            if (MostrarEstado("7") == "Preparacio")
            {
                FrmMesas.FrmMesasPadre.button7.BackColor = Color.Green;

                PanelMesa.PanelMesaPadre.btnMesa7.BackColor = Color.Green;
            }
            if (MostrarEstado("8") == "Preparacio")
            {
                FrmMesas.FrmMesasPadre.button8.BackColor = Color.Green;

                PanelMesa.PanelMesaPadre.btnMesa8.BackColor = Color.Green;
            }
            if (MostrarEstado("9") == "Preparacio")
            {
                FrmMesas.FrmMesasPadre.button9.BackColor = Color.Green;

                PanelMesa.PanelMesaPadre.btnMesa9.BackColor = Color.Green;
            }
            if (MostrarEstado("10") == "Preparacio")
            {
                FrmMesas.FrmMesasPadre.button10.BackColor = Color.Green;

                PanelMesa.PanelMesaPadre.btnMesa10.BackColor = Color.Green;
            }
            if (MostrarEstado("11") == "Preparacio")
            {
                FrmMesas.FrmMesasPadre.button11.BackColor = Color.Green;

                PanelMesa.PanelMesaPadre.btnMesa11.BackColor = Color.Green;
            }
            if (MostrarEstado("12") == "Preparacio")
            {
                FrmMesas.FrmMesasPadre.button12.BackColor = Color.Green;

                PanelMesa.PanelMesaPadre.btnMesa12.BackColor = Color.Green;
            }
            if (MostrarEstado("13") == "Preparacio")
            {
                FrmMesas.FrmMesasPadre.button13.BackColor = Color.Green;

                PanelMesa.PanelMesaPadre.btnMesa13.BackColor = Color.Green;
            }
            if (MostrarEstado("14") == "Preparacio")
            {
                FrmMesas.FrmMesasPadre.button14.BackColor = Color.Green;

                PanelMesa.PanelMesaPadre.btnMesa14.BackColor = Color.Green;
            }
            if (MostrarEstado("15") == "Preparacio")
            {
                FrmMesas.FrmMesasPadre.button15.BackColor = Color.Green;

                PanelMesa.PanelMesaPadre.btnMesa15.BackColor = Color.Green;
            }
            if (MostrarEstado("16") == "Preparacio")
            {
                FrmMesas.FrmMesasPadre.button16.BackColor = Color.Green;

                PanelMesa.PanelMesaPadre.btnMesa16.BackColor = Color.Green;
            }
            if (MostrarEstado("17") == "Preparacio")
            {
                FrmMesas.FrmMesasPadre.button17.BackColor = Color.Green;

                PanelMesa.PanelMesaPadre.btnMesa17.BackColor = Color.Green;
            }
            if (MostrarEstado("18") == "Preparacio")
            {
                FrmMesas.FrmMesasPadre.button18.BackColor = Color.Green;

                PanelMesa.PanelMesaPadre.btnMesa18.BackColor = Color.Green;
            }
            if (MostrarEstado("19") == "Preparacio")
            {
                FrmMesas.FrmMesasPadre.button19.BackColor = Color.Green;

                PanelMesa.PanelMesaPadre.btnMesa19.BackColor = Color.Green;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NumMesaCarta = 1;
            
            if (btnMesa1.BackColor == Color.White)
            {
                TraerPago();
            }
            else if (btnMesa1.BackColor == Color.Green)
            {
             
            }
            else if (btnMesa1.BackColor == Color.Red)
            {
              
            }
        }

        private void btnMesa2_Click(object sender, EventArgs e)
        {
            NumMesaCarta = 2;
            if (btnMesa2.BackColor == Color.White)
            {
                TraerPago();
            }
            else if (btnMesa2.BackColor == Color.Green)
            {

            }
            else if (btnMesa2.BackColor == Color.Red)
            {

            }
        }

        private void btnMesa3_Click(object sender, EventArgs e)
        {
            NumMesaCarta = 3;
            if (btnMesa3.BackColor == Color.White)
            {
                TraerPago();
            }
            else if (btnMesa3.BackColor == Color.Green)
            {

            }
            else if (btnMesa3.BackColor == Color.Red)
            {

            }
        }

        private void btnMesa4_Click(object sender, EventArgs e)
        {
            NumMesaCarta = 4;
            if (btnMesa4.BackColor == Color.White)
            {
                TraerPago();
            }
            else if (btnMesa4.BackColor == Color.Green)
            {

            }
            else if (btnMesa4.BackColor == Color.Red)
            {

            }
        }

        private void btnMesa5_Click(object sender, EventArgs e)
        {
            NumMesaCarta = 5;
            if (btnMesa5.BackColor == Color.White)
            {
                TraerPago();
            }
            else if (btnMesa5.BackColor == Color.Green)
            {

            }
            else if (btnMesa5.BackColor == Color.Red)
            {

            }
        }

        private void btnMesa6_Click(object sender, EventArgs e)
        {
            NumMesaCarta = 6;
            if (btnMesa6.BackColor == Color.White)
            {
                TraerPago();
            }
            else if (btnMesa6.BackColor == Color.Green)
            {

            }
            else if (btnMesa6.BackColor == Color.Red)
            {

            }
        }

        private void btnMesa7_Click(object sender, EventArgs e)
        {
            NumMesaCarta = 7;
            if (btnMesa7.BackColor == Color.White)
            {
                TraerPago();
            }
            else if (btnMesa7.BackColor == Color.Green)
            {

            }
            else if (btnMesa7.BackColor == Color.Red)
            {

            }
        }

        private void btnMesa8_Click(object sender, EventArgs e)
        {
            NumMesaCarta = 8;
            if (btnMesa8.BackColor == Color.White)
            {
                TraerPago();
            }
            else if (btnMesa8.BackColor == Color.Green)
            {

            }
            else if (btnMesa8.BackColor == Color.Red)
            {

            }
        }

        private void btnMesa9_Click(object sender, EventArgs e)
        {
            NumMesaCarta = 9;
            if (btnMesa9.BackColor == Color.White)
            {
                TraerPago();
            }
            else if (btnMesa9.BackColor == Color.Green)
            {

            }
            else if (btnMesa9.BackColor == Color.Red)
            {

            }
        }

        private void btnMesa10_Click(object sender, EventArgs e)
        {
            NumMesaCarta = 10;
            if (btnMesa10.BackColor == Color.White)
            {
                TraerPago();
            }
            else if (btnMesa10.BackColor == Color.Green)
            {

            }
            else if (btnMesa10.BackColor == Color.Red)
            {

            }
        }

        private void btnMesa11_Click(object sender, EventArgs e)
        {
            NumMesaCarta = 11;
            if (btnMesa11.BackColor == Color.White)
            {
                TraerPago();
            }
            else if (btnMesa11.BackColor == Color.Green)
            {

            }
            else if (btnMesa11.BackColor == Color.Red)
            {

            }
        }

        private void btnMesa12_Click(object sender, EventArgs e)
        {
            NumMesaCarta = 12;
            if (btnMesa12.BackColor == Color.White)
            {
                TraerPago();
            }
            else if (btnMesa12.BackColor == Color.Green)
            {

            }
            else if (btnMesa12.BackColor == Color.Red)
            {

            }
        }

        private void btnMesa13_Click(object sender, EventArgs e)
        {
            NumMesaCarta = 13;
            if (btnMesa13.BackColor == Color.White)
            {
                TraerPago();
            }
            else if (btnMesa13.BackColor == Color.Green)
            {

            }
            else if (btnMesa13.BackColor == Color.Red)
            {

            }
        }

        private void btnMesa14_Click(object sender, EventArgs e)
        {
            NumMesaCarta = 14;
            if (btnMesa14.BackColor == Color.White)
            {
                TraerPago();
            }
            else if (btnMesa14.BackColor == Color.Green)
            {

            }
            else if (btnMesa14.BackColor == Color.Red)
            {

            }
        }

        private void btnMesa15_Click(object sender, EventArgs e)
        {
            NumMesaCarta = 15;
            if (btnMesa15.BackColor == Color.White)
            {
                TraerPago();
            }
            else if (btnMesa15.BackColor == Color.Green)
            {

            }
            else if (btnMesa15.BackColor == Color.Red)
            {

            }
        }

        private void btnMesa16_Click(object sender, EventArgs e)
        {
            NumMesaCarta = 16;
            if (btnMesa16.BackColor == Color.White)
            {
                TraerPago();
            }
            else if (btnMesa16.BackColor == Color.Green)
            {

            }
            else if (btnMesa16.BackColor == Color.Red)
            {

            }
        }

        private void btnMesa17_Click(object sender, EventArgs e)
        {
            NumMesaCarta = 17;
            if (btnMesa17.BackColor == Color.White)
            {
                TraerPago();
            }
            else if (btnMesa17.BackColor == Color.Green)
            {

            }
            else if (btnMesa17.BackColor == Color.Red)
            {

            }
        }

        private void btnMesa18_Click(object sender, EventArgs e)
        {
            NumMesaCarta = 18;
            if (btnMesa18.BackColor == Color.White)
            {
                TraerPago();
            }
            else if (btnMesa18.BackColor == Color.Green)
            {

            }
            else if (btnMesa18.BackColor == Color.Red)
            {

            }

        }

        private void btnMesa19_Click(object sender, EventArgs e)
        {
            NumMesaCarta = 19;
            if (btnMesa19.BackColor == Color.White)
            {
                TraerPago();
            }
            else if (btnMesa19.BackColor == Color.Green)
            {

            }
            else if (btnMesa19.BackColor == Color.Red)
            {

            }
        }

        private void TraerPedido()
        {
            PanelPedido frm = new PanelPedido();
            frm.ShowDialog();
        }
        private void TraerPago()
        {
            FrmMetodoPago frm = new FrmMetodoPago();
            frm.ShowDialog();
        }

        private String MostrarEstado(string id)
        {
            String estado = "";

            DataTable table = new DataTable();
            MesaD funcion = new MesaD();

            try
            {


                funcion.BuscarMesa( ref table,id);
                estado = Convert.ToString(table.Rows[0][1]);

            }
            catch (Exception)
            {

            }
            return estado;
        }

    }
}
