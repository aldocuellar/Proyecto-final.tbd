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
    public partial class TipoUsuarioForm : Form
    {
        public TipoUsuarioForm()
        {
            InitializeComponent();
        }

        private void ActualizarGridView()
        {
            ejemplofarmaciaEntities datos = new ejemplofarmaciaEntities();
            var db = (from u in datos.Tipo_Usuario
                      select new
                      {
                          Id_Tipo_Usuario = u.Id_Tipo_Usuario,
                          Tipo_Usuario = u.Nombre_TU,
                      }).ToList();

            dgvTU.DataSource = db;
            dgvTU.Refresh();
            dgvTU.ClearSelection();
        }

        private void btnCerrarTU_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsertTU_Click(object sender, EventArgs e)
        {

        }

        private void btnModTU_Click(object sender, EventArgs e)
        {

        }

        private void btnDropTU_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectTU_Click(object sender, EventArgs e)
        {

        }
    }
}
