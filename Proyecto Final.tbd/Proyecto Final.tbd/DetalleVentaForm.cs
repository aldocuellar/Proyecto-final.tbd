﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final.tbd
{
    public partial class DetalleVentaForm : Form
    {
        public DetalleVentaForm()
        {
            InitializeComponent();
        }

        private void btnCerrarDV_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
