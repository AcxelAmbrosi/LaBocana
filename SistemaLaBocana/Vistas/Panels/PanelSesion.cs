﻿using System;
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
    public partial class PanelSesion : Form
    {
        public PanelSesion()
        {
            InitializeComponent();
        }

        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            Form frm = new PanelAdministracion();
            frm.Show();
        }
    }
}
