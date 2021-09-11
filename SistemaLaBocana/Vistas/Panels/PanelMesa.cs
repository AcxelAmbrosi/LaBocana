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

                PanelMesa.PanelMesaPadre.btnMesa1.BackColor = Color.Green;
            }
            if (MostrarEstado("1") == "Ocupado")
            {

                PanelMesa.PanelMesaPadre.btnMesa1.BackColor = Color.Red;
            }
            if (MostrarEstado("2") == "Preparacio")
            {

                PanelMesa.PanelMesaPadre.btnMesa2.BackColor = Color.Green;
            }
            if (MostrarEstado("2") == "Ocupado")
            {

                PanelMesa.PanelMesaPadre.btnMesa2.BackColor = Color.Red;
            }
            if (MostrarEstado("3") == "Preparacio")
            {

                PanelMesa.PanelMesaPadre.btnMesa3.BackColor = Color.Green;
            }
            if (MostrarEstado("3") == "Ocupado")
            {

                PanelMesa.PanelMesaPadre.btnMesa3.BackColor = Color.Red;
            }
            if (MostrarEstado("4") == "Preparacio")
            {

                PanelMesa.PanelMesaPadre.btnMesa4.BackColor = Color.Green;
            }
            if (MostrarEstado("4") == "Ocupado")
            {

                PanelMesa.PanelMesaPadre.btnMesa4.BackColor = Color.Red;
            }
            if (MostrarEstado("5") == "Preparacio")
            {

                PanelMesa.PanelMesaPadre.btnMesa5.BackColor = Color.Green;
            }
            if (MostrarEstado("5") == "Ocupado")
            {

                PanelMesa.PanelMesaPadre.btnMesa5.BackColor = Color.Red;
            }
            if (MostrarEstado("6") == "Preparacio")
            {

                PanelMesa.PanelMesaPadre.btnMesa6.BackColor = Color.Green;
            }
            if (MostrarEstado("6") == "Ocupado")
            {

                PanelMesa.PanelMesaPadre.btnMesa6.BackColor = Color.Red;
            }
            if (MostrarEstado("7") == "Preparacio")
            {

                PanelMesa.PanelMesaPadre.btnMesa7.BackColor = Color.Green;
            }
            if (MostrarEstado("7") == "Ocupado")
            {

                PanelMesa.PanelMesaPadre.btnMesa7.BackColor = Color.Red;
            }
            if (MostrarEstado("8") == "Preparacio")
            {

                PanelMesa.PanelMesaPadre.btnMesa8.BackColor = Color.Green;
            }
            if (MostrarEstado("8") == "Ocupado")
            {

                PanelMesa.PanelMesaPadre.btnMesa8.BackColor = Color.Red;
            }
            if (MostrarEstado("9") == "Preparacio")
            {

                PanelMesa.PanelMesaPadre.btnMesa9.BackColor = Color.Green;
            }
            if (MostrarEstado("9") == "Ocupado")
            {

                PanelMesa.PanelMesaPadre.btnMesa9.BackColor = Color.Red;
            }
            if (MostrarEstado("10") == "Preparacio")
            {

                PanelMesa.PanelMesaPadre.btnMesa10.BackColor = Color.Green;
            }
            if (MostrarEstado("10") == "Ocupado")
            {

                PanelMesa.PanelMesaPadre.btnMesa10.BackColor = Color.Red;
            }
            if (MostrarEstado("11") == "Preparacio")
            {

                PanelMesa.PanelMesaPadre.btnMesa11.BackColor = Color.Green;
            }
            if (MostrarEstado("11") == "Ocupado")
            {

                PanelMesa.PanelMesaPadre.btnMesa11.BackColor = Color.Red;
            }
            if (MostrarEstado("12") == "Preparacio")
            {

                PanelMesa.PanelMesaPadre.btnMesa12.BackColor = Color.Green;
            }
            if (MostrarEstado("12") == "Ocupado")
            {

                PanelMesa.PanelMesaPadre.btnMesa12.BackColor = Color.Red;
            }
            if (MostrarEstado("13") == "Preparacio")
            {

                PanelMesa.PanelMesaPadre.btnMesa13.BackColor = Color.Green;
            }
            if (MostrarEstado("13") == "Ocupado")
            {

                PanelMesa.PanelMesaPadre.btnMesa13.BackColor = Color.Red;
            }
            if (MostrarEstado("14") == "Preparacio")
            {

                PanelMesa.PanelMesaPadre.btnMesa14.BackColor = Color.Green;
            }
            if (MostrarEstado("14") == "Ocupado")
            {

                PanelMesa.PanelMesaPadre.btnMesa14.BackColor = Color.Red;
            }
            if (MostrarEstado("15") == "Preparacio")
            {

                PanelMesa.PanelMesaPadre.btnMesa15.BackColor = Color.Green;
            }
            if (MostrarEstado("15") == "Ocupado")
            {

                PanelMesa.PanelMesaPadre.btnMesa15.BackColor = Color.Red;
            }
            if (MostrarEstado("16") == "Preparacio")
            {

                PanelMesa.PanelMesaPadre.btnMesa16.BackColor = Color.Green;
            }
            if (MostrarEstado("16") == "Ocupado")
            {

                PanelMesa.PanelMesaPadre.btnMesa16.BackColor = Color.Red;
            }
            if (MostrarEstado("17") == "Preparacio")
            {

                PanelMesa.PanelMesaPadre.btnMesa17.BackColor = Color.Green;
            }
            if (MostrarEstado("17") == "Ocupado")
            {

                PanelMesa.PanelMesaPadre.btnMesa17.BackColor = Color.Red;
            }
            if (MostrarEstado("18") == "Preparacio")
            {

                PanelMesa.PanelMesaPadre.btnMesa18.BackColor = Color.Green;
            }
            if (MostrarEstado("18") == "Ocupado")
            {

                PanelMesa.PanelMesaPadre.btnMesa18.BackColor = Color.Red;
            }
            if (MostrarEstado("19") == "Preparacio")
            {

                PanelMesa.PanelMesaPadre.btnMesa19.BackColor = Color.Green;
            }
            if (MostrarEstado("19") == "Ocupado")
            {

                PanelMesa.PanelMesaPadre.btnMesa19.BackColor = Color.Red;
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
