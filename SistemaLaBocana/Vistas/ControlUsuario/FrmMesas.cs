using Datos.inventario;
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

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void FrmMesas_Load(object sender, EventArgs e)
        {
            if (MostrarEstado("1") == "Preparacio")
            {
                FrmMesas.FrmMesasPadre.button1.BackColor = Color.Green;

            }
            if (MostrarEstado("2") == "Preparacio")
            {
                FrmMesas.FrmMesasPadre.button2.BackColor = Color.Green;

            }
            if (MostrarEstado("3") == "Preparacio")
            {
                FrmMesas.FrmMesasPadre.button3.BackColor = Color.Green;

            }
            if (MostrarEstado("4") == "Preparacio")
            {
                FrmMesas.FrmMesasPadre.button4.BackColor = Color.Green;

            }
            if (MostrarEstado("5") == "Preparacio")
            {
                FrmMesas.FrmMesasPadre.button5.BackColor = Color.Green;

            }
            if (MostrarEstado("6") == "Preparacio")
            {
                FrmMesas.FrmMesasPadre.button6.BackColor = Color.Green;

            }
            if (MostrarEstado("7") == "Preparacio")
            {
                FrmMesas.FrmMesasPadre.button7.BackColor = Color.Green;

            }
            if (MostrarEstado("8") == "Preparacio")
            {
                FrmMesas.FrmMesasPadre.button8.BackColor = Color.Green;

            }
            if (MostrarEstado("9") == "Preparacio")
            {
                FrmMesas.FrmMesasPadre.button9.BackColor = Color.Green;

            }
            if (MostrarEstado("10") == "Preparacio")
            {
                FrmMesas.FrmMesasPadre.button10.BackColor = Color.Green;

            }
            if (MostrarEstado("11") == "Preparacio")
            {
                FrmMesas.FrmMesasPadre.button11.BackColor = Color.Green;

            }
            if (MostrarEstado("12") == "Preparacio")
            {
                FrmMesas.FrmMesasPadre.button12.BackColor = Color.Green;

            }
            if (MostrarEstado("13") == "Preparacio")
            {
                FrmMesas.FrmMesasPadre.button13.BackColor = Color.Green;

            }
            if (MostrarEstado("14") == "Preparacio")
            {
                FrmMesas.FrmMesasPadre.button14.BackColor = Color.Green;

            }
            if (MostrarEstado("15") == "Preparacio")
            {
                FrmMesas.FrmMesasPadre.button15.BackColor = Color.Green;

            }
            if (MostrarEstado("16") == "Preparacio")
            {
                FrmMesas.FrmMesasPadre.button16.BackColor = Color.Green;

            }
            if (MostrarEstado("17") == "Preparacio")
            {
                FrmMesas.FrmMesasPadre.button17.BackColor = Color.Green;

            }
            if (MostrarEstado("18") == "Preparacio")
            {
                FrmMesas.FrmMesasPadre.button18.BackColor = Color.Green;

            }
            if (MostrarEstado("19") == "Preparacio")
            {
                FrmMesas.FrmMesasPadre.button19.BackColor = Color.Green;

            }
        }
        private String MostrarEstado(string id)
        {
            String estado = "";

            DataTable table = new DataTable();
            MesaD funcion = new MesaD();

            try
            {


                funcion.BuscarMesa(ref table, id);
                estado = Convert.ToString(table.Rows[0][1]);

            }
            catch (Exception)
            {

            }
            return estado;
        }

    }
}
