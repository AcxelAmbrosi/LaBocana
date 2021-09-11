using Datos.inventario;
using Logica;
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
            if (MostrarEstado("1") == "Ocupado")
            {
                NumMesa = 1;
                var res = MessageBox.Show("¿Desea liberar la mesa?", "ORDEN", MessageBoxButtons.YesNo);
                if (res.ToString().Equals("Yes"))
                {
                    FrmMesas.FrmMesasPadre.button1.BackColor = Color.White;
                    CambiarEstadoLibre();
                    PanelMesa.PanelMesaPadre.btnMesa1.BackColor = Color.White;
                }
                else
                {

                }
            }
            if (MostrarEstado("1") == "Preparacio")
            {
                NumMesa = 1;
                var res = MessageBox.Show("¿La orden esta lista para entregar ?", "ORDEN", MessageBoxButtons.YesNo);
                if (res.ToString().Equals("Yes"))
                {
                    FrmMesas.FrmMesasPadre.button1.BackColor = Color.Red;
                    MessageBox.Show("Se ha enviado la orden.");
                    CambiarEstadoOcupado();
                    PanelMesa.PanelMesaPadre.btnMesa1.BackColor = Color.Red;
                }
                else
                {
                   
                }
            }
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (MostrarEstado("10") == "Ocupado")
            {
                NumMesa = 10;
                var res = MessageBox.Show("¿Desea liberar la mesa?", "ORDEN", MessageBoxButtons.YesNo);
                if (res.ToString().Equals("Yes"))
                {
                    FrmMesas.FrmMesasPadre.button10.BackColor = Color.White;
                    CambiarEstadoLibre();
                    PanelMesa.PanelMesaPadre.btnMesa10.BackColor = Color.White;
                }
                else
                {

                }
            }
            if (MostrarEstado("10") == "Preparacio")
            {
                NumMesa = 10;
                var res = MessageBox.Show("¿La orden esta lista para entregar ?", "ORDEN", MessageBoxButtons.YesNo);
                if (res.ToString().Equals("Yes"))
                {
                    FrmMesas.FrmMesasPadre.button10.BackColor = Color.Red;
                    MessageBox.Show("Se ha enviado la orden.");
                    CambiarEstadoOcupado();
                    PanelMesa.PanelMesaPadre.btnMesa10.BackColor = Color.Red;
                }
                else
                {

                }
            }
           
        }

        private void FrmMesas_Load(object sender, EventArgs e)
        {
            if (MostrarEstado("1") == "Preparacio")
            {
                FrmMesas.FrmMesasPadre.button1.BackColor = Color.Green;

            }
            if (MostrarEstado("1") == "Ocupado")
            {
                FrmMesas.FrmMesasPadre.button1.BackColor = Color.Red;

            }
            if (MostrarEstado("2") == "Preparacio")
            {
                FrmMesas.FrmMesasPadre.button2.BackColor = Color.Green;

            }
            if (MostrarEstado("2") == "Ocupado")
            {
                FrmMesas.FrmMesasPadre.button2.BackColor = Color.Red;

            }
            if (MostrarEstado("3") == "Preparacio")
            {
                FrmMesas.FrmMesasPadre.button3.BackColor = Color.Green;

            }
            if (MostrarEstado("3") == "Ocupado")
            {
                FrmMesas.FrmMesasPadre.button3.BackColor = Color.Red;

            }
            if (MostrarEstado("4") == "Preparacio")
            {
                FrmMesas.FrmMesasPadre.button4.BackColor = Color.Green;

            }
            if (MostrarEstado("4") == "Ocupado")
            {
                FrmMesas.FrmMesasPadre.button4.BackColor = Color.Red;

            }
            if (MostrarEstado("5") == "Preparacio")
            {
                FrmMesas.FrmMesasPadre.button5.BackColor = Color.Green;

            }
            if (MostrarEstado("5") == "Ocupado")
            {
                FrmMesas.FrmMesasPadre.button5.BackColor = Color.Red;

            }
            if (MostrarEstado("6") == "Preparacio")
            {
                FrmMesas.FrmMesasPadre.button6.BackColor = Color.Green;

            }
            if (MostrarEstado("6") == "Ocupado")
            {
                FrmMesas.FrmMesasPadre.button6.BackColor = Color.Red;

            }
            if (MostrarEstado("7") == "Preparacio")
            {
                FrmMesas.FrmMesasPadre.button7.BackColor = Color.Green;

            }
            if (MostrarEstado("7") == "Ocupado")
            {
                FrmMesas.FrmMesasPadre.button7.BackColor = Color.Red;

            }
            if (MostrarEstado("8") == "Preparacio")
            {
                FrmMesas.FrmMesasPadre.button8.BackColor = Color.Green;

            }
            if (MostrarEstado("8") == "Ocupado")
            {
                FrmMesas.FrmMesasPadre.button8.BackColor = Color.Red;

            }
            if (MostrarEstado("9") == "Preparacio")
            {
                FrmMesas.FrmMesasPadre.button9.BackColor = Color.Green;

            }
            if (MostrarEstado("9") == "Ocupado")
            {
                FrmMesas.FrmMesasPadre.button9.BackColor = Color.Red;

            }
            if (MostrarEstado("10") == "Preparacio")
            {
                FrmMesas.FrmMesasPadre.button10.BackColor = Color.Green;

            }
            if (MostrarEstado("10") == "Ocupado")
            {
                FrmMesas.FrmMesasPadre.button10.BackColor = Color.Red;

            }
            if (MostrarEstado("11") == "Preparacio")
            {
                FrmMesas.FrmMesasPadre.button11.BackColor = Color.Green;

            }
            if (MostrarEstado("11") == "Ocupado")
            {
                FrmMesas.FrmMesasPadre.button11.BackColor = Color.Red;

            }
            if (MostrarEstado("12") == "Preparacio")
            {
                FrmMesas.FrmMesasPadre.button12.BackColor = Color.Green;

            }
            if (MostrarEstado("12") == "Ocupado")
            {
                FrmMesas.FrmMesasPadre.button12.BackColor = Color.Red;

            }
            if (MostrarEstado("13") == "Preparacio")
            {
                FrmMesas.FrmMesasPadre.button13.BackColor = Color.Green;

            }
            if (MostrarEstado("13") == "Ocupado")
            {
                FrmMesas.FrmMesasPadre.button13.BackColor = Color.Red;

            }
            if (MostrarEstado("14") == "Preparacio")
            {
                FrmMesas.FrmMesasPadre.button14.BackColor = Color.Green;

            }
            if (MostrarEstado("14") == "Ocupado")
            {
                FrmMesas.FrmMesasPadre.button14.BackColor = Color.Red;

            }
            if (MostrarEstado("15") == "Preparacio")
            {
                FrmMesas.FrmMesasPadre.button15.BackColor = Color.Green;

            }
            if (MostrarEstado("15") == "Ocupado")
            {
                FrmMesas.FrmMesasPadre.button15.BackColor = Color.Red;

            }
            if (MostrarEstado("16") == "Preparacio")
            {
                FrmMesas.FrmMesasPadre.button16.BackColor = Color.Green;

            }
            if (MostrarEstado("16") == "Ocupado")
            {
                FrmMesas.FrmMesasPadre.button16.BackColor = Color.Red;

            }
            if (MostrarEstado("17") == "Preparacio")
            {
                FrmMesas.FrmMesasPadre.button17.BackColor = Color.Green;

            }
            if (MostrarEstado("17") == "Ocupado")
            {
                FrmMesas.FrmMesasPadre.button17.BackColor = Color.Red;

            }
            if (MostrarEstado("18") == "Preparacio")
            {
                FrmMesas.FrmMesasPadre.button18.BackColor = Color.Green;

            }
            if (MostrarEstado("18") == "Ocupado")
            {
                FrmMesas.FrmMesasPadre.button18.BackColor = Color.Red;

            }
            if (MostrarEstado("19") == "Preparacio")
            {
                FrmMesas.FrmMesasPadre.button19.BackColor = Color.Green;

            }
            if (MostrarEstado("19") == "Ocupado")
            {
                FrmMesas.FrmMesasPadre.button19.BackColor = Color.Red;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MostrarEstado("2") == "Ocupado")
            {
                NumMesa = 2;
                var res = MessageBox.Show("¿Desea liberar la mesa?", "ORDEN", MessageBoxButtons.YesNo);
                if (res.ToString().Equals("Yes"))
                {
                    FrmMesas.FrmMesasPadre.button2.BackColor = Color.White;
                    CambiarEstadoLibre();
                    PanelMesa.PanelMesaPadre.btnMesa2.BackColor = Color.White;
                }
                else
                {

                }
            }
            if (MostrarEstado("2") == "Preparacio")
            {
                NumMesa = 2;
                var res = MessageBox.Show("¿La orden esta lista para entregar ?", "ORDEN", MessageBoxButtons.YesNo);
                if (res.ToString().Equals("Yes"))
                {
                    FrmMesas.FrmMesasPadre.button2.BackColor = Color.Red;
                    MessageBox.Show("Se ha enviado la orden.");
                    CambiarEstadoOcupado();
                    PanelMesa.PanelMesaPadre.btnMesa2.BackColor = Color.Red;
                }
                else
                {

                }
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MostrarEstado("3") == "Ocupado")
            {
                NumMesa = 3;
                var res = MessageBox.Show("¿Desea liberar la mesa?", "ORDEN", MessageBoxButtons.YesNo);
                if (res.ToString().Equals("Yes"))
                {
                    FrmMesas.FrmMesasPadre.button3.BackColor = Color.White;
                    CambiarEstadoLibre();
                    PanelMesa.PanelMesaPadre.btnMesa3.BackColor = Color.White;
                }
                else
                {

                }
            }
            if (MostrarEstado("3") == "Preparacio")
            {
                NumMesa = 3;
                var res = MessageBox.Show("¿La orden esta lista para entregar ?", "ORDEN", MessageBoxButtons.YesNo);
                if (res.ToString().Equals("Yes"))
                {
                    FrmMesas.FrmMesasPadre.button3.BackColor = Color.Red;
                    MessageBox.Show("Se ha enviado la orden.");
                    CambiarEstadoOcupado();
                    PanelMesa.PanelMesaPadre.btnMesa3.BackColor = Color.Red;
                }
                else
                {

                }
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MostrarEstado("4") == "Ocupado")
            {
                NumMesa = 4;
                var res = MessageBox.Show("¿Desea liberar la mesa?", "ORDEN", MessageBoxButtons.YesNo);
                if (res.ToString().Equals("Yes"))
                {
                    FrmMesas.FrmMesasPadre.button4.BackColor = Color.White;
                    CambiarEstadoLibre();
                    PanelMesa.PanelMesaPadre.btnMesa4.BackColor = Color.White;
                }
                else
                {

                }
            }
            if (MostrarEstado("4") == "Preparacio")
            {
                NumMesa = 4;
                var res = MessageBox.Show("¿La orden esta lista para entregar ?", "ORDEN", MessageBoxButtons.YesNo);
                if (res.ToString().Equals("Yes"))
                {
                    FrmMesas.FrmMesasPadre.button4.BackColor = Color.Red;
                    MessageBox.Show("Se ha enviado la orden.");
                    CambiarEstadoOcupado();
                    PanelMesa.PanelMesaPadre.btnMesa4.BackColor = Color.Red;
                }
                else
                {

                }
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MostrarEstado("5") == "Ocupado")
            {
                NumMesa = 5;
                var res = MessageBox.Show("¿Desea liberar la mesa?", "ORDEN", MessageBoxButtons.YesNo);
                if (res.ToString().Equals("Yes"))
                {
                    FrmMesas.FrmMesasPadre.button5.BackColor = Color.White;
                    CambiarEstadoLibre();
                    PanelMesa.PanelMesaPadre.btnMesa5.BackColor = Color.White;
                }
                else
                {

                }
            }
            if (MostrarEstado("5") == "Preparacio")
            {
                NumMesa = 5;
                var res = MessageBox.Show("¿La orden esta lista para entregar ?", "ORDEN", MessageBoxButtons.YesNo);
                if (res.ToString().Equals("Yes"))
                {
                    FrmMesas.FrmMesasPadre.button5.BackColor = Color.Red;
                    MessageBox.Show("Se ha enviado la orden.");
                    CambiarEstadoOcupado();
                    PanelMesa.PanelMesaPadre.btnMesa5.BackColor = Color.Red;
                }
                else
                {

                }
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MostrarEstado("6") == "Ocupado")
            {
                NumMesa = 6;
                var res = MessageBox.Show("¿Desea liberar la mesa?", "ORDEN", MessageBoxButtons.YesNo);
                if (res.ToString().Equals("Yes"))
                {
                    FrmMesas.FrmMesasPadre.button6.BackColor = Color.White;
                    CambiarEstadoLibre();
                    PanelMesa.PanelMesaPadre.btnMesa6.BackColor = Color.White;
                }
                else
                {

                }
            }
            if (MostrarEstado("6") == "Preparacio")
            {
                NumMesa = 6;
                var res = MessageBox.Show("¿La orden esta lista para entregar ?", "ORDEN", MessageBoxButtons.YesNo);
                if (res.ToString().Equals("Yes"))
                {
                    FrmMesas.FrmMesasPadre.button6.BackColor = Color.Red;
                    MessageBox.Show("Se ha enviado la orden.");
                    CambiarEstadoOcupado();
                    PanelMesa.PanelMesaPadre.btnMesa6.BackColor = Color.Red;
                }
                else
                {

                }
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (MostrarEstado("7") == "Ocupado")
            {
                NumMesa = 7;
                var res = MessageBox.Show("¿Desea liberar la mesa?", "ORDEN", MessageBoxButtons.YesNo);
                if (res.ToString().Equals("Yes"))
                {
                    FrmMesas.FrmMesasPadre.button7.BackColor = Color.White;
                    CambiarEstadoLibre();
                    PanelMesa.PanelMesaPadre.btnMesa7.BackColor = Color.White;
                }
                else
                {

                }
            }
            if (MostrarEstado("7") == "Preparacio")
            {
                NumMesa = 7;
                var res = MessageBox.Show("¿La orden esta lista para entregar ?", "ORDEN", MessageBoxButtons.YesNo);
                if (res.ToString().Equals("Yes"))
                {
                    FrmMesas.FrmMesasPadre.button7.BackColor = Color.Red;
                    MessageBox.Show("Se ha enviado la orden.");
                    CambiarEstadoOcupado();
                    PanelMesa.PanelMesaPadre.btnMesa7.BackColor = Color.Red;
                }
                else
                {

                }
            }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (MostrarEstado("8") == "Ocupado")
            {
                NumMesa = 8;
                var res = MessageBox.Show("¿Desea liberar la mesa?", "ORDEN", MessageBoxButtons.YesNo);
                if (res.ToString().Equals("Yes"))
                {
                    FrmMesas.FrmMesasPadre.button8.BackColor = Color.White;
                    CambiarEstadoLibre();
                    PanelMesa.PanelMesaPadre.btnMesa8.BackColor = Color.White;
                }
                else
                {

                }
            }
            if (MostrarEstado("8") == "Preparacio")
            {
                NumMesa = 8;
                var res = MessageBox.Show("¿La orden esta lista para entregar ?", "ORDEN", MessageBoxButtons.YesNo);
                if (res.ToString().Equals("Yes"))
                {
                    FrmMesas.FrmMesasPadre.button8.BackColor = Color.Red;
                    MessageBox.Show("Se ha enviado la orden.");
                    CambiarEstadoOcupado();
                    PanelMesa.PanelMesaPadre.btnMesa8.BackColor = Color.Red;
                }
                else
                {

                }
            }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (MostrarEstado("9") == "Ocupado")
            {
                NumMesa = 9;
                var res = MessageBox.Show("¿Desea liberar la mesa?", "ORDEN", MessageBoxButtons.YesNo);
                if (res.ToString().Equals("Yes"))
                {
                    FrmMesas.FrmMesasPadre.button9.BackColor = Color.White;
                    CambiarEstadoLibre();
                    PanelMesa.PanelMesaPadre.btnMesa9.BackColor = Color.White;
                }
                else
                {

                }
            }
            if (MostrarEstado("9") == "Preparacio")
            {
                NumMesa = 9;
                var res = MessageBox.Show("¿La orden esta lista para entregar ?", "ORDEN", MessageBoxButtons.YesNo);
                if (res.ToString().Equals("Yes"))
                {
                    FrmMesas.FrmMesasPadre.button9.BackColor = Color.Red;
                    MessageBox.Show("Se ha enviado la orden.");
                    CambiarEstadoOcupado();
                    PanelMesa.PanelMesaPadre.btnMesa9.BackColor = Color.Red;
                }
                else
                {

                }
            }
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (MostrarEstado("11") == "Ocupado")
            {
                NumMesa = 11;
                var res = MessageBox.Show("¿Desea liberar la mesa?", "ORDEN", MessageBoxButtons.YesNo);
                if (res.ToString().Equals("Yes"))
                {
                    FrmMesas.FrmMesasPadre.button11.BackColor = Color.White;
                    CambiarEstadoLibre();
                    PanelMesa.PanelMesaPadre.btnMesa11.BackColor = Color.White;
                }
                else
                {

                }
            }
            if (MostrarEstado("11") == "Preparacio")
            {
                NumMesa = 11;
                var res = MessageBox.Show("¿La orden esta lista para entregar ?", "ORDEN", MessageBoxButtons.YesNo);
                if (res.ToString().Equals("Yes"))
                {
                    FrmMesas.FrmMesasPadre.button11.BackColor = Color.Red;
                    MessageBox.Show("Se ha enviado la orden.");
                    CambiarEstadoOcupado();
                    PanelMesa.PanelMesaPadre.btnMesa11.BackColor = Color.Red;
                }
                else
                {

                }
            }
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (MostrarEstado("12") == "Ocupado")
            {
                NumMesa = 12;
                var res = MessageBox.Show("¿Desea liberar la mesa?", "ORDEN", MessageBoxButtons.YesNo);
                if (res.ToString().Equals("Yes"))
                {
                    FrmMesas.FrmMesasPadre.button12.BackColor = Color.White;
                    CambiarEstadoLibre();
                    PanelMesa.PanelMesaPadre.btnMesa12.BackColor = Color.White;
                }
                else
                {

                }
            }
            if (MostrarEstado("12") == "Preparacio")
            {
                NumMesa = 12;
                var res = MessageBox.Show("¿La orden esta lista para entregar ?", "ORDEN", MessageBoxButtons.YesNo);
                if (res.ToString().Equals("Yes"))
                {
                    FrmMesas.FrmMesasPadre.button12.BackColor = Color.Red;
                    MessageBox.Show("Se ha enviado la orden.");
                    CambiarEstadoOcupado();
                    PanelMesa.PanelMesaPadre.btnMesa12.BackColor = Color.Red;
                }
                else
                {

                }
            }
           
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (MostrarEstado("13") == "Ocupado")
            {
                NumMesa = 13;
                var res = MessageBox.Show("¿Desea liberar la mesa?", "ORDEN", MessageBoxButtons.YesNo);
                if (res.ToString().Equals("Yes"))
                {
                    FrmMesas.FrmMesasPadre.button13.BackColor = Color.White;
                    CambiarEstadoLibre();
                    PanelMesa.PanelMesaPadre.btnMesa13.BackColor = Color.White;
                }
                else
                {

                }
            }
            if (MostrarEstado("13") == "Preparacio")
            {
                NumMesa = 13;
                var res = MessageBox.Show("¿La orden esta lista para entregar ?", "ORDEN", MessageBoxButtons.YesNo);
                if (res.ToString().Equals("Yes"))
                {
                    FrmMesas.FrmMesasPadre.button13.BackColor = Color.Red;
                    MessageBox.Show("Se ha enviado la orden.");
                    CambiarEstadoOcupado();
                    PanelMesa.PanelMesaPadre.btnMesa13.BackColor = Color.Red;
                }
                else
                {

                }
            }
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (MostrarEstado("14") == "Ocupado")
            {
                NumMesa = 14;
                var res = MessageBox.Show("¿Desea liberar la mesa?", "ORDEN", MessageBoxButtons.YesNo);
                if (res.ToString().Equals("Yes"))
                {
                    FrmMesas.FrmMesasPadre.button14.BackColor = Color.White;
                    CambiarEstadoLibre();
                    PanelMesa.PanelMesaPadre.btnMesa14.BackColor = Color.White;
                }
                else
                {

                }
            }
            if (MostrarEstado("14") == "Preparacio")
            {
                NumMesa = 14;
                var res = MessageBox.Show("¿La orden esta lista para entregar ?", "ORDEN", MessageBoxButtons.YesNo);
                if (res.ToString().Equals("Yes"))
                {
                    FrmMesas.FrmMesasPadre.button14.BackColor = Color.Red;
                    MessageBox.Show("Se ha enviado la orden.");
                    CambiarEstadoOcupado();
                    PanelMesa.PanelMesaPadre.btnMesa14.BackColor = Color.Red;
                }
                else
                {

                }
            }
          
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (MostrarEstado("15") == "Ocupado")
            {
                NumMesa = 15;
                var res = MessageBox.Show("¿Desea liberar la mesa?", "ORDEN", MessageBoxButtons.YesNo);
                if (res.ToString().Equals("Yes"))
                {
                    FrmMesas.FrmMesasPadre.button15.BackColor = Color.White;
                    CambiarEstadoLibre();
                    PanelMesa.PanelMesaPadre.btnMesa15.BackColor = Color.White;
                }
                else
                {

                }
            }
            if (MostrarEstado("15") == "Preparacio")
            {
                NumMesa = 15;
                var res = MessageBox.Show("¿La orden esta lista para entregar ?", "ORDEN", MessageBoxButtons.YesNo);
                if (res.ToString().Equals("Yes"))
                {
                    FrmMesas.FrmMesasPadre.button15.BackColor = Color.Red;
                    MessageBox.Show("Se ha enviado la orden.");
                    CambiarEstadoOcupado();
                    PanelMesa.PanelMesaPadre.btnMesa15.BackColor = Color.Red;
                }
                else
                {

                }
            }
           
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (MostrarEstado("16") == "Ocupado")
            {
                NumMesa = 16;
                var res = MessageBox.Show("¿Desea liberar la mesa?", "ORDEN", MessageBoxButtons.YesNo);
                if (res.ToString().Equals("Yes"))
                {
                    FrmMesas.FrmMesasPadre.button16.BackColor = Color.White;
                    CambiarEstadoLibre();
                    PanelMesa.PanelMesaPadre.btnMesa16.BackColor = Color.White;
                }
                else
                {

                }
            }
            if (MostrarEstado("16") == "Preparacio")
            {
                NumMesa = 16;
                var res = MessageBox.Show("¿La orden esta lista para entregar ?", "ORDEN", MessageBoxButtons.YesNo);
                if (res.ToString().Equals("Yes"))
                {
                    FrmMesas.FrmMesasPadre.button16.BackColor = Color.Red;
                    MessageBox.Show("Se ha enviado la orden.");
                    CambiarEstadoOcupado();
                    PanelMesa.PanelMesaPadre.btnMesa16.BackColor = Color.Red;
                }
                else
                {

                }
            }
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (MostrarEstado("17") == "Ocupado")
            {
                NumMesa = 17;
                var res = MessageBox.Show("¿Desea liberar la mesa?", "ORDEN", MessageBoxButtons.YesNo);
                if (res.ToString().Equals("Yes"))
                {
                    FrmMesas.FrmMesasPadre.button17.BackColor = Color.White;
                    CambiarEstadoLibre();
                    PanelMesa.PanelMesaPadre.btnMesa17.BackColor = Color.White;
                }
                else
                {

                }
            }
            if (MostrarEstado("17") == "Preparacio")
            {
                NumMesa = 17;
                var res = MessageBox.Show("¿La orden esta lista para entregar ?", "ORDEN", MessageBoxButtons.YesNo);
                if (res.ToString().Equals("Yes"))
                {
                    FrmMesas.FrmMesasPadre.button17.BackColor = Color.Red;
                    MessageBox.Show("Se ha enviado la orden.");
                    CambiarEstadoOcupado();
                    PanelMesa.PanelMesaPadre.btnMesa17.BackColor = Color.Red;
                }
                else
                {

                }
            }
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (MostrarEstado("18") == "Ocupado")
            {
                NumMesa = 18;
                var res = MessageBox.Show("¿Desea liberar la mesa?", "ORDEN", MessageBoxButtons.YesNo);
                if (res.ToString().Equals("Yes"))
                {
                    FrmMesas.FrmMesasPadre.button18.BackColor = Color.White;
                    CambiarEstadoLibre();
                    PanelMesa.PanelMesaPadre.btnMesa18.BackColor = Color.White;
                }
                else
                {

                }
            }
            if (MostrarEstado("18") == "Preparacio")
            {
                NumMesa = 18;
                var res = MessageBox.Show("¿La orden esta lista para entregar ?", "ORDEN", MessageBoxButtons.YesNo);
                if (res.ToString().Equals("Yes"))
                {
                    FrmMesas.FrmMesasPadre.button18.BackColor = Color.Red;
                    MessageBox.Show("Se ha enviado la orden.");
                    CambiarEstadoOcupado();
                    PanelMesa.PanelMesaPadre.btnMesa18.BackColor = Color.Red;
                }
                else
                {

                }
            }
           
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (MostrarEstado("19") == "Ocupado")
            {
                NumMesa = 19;
                var res = MessageBox.Show("¿Desea liberar la mesa?", "ORDEN", MessageBoxButtons.YesNo);
                if (res.ToString().Equals("Yes"))
                {
                    FrmMesas.FrmMesasPadre.button19.BackColor = Color.White;
                    CambiarEstadoLibre();
                    PanelMesa.PanelMesaPadre.btnMesa19.BackColor = Color.White;
                }
                else
                {

                }
            }
            if (MostrarEstado("19") == "Preparacio")
            {
                NumMesa = 19;
                var res = MessageBox.Show("¿La orden esta lista para entregar ?", "ORDEN", MessageBoxButtons.YesNo);
                if (res.ToString().Equals("Yes"))
                {
                    FrmMesas.FrmMesasPadre.button19.BackColor = Color.Red;
                    MessageBox.Show("Se ha enviado la orden.");
                    CambiarEstadoOcupado();
                    PanelMesa.PanelMesaPadre.btnMesa19.BackColor = Color.Red;
                }
                else
                {

                }
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
        private void CambiarEstadoOcupado()
        {
            Mesa parametros = new Mesa();
            MesaD funcion = new MesaD();

            parametros.Id_Mesa1 = NumMesa;
            parametros.Estado = "Ocupado";

            funcion.CambiarEstado(parametros);

        }
        private void CambiarEstadoLibre()
        {
            Mesa parametros = new Mesa();
            MesaD funcion = new MesaD();

            parametros.Id_Mesa1 = NumMesa;
            parametros.Estado = "Libre";

            funcion.CambiarEstado(parametros);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
