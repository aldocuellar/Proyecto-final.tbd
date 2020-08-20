using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int posX = 0;
        int posY = 0;
        private void BarraSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }

        //--Método para mostrar un formulario en un panel
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(childForm);
            panelPrincipal.Tag =childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        //--Método para mostrar un formulario en un panel

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            openChildForm(new UsuarioForm());
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            openChildForm(new ProductoForm());
        }


    }
}
